using PdfSharp.Drawing;
using PdfSharp.Pdf;
using Planner.WeightAndBalance.WeightAndBalanceCalculator;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Resources;
using System.Windows.Forms;
using Resources = Plan2.Resources;

namespace Planner
{
    public partial class Weighing : Form
    {
        public string AirportField { get; set; }
        public string Response { get; set; }
        public int EmptyWeight { get; set; }
        public string PlaneName { get; set; }
        public double EmptyWeightMomentum { get; set; }
        public string PlaneCode { get; set; }
        private bool isSystem;
        private int CurrentImageBeingShown = 0;

        public Weighing()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            Plane.Text = PlaneName.ToUpper();

            EmptyWeightField.Text = EmptyWeight.ToString() + " Kg";
            EmptyWeightField.ReadOnly = true;
            EmptyWeightMomentField.Text = EmptyWeightMomentum.ToString() + " Kg";
            EmptyWeightMomentField.ReadOnly = true;
            TotalLandingField.ReadOnly = true;
            TotalLandingtMomentField.ReadOnly = true;
            PilotWeightMomentField.ReadOnly = true;
            CoPilotWeightMomentField.ReadOnly = true;
            CargoWeightMomentField.ReadOnly = true;
            FuelWeightMomentField.ReadOnly = true;
            PilotWeightMomentField.ReadOnly = true;

        }

        private void ParamsChanged(object sender, EventArgs e)
        {

            // Parse the input values from the text fields
            double.TryParse(PilotWeightField.Text, out double pilotWeight);
            double.TryParse(CoPilotWeightField.Text, out double copilotWeight);
            double.TryParse(CargoWeightField.Text, out double cargoWeight);
            double.TryParse(FuelWeightField.Text, out double fuelWeight);
            double.TryParse(FuelBurnedField.Text, out double fuelBurned);

            // Create an instance of the WeightAndBalanceCalculator class and set the weight and balance parameters
            WeightAndBalanceCalculator cal = new WeightAndBalanceCalculator(PlaneCode, pilotWeight, copilotWeight, cargoWeight, fuelWeight);

            // Call the CalculateWeightAndBalanceForTakeoff() method to perform the weight and balance calculations for takeoff
            WeightConfiguration TakeOffConfig = cal.CalculateWeightAndBalanceForTakeoff();
            isSystem = true;

            PilotWeightField.Text = pilotWeight.ToString();
            CoPilotWeightField.Text = copilotWeight.ToString();
            CargoWeightField.Text = cargoWeight.ToString();
            FuelWeightField.Text = fuelWeight.ToString();


            PilotWeightMomentField.Text = TakeOffConfig.PilotWeightMoment.ToString("N2");
            CoPilotWeightMomentField.Text = TakeOffConfig.CopilotWeightMoment.ToString("N2");
            CargoWeightMomentField.Text = TakeOffConfig.CargoMoment.ToString("N2");
            FuelWeightMomentField.Text = TakeOffConfig.FuelMoment.ToString("N2");
            PilotWeightMomentField.Text = TakeOffConfig.PilotWeightMoment.ToString("N2");
            TotalTakeOFFField.Text = TakeOffConfig.TotalWeight.ToString("N2");
            TotalTakeOFFtMomentField.Text = TakeOffConfig.TotalMoment.ToString("N2");
            TakeoffCG.Text = (TakeOffConfig.TotalMoment / TakeOffConfig.TotalWeight).ToString("N4");
            TakeOffConfig = cal.CalculateWeightAndBalanceForLanding(fuelBurned);
            FuelBurnMomentField.Text = TakeOffConfig.FuelMoment.ToString("N2");
            TotalLandingField.Text = TakeOffConfig.TotalWeight.ToString("N2");
            TotalLandingtMomentField.Text = TakeOffConfig.TotalMoment.ToString("N2");

            LandingCG.Text = (TakeOffConfig.TotalMoment / TakeOffConfig.TotalWeight).ToString("N4");


            isSystem = false;

            (sender as RichTextBox).Select((sender as RichTextBox).Text.Length, 0); ;


            pictureBox1.Invalidate();
        }

        private async void DownloadMetar_click(object sender, EventArgs e)
        {
            CurrentImageBeingShown = -1;

            PdfDocument document = new PdfDocument();


            for (int i = 0; i < 3; i++)
            {
                Button2_Click(pictureBox1, null);
                pictureBox1.Invalidate();
                Bitmap bmp = new Bitmap(746, 490);
                pictureBox1.DrawToBitmap(bmp, pictureBox1.ClientRectangle);
                Guid guid = Guid.NewGuid();
                string outputFileName = Path.GetTempPath() + "image" + guid.ToString() + ".png";
                using (MemoryStream memory = new MemoryStream())
                {
                    using (FileStream fs = new FileStream(outputFileName, FileMode.Create, FileAccess.ReadWrite))
                    {
                        bmp.Save(memory, ImageFormat.Png);
                        byte[] bytes = memory.ToArray();
                        fs.Write(bytes, 0, bytes.Length);
                        fs.Close();
                    }
                }
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XImage image = XImage.FromFile(Path.GetTempPath() + "image" + guid.ToString() + ".png");
                gfx.DrawImage(image, 0, 0);
            }

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            dialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.ShowDialog();
            if (dialog.SelectedPath != "")
                document.Save(dialog.SelectedPath + "\\WeightAndBalance.pdf");

            CurrentImageBeingShown = -1;
            Button2_Click(pictureBox1, null);
        }

        private void Weather_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void EmptyWeightField_TextChanged(object sender, EventArgs e)
        {
            if (!isSystem)
                ParamsChanged(sender, e);
        }

        private void EmptyWeightMomentField_TextChanged(object sender, EventArgs e)
        {
            if (!isSystem)
                ParamsChanged(sender, e);
        }

        private void PilotWeightField_TextChanged(object sender, EventArgs e)
        {
            if (!isSystem)
                ParamsChanged(sender, e);
        }

        private void PilotWeightMomentField_TextChanged(object sender, EventArgs e)
        {
            if (!isSystem)
                ParamsChanged(sender, e);
        }

        private void CoPilotWeightField_TextChanged(object sender, EventArgs e)
        {
            if (!isSystem)
                ParamsChanged(sender, e);
        }

        private void CoPilotWeightMomentField_TextChanged(object sender, EventArgs e)
        {
            if (!isSystem)
                ParamsChanged(sender, e);
        }

        private void CargoWeightField_TextChanged(object sender, EventArgs e)
        {
            if (!isSystem)
                ParamsChanged(sender, e);
        }

        private void CargoWeightMomentField_TextChanged(object sender, EventArgs e)
        {
            if (!isSystem)
                ParamsChanged(sender, e);
        }

        private void FuelWeightField_TextChanged(object sender, EventArgs e)
        {
            if (!isSystem)
                ParamsChanged(sender, e);
        }

        private void FuelWeightMomentField_TextChanged(object sender, EventArgs e)
        {
            if (!isSystem)
                ParamsChanged(sender, e);
        }

        private void TotalTakeOFFField_TextChanged(object sender, EventArgs e)
        {
            if (!isSystem)
                ParamsChanged(sender, e);
        }

        private void TotalTakeOFFtMomentField_TextChanged(object sender, EventArgs e)
        {
            if (!isSystem)
                ParamsChanged(sender, e);
        }

        private void FuelBurnedField_TextChanged(object sender, EventArgs e)
        {
            if (!isSystem)
                ParamsChanged(sender, e);
        }

        private void TotalLandingField_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 12, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.Black);

            switch (CurrentImageBeingShown)
            {
                case 0:

                    StringFormat format = new StringFormat();
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;

                    g.DrawString(EmptyWeight.ToString(), font, brush, new PointF(365, 175), format);
                    g.DrawString(EmptyWeightMomentum.ToString(), font, brush, new PointF(650, 175), format);

                    g.DrawString(PilotWeightField.Text, font, brush, new PointF(365, 220), format);
                    g.DrawString(PilotWeightMomentField.Text, font, brush, new PointF(650, 220), format);

                    g.DrawString(CoPilotWeightField.Text, font, brush, new PointF(365, 245), format);
                    g.DrawString(CoPilotWeightMomentField.Text, font, brush, new PointF(650, 245), format);

                    g.DrawString(CargoWeightField.Text, font, brush, new PointF(365, 268), format);
                    g.DrawString(CargoWeightMomentField.Text, font, brush, new PointF(650, 268), format);

                    g.DrawString(FuelWeightField.Text, font, brush, new PointF(365, 293), format);
                    g.DrawString(FuelWeightMomentField.Text, font, brush, new PointF(650, 293), format);

                    g.DrawString(TotalTakeOFFField.Text, font, brush, new PointF(365, 360), format);
                    g.DrawString(TotalTakeOFFtMomentField.Text, font, brush, new PointF(650, 360), format);

                    g.DrawString(FuelBurnedField.Text, font, brush, new PointF(365, 420), format);
                    g.DrawString(FuelBurnMomentField.Text, font, brush, new PointF(650, 420), format);

                    g.DrawString(TotalLandingField.Text, font, brush, new PointF(365, 460), format);
                    g.DrawString(TotalLandingtMomentField.Text, font, brush, new PointF(650, 460), format);
                    break;
                case 1:

                    Pen pen = new Pen(Color.Blue, width: 2);
                    int EachValue = 25;
                    float HEach = 27F;

                    float Hposition = (float.Parse(TotalTakeOFFtMomentField.Text) - 650) / EachValue;
                    float vposition = ((float.Parse(TotalTakeOFFField.Text) - 400) / EachValue);

                    float x = 105 + (HEach * Hposition);
                    float y = 380 - (29.4F * vposition);

                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawLine(pen, x, 85, x, 380);
                    g.DrawLine(pen, 85, y, 622, y);
                    g.FillEllipse(Brushes.Blue, x - 5, y - 5, 10, 10);

                    pen = new Pen(Color.Orange, width: 2);
                    Hposition = (float.Parse(TotalLandingtMomentField.Text) - 650) / EachValue;
                    vposition = ((float.Parse(TotalLandingField.Text) - 400) / EachValue);
                    x = 105 + (HEach * Hposition);
                    y = 380 - (29.4F * vposition);
                    g.DrawLine(pen, x, 85, x, 380);
                    g.DrawLine(pen, 85, y, 622, y);
                    g.FillEllipse(Brushes.Orange, x - 5, y - 5, 10, 10);

                    g.FillEllipse(Brushes.Blue, 100, 50, 10, 10);
                    g.FillEllipse(Brushes.Orange, 100, 70, 10, 10);

                    g.DrawString("Take off condition", font, Brushes.Blue, 110, 45);
                    g.DrawString("Landind condition", font, Brushes.Orange, 110, 65);

                    break;
                case 2:

                    pen = new Pen(Color.Blue, width: 2);
                    EachValue = 24;

                    Hposition = ((float.Parse(TotalTakeOFFtMomentField.Text) / float.Parse(TotalTakeOFFField.Text) * 100) - 165);
                    vposition = ((float.Parse(TotalTakeOFFField.Text) - 300)) / 27F;

                    x = 236 + (27.46F * Hposition);
                    y = 385 - (24F * vposition);// - (24 * vposition);
                    g.DrawLine(pen, x, 85, x, 385); // vertical
                    g.DrawLine(pen, 236, y, 652, y); //horizontal
                    g.FillEllipse(Brushes.Blue, x - 5, y - 5, 10, 10);
                    pen = new Pen(Color.Orange, width: 2);
                    Hposition = ((float.Parse(TotalLandingtMomentField.Text) / float.Parse(TotalLandingField.Text) * 100) - 165);
                    vposition = ((float.Parse(TotalLandingField.Text) - 300)) / 27F;

                    x = 236 + (27.46F * Hposition);
                    y = 385 - (24F * vposition);// - (24 * vposition);
                    g.DrawLine(pen, x, 85, x, 385); // vertical
                    g.DrawLine(pen, 236, y, 652, y); //horizontal
                    g.FillEllipse(Brushes.Orange, x - 5, y - 5, 10, 10);


                    g.FillEllipse(Brushes.Blue, 120, 400, 10, 10);
                    g.FillEllipse(Brushes.Orange, 120, 420, 10, 10);
                    g.DrawString("Take off condition", font, Brushes.Blue, 130, 400);
                    g.DrawString("Landind condition", font, Brushes.Orange, 130, 420);
                    break;
                default:
                    break;
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CurrentImageBeingShown--;
            if (CurrentImageBeingShown < 0)
                CurrentImageBeingShown = 0;

            ResourceManager rm = Resources.ResourceManager;
            Bitmap myImage = (Bitmap)rm.GetObject("image" + CurrentImageBeingShown.ToString());
            if (CurrentImageBeingShown == 1)
                myImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = myImage;
            pictureBox1.Invalidate();
            label2.Text = (CurrentImageBeingShown + 1) + "/" + 3;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CurrentImageBeingShown++;
            if (CurrentImageBeingShown > 2)
                CurrentImageBeingShown = 2;
            ResourceManager rm = Resources.ResourceManager;
            Bitmap myImage = (Bitmap)rm.GetObject("image" + CurrentImageBeingShown.ToString());
            if (CurrentImageBeingShown == 1)
                myImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = myImage;
            pictureBox1.Invalidate();
            label2.Text = (CurrentImageBeingShown + 1) + "/" + 3;
        }
    }
}