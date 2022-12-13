using Newtonsoft.Json;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Plan2
{
    public partial class WeatherBriefing : Form
    {
        private RestClient restClient;
        private RestRequest request;
        private List<Bitmap> Images = new List<Bitmap>();
        private ViewMode view = new ViewMode();
        private int SelectedView;

        public WeatherBriefing()
        {
            InitializeComponent();
        }

        private void WeatherBriefing_Load(object sender, EventArgs e)
        {
            string url = @"https://api.checkwx.com/metar/LPEV/nearest/decoded";
            restClient = new RestClient(url);
            request = new RestRequest();
            request.AddHeader("X-API-Key", "333726f1fff94c75b4088184b6");
            RestResponse response = restClient.ExecuteGet(request);

            if (response.IsSuccessful)
            {
                Planner.Metar.WeatherResult result = JsonConvert.DeserializeObject<Planner.Metar.WeatherResult>(response.Content);
                MetarLabel.Text = "Metar: " + result.data[0].icao + " das " + result.data[0].observed;
                WindLabel.Text = "Vento: " + result.data[0].wind.degrees.ToString() + "º " + result.data[0].wind.speed_kts + "kts";
                Visibilidade.Text = "Visibilidade: " + result.data[0].visibility.meters + " metros";
                int lowerCeiling = 0; double lowerFeet = 10000;
                for (int i = 0; i < result.data[0].clouds.Count; i++)
                {
                    if (result.data[0].clouds[i].code == "BKN" || result.data[0].clouds[i].code == "OVC" && lowerFeet > result.data[0].clouds[i].feet)
                    {
                        lowerCeiling = i;
                    }
                }

                Ceiling.Text = "Ceiling: " + result.data[0].clouds[lowerCeiling].base_feet_agl + " feet";
                string runWayInuse = ""; double runwayHeading = 0, crossWind = 0, headWind = 0;
                //crosswind speed = wind speed × sin(α)
                //head(or tail)wind speed = wind speed × cos(α)

                double windDegrees = result.data[0].wind.degrees, windSpeed = result.data[0].wind.speed_kts;

                List<int> list = new List<int> { 190, 10 };
                int closest = list.Aggregate((x, y) => Math.Abs(x - windDegrees) < Math.Abs(y - windDegrees) ? x : y);

                if (closest == 190)
                {
                    runWayInuse = "19º";
                    runwayHeading = 190;
                    crossWind = Math.Abs(Math.Round(windSpeed * Math.Sin(Math.Abs(184 - windDegrees))));
                    headWind = Math.Abs(Math.Round(windSpeed * Math.Cos(Math.Abs(184 - windDegrees))));
                }
                else
                {
                    runWayInuse = "01º";
                    runwayHeading = 10;
                    crossWind = Math.Abs(Math.Round(windSpeed * Math.Sin(Math.Abs(4 - windDegrees))));
                    headWind = Math.Abs(Math.Round(windSpeed * Math.Cos(Math.Abs(4 - windDegrees))));
                }
                Crosswind.Text = "Crosswind: " + crossWind + " kts";
                Headwind.Text = "Headwind: " + headWind + " kts";

                Runway.Text = "Runway: " + runWayInuse;
                editor.Text = result.data[0].raw_text;

                url = @"https://api.checkwx.com/taf/LPEV/nearest/decoded";
                restClient = new RestClient(url);
                request = new RestRequest();
                request.AddHeader("X-API-Key", "333726f1fff94c75b4088184b6");
                response = restClient.ExecuteGet(request);
                if (response.IsSuccessful)
                {
                    Planner.TAF.WeatherResult tafResult = JsonConvert.DeserializeObject<Planner.TAF.WeatherResult>(response.Content);


                    // Split the text on the keywords
                    string text = tafResult.data[0].raw_text;

                    editor.Text += "\n" + text;
                }
                SelectedView = 0;
                view = ViewMode.WindForecast;
                editor.ReadOnly = true;
                Images.Clear();
                GetWafc();
            }
        }
        private void GetWafc()
        {
            string hora = (rangeSlider1.Value - 6).ToString();

            if (hora.Length < 3)
            {
                int sizeNeeded = 3 - hora.Length;
                for (int i = 0; i < sizeNeeded; i++)
                {
                    hora = "0" + hora;
                }
            }
            string link = "https://en.vedur.is/photos/flugkort_eur_FL050/" + DateTime.Now.ToString("yyMMdd") + "_0600_" + (hora) + ".png";
            string location = Path.GetTempPath() + Guid.NewGuid().ToString() + ".png";
            // Create a new WebClient instance
            using (WebClient client = new WebClient())
            {

                // Get the HTML content of the webpage
                client.DownloadFile((link), location);

                pictureBox1.Image = (Bitmap)Bitmap.FromFile(location);
                pictureBox1.Refresh();
            }
        }
        private void GetPressureForecastChart()
        {

            string time = (rangeSlider1.Value).ToString() + ":00";
            string type = "";
            if (checkBox1.Checked)
            {
                type = "PPVE89";
            }
            else
            {
                type = "PPVA89";
            }

            // Parse the time string into a DateTime object
            DateTime.TryParse(time, out DateTime dateTime);

            // Get the hour and minute values from the DateTime object
            int hour = dateTime.Hour;
            int minute = dateTime.Minute;

            // Format the hour and minute values as "HHmm"
            string hhmm = hour.ToString("00") + minute.ToString("00");
            string link = "http://brunnur.vedur.is/flugkort/" + type + "_EGRR_" + hhmm + ".png";
            string location = Path.GetTempPath() + Guid.NewGuid().ToString() + ".png";
            // Create a new WebClient instance
            using (WebClient client = new WebClient())
            {

                // Get the HTML content of the webpage
                client.DownloadFile((link), location);

                pictureBox1.Image = (Bitmap)Bitmap.FromFile(location);
                pictureBox1.Refresh();
            }
        }
        private void GetSIGWX()
        {
            string time = (rangeSlider1.Value).ToString() + ":00";

            // Parse the time string into a DateTime object
            DateTime.TryParse(time, out DateTime dateTime);

            // Get the hour and minute values from the DateTime object
            int hour = dateTime.Hour;
            int minute = dateTime.Minute;

            // Format the hour and minute values as "HHmm"
            string hhmm = hour.ToString("00") + minute.ToString("00");
            string link = "https://www.vedur.is/photos/flugkort/PGDE14_EGRR_" + hhmm + ".png";
            string location = Path.GetTempPath() + Guid.NewGuid().ToString() + ".png";
            // Create a new WebClient instance
            using (WebClient client = new WebClient())
            {

                // Get the HTML content of the webpage
                client.DownloadFile((link), location);

                pictureBox1.Image = (Bitmap)Bitmap.FromFile(location);
                pictureBox1.Refresh();
            }
        }

        static string[] ExtractImageUrls(string html)
        {
            // Use a regular expression to find all image URLs in the HTML
            string pattern = @"<img\s[^>]*?src\s*=\s*['""]([^'""\s>]+).*?>";
            MatchCollection matches = Regex.Matches(html, pattern, RegexOptions.IgnoreCase);

            // Create a list to hold the image URLs
            List<string> imageUrls = new List<string>();

            // Loop through all the matches
            foreach (Match match in matches)
            {
                // Get the image URL from the match
                string imageUrl = match.Groups[1].Value;

                // Add the URL to the list
                imageUrls.Add(imageUrl);
            }

            // Return the list of image URLs
            return imageUrls.ToArray();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string url = @"https://api.checkwx.com/metar/" + Airport.Text + "/decoded";
            restClient = new RestClient(url);
            request = new RestRequest();
            request.AddHeader("X-API-Key", "333726f1fff94c75b4088184b6");
            RestResponse response = restClient.ExecuteGet(request);

            if (response.IsSuccessful)
            {
                Planner.Metar.WeatherResult result = JsonConvert.DeserializeObject<Planner.Metar.WeatherResult>(response.Content);
                if (result.results == 0)
                {
                    url = @"https://api.checkwx.com/metar/" + Airport.Text + "/nearest/decoded";
                    restClient = new RestClient(url);
                    request = new RestRequest();
                    request.AddHeader("X-API-Key", "333726f1fff94c75b4088184b6");
                    response = restClient.ExecuteGet(request);
                    if (response.IsSuccessful)
                        result = JsonConvert.DeserializeObject<Planner.Metar.WeatherResult>(response.Content);
                }

                if (result.results != 0)
                {
                    MetarLabel.Text = "Metar: " + result.data[0].icao + " das " + result.data[0].observed;
                    WindLabel.Text = "Vento: " + result.data[0].wind.degrees.ToString() + "º " + result.data[0].wind.speed_kts + "kts";
                    Visibilidade.Text = "Visibilidade: " + result.data[0].visibility.meters + " metros";
                    int lowerCeiling = 0; double lowerFeet = 10000;
                    for (int i = 0; i < result.data[0].clouds.Count; i++)
                    {
                        if (result.data[0].clouds[i].code == "BKN" || result.data[0].clouds[i].code == "OVC" && lowerFeet > result.data[0].clouds[i].feet)
                        {
                            lowerCeiling = i;
                        }
                    }

                    Ceiling.Text = "Ceiling: " + result.data[0].clouds[lowerCeiling].base_feet_agl + " feet";
                    string runWayInuse = ""; double runwayHeading = 0, crossWind = 0, headWind = 0;
                    //crosswind speed = wind speed × sin(α)
                    //head(or tail)wind speed = wind speed × cos(α)

                    double windDegrees = result.data[0].wind.degrees, windSpeed = result.data[0].wind.speed_kts;

                    List<int> list = new List<int> { 190, 10 };
                    int closest = list.Aggregate((x, y) => Math.Abs(x - windDegrees) < Math.Abs(y - windDegrees) ? x : y);

                    if (closest == 190)
                    {
                        runWayInuse = "19º";
                        runwayHeading = 190;
                        crossWind = Math.Abs(Math.Round(windSpeed * Math.Sin(Math.Abs(184 - windDegrees))));
                        headWind = Math.Abs(Math.Round(windSpeed * Math.Cos(Math.Abs(184 - windDegrees))));
                    }
                    else
                    {
                        runWayInuse = "01º";
                        runwayHeading = 10;
                        crossWind = Math.Abs(Math.Round(windSpeed * Math.Sin(Math.Abs(4 - windDegrees))));
                        headWind = Math.Abs(Math.Round(windSpeed * Math.Cos(Math.Abs(4 - windDegrees))));
                    }
                    Crosswind.Text = "Crosswind: " + crossWind + " kts";
                    Headwind.Text = "Headwind: " + headWind + " kts";

                    Runway.Text = "Runway: " + runWayInuse;
                    editor.Text = result.data[0].raw_text;

                    url = @"https://api.checkwx.com/taf/" + Airport.Text + "/nearest/decoded";
                    restClient = new RestClient(url);
                    request = new RestRequest();
                    request.AddHeader("X-API-Key", "333726f1fff94c75b4088184b6");
                    response = restClient.ExecuteGet(request);
                    if (response.IsSuccessful)
                    {
                        Planner.TAF.WeatherResult tafResult = JsonConvert.DeserializeObject<Planner.TAF.WeatherResult>(response.Content);
                        editor.Text += "\n" + tafResult.data[0].raw_text;
                    }
                    editor.ReadOnly = true;
                }
            }
        }

        private void RangeSlider1_ValueChanged(object sender, EventArgs e)
        {
            switch (view)
            {
                case ViewMode.WindForecast:
                    GetWafc();
                    break;
                case ViewMode.PressureForecast:
                    GetPressureForecastChart();
                    break;
                case ViewMode.SIGWX:
                    GetSIGWX();
                    break;
                default:
                    break;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 8, XFontStyle.Bold);

            string text = editor.Text;
            double maxWidth = 100; // The maximum width of the string

            XSize size = gfx.MeasureString(text, font);

            string[] words = editor.Text.Split(' ');

            // Set the starting position for the text
            double x = 0;
            double y = 0;

            // Loop through the words in the string
            foreach (string word in words)
            {
                // Measure the length of the word
                size = gfx.MeasureString(word, font);

                // If the word would not fit on the current line, move to the next line
                if (x + size.Width > page.Width)
                {
                    x = 0;
                    y += font.Height;
                }

                // Draw the word at the current position
                gfx.DrawString(word, font, XBrushes.Black, new XRect(x, y, size.Width, size.Height), XStringFormats.TopLeft);

                // Increment the x position by the width of the word
                x += size.Width;
            }

            for (int i = 0; i < Images.Count; i++)
            {
                Guid guid = Guid.NewGuid();
                string outputFileName = Path.GetTempPath() + "image" + guid.ToString() + ".png";
                Images[i].Save(outputFileName, ImageFormat.Png);
                page = document.AddPage();
                gfx = XGraphics.FromPdfPage(page);
                XImage image = XImage.FromFile(outputFileName);
                gfx.DrawString(Images[i].Tag.ToString(), font, XBrushes.Black, new XRect(0, 0, 100, 50), XStringFormats.TopLeft);
                gfx.DrawImage(image, 0, 0 + 30, image.PixelWidth, image.PixelHeight);
                image.Dispose();
                File.Delete(outputFileName);
            }

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            dialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.ShowDialog();
            if (dialog.SelectedPath != "")
                document.Save(dialog.SelectedPath + "\\WeatherBriefing.pdf");
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            SelectedView--;
            if (SelectedView < 0)
                SelectedView = 0;
            view = (ViewMode)SelectedView; checkBox1.Visible = false;
            switch (view)
            {
                case ViewMode.WindForecast:
                    label7.Text = "Upper Wind and Temperature Chart for FL050";
                    label7.Refresh();

                    rangeSlider1.Maximum = 21;
                    rangeSlider1.Minimum = 12;
                    rangeSlider1.MaximumRange = 21;
                    rangeSlider1.MinimumRange = 12;
                    rangeSlider1.SmallChange = 3;
                    rangeSlider1.LargeChange = 3;
                    rangeSlider1.Value = 12;
                    label2.Text = "12:00";
                    label3.Text = "15:00";
                    label4.Text = "18:00";
                    label5.Text = "21:00";

                    GetWafc();
                    break;
                case ViewMode.PressureForecast:
                    GetPressureForecastChart();
                    checkBox1.Visible = true;
                    if (!checkBox1.Checked)
                    {
                        label7.Text = "Surface analysis chart";
                    }
                    else
                    {
                        label7.Text = "Surface forecast chart";
                    }
                    label7.Refresh();

                    rangeSlider1.Maximum = 18;
                    rangeSlider1.Minimum = 0;
                    rangeSlider1.MaximumRange = 18;
                    rangeSlider1.MinimumRange = 0;
                    rangeSlider1.SmallChange = 6;
                    rangeSlider1.LargeChange = 6;
                    rangeSlider1.Value = 0;
                    label2.Text = "00:00";
                    label3.Text = "06:00";
                    label4.Text = "12:00";
                    label5.Text = "18:00";
                    break;
                case ViewMode.SIGWX:
                    label7.Text = "Significant weather chart";
                    label7.Refresh();

                    rangeSlider1.Maximum = 18;
                    rangeSlider1.Minimum = 0;
                    rangeSlider1.MaximumRange = 18;
                    rangeSlider1.MinimumRange = 0;
                    rangeSlider1.SmallChange = 6;
                    rangeSlider1.LargeChange = 6; rangeSlider1.Value = 0;

                    label2.Text = "00:00";
                    label3.Text = "06:00";
                    label4.Text = "12:00";
                    label5.Text = "18:00";
                    GetSIGWX();
                    break;
                default:
                    break;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SelectedView++;
            if (SelectedView > 2)
                SelectedView = 2;
            view = (ViewMode)SelectedView; checkBox1.Visible = false;
            switch (view)
            {
                case ViewMode.WindForecast:
                    label7.Text = "Upper Wind and Temperature Chart for FL050";
                    label7.Refresh();

                    rangeSlider1.Maximum = 21;
                    rangeSlider1.Minimum = 12;
                    rangeSlider1.MaximumRange = 21;
                    rangeSlider1.MinimumRange = 12;
                    rangeSlider1.SmallChange = 3;
                    rangeSlider1.LargeChange = 3;
                    rangeSlider1.Value = 12;
                    label2.Text = "12:00";
                    label3.Text = "15:00";
                    label4.Text = "18:00";
                    label5.Text = "21:00";

                    GetWafc();
                    break;
                case ViewMode.PressureForecast:
                    checkBox1.Visible = true;
                    if (!checkBox1.Checked)
                    {
                        label7.Text = "Surface analysis chart";
                    }
                    else
                    {
                        label7.Text = "Surface forecast chart";
                    }
                    label7.Refresh();

                    rangeSlider1.Maximum = 18;
                    rangeSlider1.Minimum = 0;
                    rangeSlider1.MaximumRange = 18;
                    rangeSlider1.MinimumRange = 0;
                    rangeSlider1.SmallChange = 6;
                    rangeSlider1.LargeChange = 6;
                    rangeSlider1.Value = 0;
                    label2.Text = "00:00";
                    label3.Text = "06:00";
                    label4.Text = "12:00";
                    label5.Text = "18:00";

                    GetPressureForecastChart();
                    break;
                case ViewMode.SIGWX:
                    label7.Text = "Significant weather chart";
                    label7.Refresh();

                    rangeSlider1.Maximum = 18;
                    rangeSlider1.Minimum = 0;
                    rangeSlider1.MaximumRange = 18;
                    rangeSlider1.MinimumRange = 0;
                    rangeSlider1.SmallChange = 6;
                    rangeSlider1.LargeChange = 6;
                    rangeSlider1.Value = 0;
                    label2.Text = "00:00";
                    label3.Text = "06:00";
                    label4.Text = "12:00";
                    label5.Text = "18:00";

                    GetSIGWX();
                    break;
                default:
                    break;
            }
        }

        private void RangeSlider1_Scroll(object sender, EventArgs e)
        {
            int value = rangeSlider1.Value;

            // If the remainder of the value when divided by 3 is not 0,
            // find the nearest value that has a remainder of 0
            if (value % rangeSlider1.LargeChange != 0)
            {
                // If the value is less than 3, set it to 0
                if (value < rangeSlider1.LargeChange)
                {
                    value = 0;
                }
                // Otherwise, round the value up or down to the nearest multiple of 3
                else
                {
                    value = value + (rangeSlider1.LargeChange - (value % rangeSlider1.LargeChange));
                }
            }
            rangeSlider1.Value = value;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Forecast";
                label7.Text = "Surface forecast chart";
            }
            else
            {
                checkBox1.Text = "Analysis";
                label7.Text = "Surface analysis chart";
            }

            GetPressureForecastChart();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string tag = view.ToString();
            if (view == ViewMode.PressureForecast)
                tag = view.ToString() + "_" + checkBox1.Text;

            Bitmap bit = Images.Find(x => x.Tag.ToString() == tag);
            if (bit == null)
            {
                Bitmap bmp = new Bitmap(900, 608);
                pictureBox1.DrawToBitmap(bmp, pictureBox1.ClientRectangle);
                bmp.Tag = tag;
                Images.Add(bmp);
            }
            else
            {
                pictureBox1.DrawToBitmap(bit, pictureBox1.ClientRectangle);
                Images[Images.IndexOf(Images.Find(x => x.Tag.ToString() == tag))] = (bit);
            }
            label6.Text = Images.Count + " imagens adicionadas";

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Images.Clear(); label6.Text = Images.Count + " imagens adicionadas";
        }
    }
    enum ViewMode
    {
        WindForecast = 0,
        PressureForecast = 1,
        SIGWX = 2
    }
}
