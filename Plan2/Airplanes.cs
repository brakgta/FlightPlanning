using Plan2;
using System;
using System.Windows.Forms;

namespace Planner
{
    public partial class Airplanes : Form
    {
        public Airplanes()
        {
            InitializeComponent();
        }

        private Weighing Weather;

        private void PlaneChoice()
        {
            if (PAPA.Checked)
            {
                if (Weather != null && !Weather.IsDisposed)
                    Weather.Close();
                else
                {
                    Weather = new Weighing();


                    Weather.EmptyWeight = 404;
                    Weather.EmptyWeightMomentum = 685.99;
                    Weather.PlaneName = "P2002 JF - PAPA";
                    Weather.PlaneCode = "PAPA";
                    Weather.Show();
                }
            }
        }


        private void CheckBox2_CheckedChanged(object sender, System.EventArgs e)
        {
            PlaneChoice();
        }

        private void CheckBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            PlaneChoice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            WeatherBriefing weather = new WeatherBriefing();
            weather.ShowDialog();
        }
    }
}
