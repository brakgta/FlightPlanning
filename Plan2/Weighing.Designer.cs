namespace Planner
{
    partial class Weighing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weighing));
            this.Plane = new System.Windows.Forms.Label();
            this.DownloadMetar = new System.Windows.Forms.Button();
            this.WeightandBalance = new System.Windows.Forms.Label();
            this.EmptyWeightLabel = new System.Windows.Forms.Label();
            this.EmptyWeightField = new System.Windows.Forms.RichTextBox();
            this.EmptyWeightMomentField = new System.Windows.Forms.RichTextBox();
            this.EmptyWeightMoment = new System.Windows.Forms.Label();
            this.PilotWeightMomentField = new System.Windows.Forms.RichTextBox();
            this.PilotWeightMoment = new System.Windows.Forms.Label();
            this.PilotWeightField = new System.Windows.Forms.RichTextBox();
            this.PilotWeightLabel = new System.Windows.Forms.Label();
            this.CoPilotWeightMomentField = new System.Windows.Forms.RichTextBox();
            this.CoPilotWeightMoment = new System.Windows.Forms.Label();
            this.CoPilotWeightField = new System.Windows.Forms.RichTextBox();
            this.CoPilotWeightLabel = new System.Windows.Forms.Label();
            this.CargoWeightMomentField = new System.Windows.Forms.RichTextBox();
            this.CargoWeightMoment = new System.Windows.Forms.Label();
            this.CargoWeightField = new System.Windows.Forms.RichTextBox();
            this.CargoWeightLabel = new System.Windows.Forms.Label();
            this.FuelWeightMomentField = new System.Windows.Forms.RichTextBox();
            this.FuelWeightMoment = new System.Windows.Forms.Label();
            this.FuelWeightField = new System.Windows.Forms.RichTextBox();
            this.FuelWeightLabel = new System.Windows.Forms.Label();
            this.TotalTakeOFFtMomentField = new System.Windows.Forms.RichTextBox();
            this.TotalTakeOFFMoment = new System.Windows.Forms.Label();
            this.TotalTakeOFFField = new System.Windows.Forms.RichTextBox();
            this.TotalTakeOFFWeightLabel = new System.Windows.Forms.Label();
            this.TotalLandingtMomentField = new System.Windows.Forms.RichTextBox();
            this.TotalLandingMoment = new System.Windows.Forms.Label();
            this.TotalLandingField = new System.Windows.Forms.RichTextBox();
            this.TotalLandingWeightLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FuelBurnedField = new System.Windows.Forms.RichTextBox();
            this.FuelBurnedLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FuelBurnMomentField = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TakeoffCG = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LandingCG = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Plane
            // 
            this.Plane.AutoSize = true;
            this.Plane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plane.Location = new System.Drawing.Point(12, 9);
            this.Plane.Name = "Plane";
            this.Plane.Size = new System.Drawing.Size(47, 16);
            this.Plane.TabIndex = 0;
            this.Plane.Text = "Plane";
            // 
            // DownloadMetar
            // 
            this.DownloadMetar.Location = new System.Drawing.Point(597, 526);
            this.DownloadMetar.Name = "DownloadMetar";
            this.DownloadMetar.Size = new System.Drawing.Size(118, 23);
            this.DownloadMetar.TabIndex = 1;
            this.DownloadMetar.Text = "Download as PDF";
            this.DownloadMetar.UseVisualStyleBackColor = true;
            this.DownloadMetar.Click += new System.EventHandler(this.DownloadMetar_click);
            // 
            // WeightandBalance
            // 
            this.WeightandBalance.AutoSize = true;
            this.WeightandBalance.Location = new System.Drawing.Point(12, 55);
            this.WeightandBalance.Name = "WeightandBalance";
            this.WeightandBalance.Size = new System.Drawing.Size(104, 13);
            this.WeightandBalance.TabIndex = 2;
            this.WeightandBalance.Text = "Weight and Balance";
            // 
            // EmptyWeightLabel
            // 
            this.EmptyWeightLabel.AutoSize = true;
            this.EmptyWeightLabel.Location = new System.Drawing.Point(12, 80);
            this.EmptyWeightLabel.Name = "EmptyWeightLabel";
            this.EmptyWeightLabel.Size = new System.Drawing.Size(76, 13);
            this.EmptyWeightLabel.TabIndex = 3;
            this.EmptyWeightLabel.Text = "Empty Weight:";
            // 
            // EmptyWeightField
            // 
            this.EmptyWeightField.Location = new System.Drawing.Point(103, 77);
            this.EmptyWeightField.Name = "EmptyWeightField";
            this.EmptyWeightField.Size = new System.Drawing.Size(100, 22);
            this.EmptyWeightField.TabIndex = 4;
            this.EmptyWeightField.Text = "";
            this.EmptyWeightField.TextChanged += new System.EventHandler(this.EmptyWeightField_TextChanged);
            // 
            // EmptyWeightMomentField
            // 
            this.EmptyWeightMomentField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmptyWeightMomentField.Location = new System.Drawing.Point(358, 77);
            this.EmptyWeightMomentField.Name = "EmptyWeightMomentField";
            this.EmptyWeightMomentField.Size = new System.Drawing.Size(100, 22);
            this.EmptyWeightMomentField.TabIndex = 6;
            this.EmptyWeightMomentField.Text = "";
            this.EmptyWeightMomentField.TextChanged += new System.EventHandler(this.EmptyWeightMomentField_TextChanged);
            // 
            // EmptyWeightMoment
            // 
            this.EmptyWeightMoment.AutoSize = true;
            this.EmptyWeightMoment.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.EmptyWeightMoment.Location = new System.Drawing.Point(235, 80);
            this.EmptyWeightMoment.Name = "EmptyWeightMoment";
            this.EmptyWeightMoment.Size = new System.Drawing.Size(117, 13);
            this.EmptyWeightMoment.TabIndex = 5;
            this.EmptyWeightMoment.Text = "Empty Weight Moment:";
            // 
            // PilotWeightMomentField
            // 
            this.PilotWeightMomentField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PilotWeightMomentField.Location = new System.Drawing.Point(358, 105);
            this.PilotWeightMomentField.Name = "PilotWeightMomentField";
            this.PilotWeightMomentField.Size = new System.Drawing.Size(100, 22);
            this.PilotWeightMomentField.TabIndex = 10;
            this.PilotWeightMomentField.Text = "";
            this.PilotWeightMomentField.TextChanged += new System.EventHandler(this.PilotWeightMomentField_TextChanged);
            // 
            // PilotWeightMoment
            // 
            this.PilotWeightMoment.AutoSize = true;
            this.PilotWeightMoment.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.PilotWeightMoment.Location = new System.Drawing.Point(235, 108);
            this.PilotWeightMoment.Name = "PilotWeightMoment";
            this.PilotWeightMoment.Size = new System.Drawing.Size(108, 13);
            this.PilotWeightMoment.TabIndex = 9;
            this.PilotWeightMoment.Text = "Pilot Weight Moment:";
            // 
            // PilotWeightField
            // 
            this.PilotWeightField.Location = new System.Drawing.Point(103, 105);
            this.PilotWeightField.Name = "PilotWeightField";
            this.PilotWeightField.Size = new System.Drawing.Size(100, 22);
            this.PilotWeightField.TabIndex = 8;
            this.PilotWeightField.Text = "85";
            this.PilotWeightField.TextChanged += new System.EventHandler(this.PilotWeightField_TextChanged);
            // 
            // PilotWeightLabel
            // 
            this.PilotWeightLabel.AutoSize = true;
            this.PilotWeightLabel.Location = new System.Drawing.Point(12, 108);
            this.PilotWeightLabel.Name = "PilotWeightLabel";
            this.PilotWeightLabel.Size = new System.Drawing.Size(67, 13);
            this.PilotWeightLabel.TabIndex = 7;
            this.PilotWeightLabel.Text = "Pilot Weight:";
            // 
            // CoPilotWeightMomentField
            // 
            this.CoPilotWeightMomentField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CoPilotWeightMomentField.Location = new System.Drawing.Point(358, 133);
            this.CoPilotWeightMomentField.Name = "CoPilotWeightMomentField";
            this.CoPilotWeightMomentField.Size = new System.Drawing.Size(100, 19);
            this.CoPilotWeightMomentField.TabIndex = 14;
            this.CoPilotWeightMomentField.Text = "";
            this.CoPilotWeightMomentField.TextChanged += new System.EventHandler(this.CoPilotWeightMomentField_TextChanged);
            // 
            // CoPilotWeightMoment
            // 
            this.CoPilotWeightMoment.AutoSize = true;
            this.CoPilotWeightMoment.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.CoPilotWeightMoment.Location = new System.Drawing.Point(235, 136);
            this.CoPilotWeightMoment.Name = "CoPilotWeightMoment";
            this.CoPilotWeightMoment.Size = new System.Drawing.Size(121, 13);
            this.CoPilotWeightMoment.TabIndex = 13;
            this.CoPilotWeightMoment.Text = "CoPilot Weight Moment:";
            // 
            // CoPilotWeightField
            // 
            this.CoPilotWeightField.Location = new System.Drawing.Point(103, 133);
            this.CoPilotWeightField.Name = "CoPilotWeightField";
            this.CoPilotWeightField.Size = new System.Drawing.Size(100, 19);
            this.CoPilotWeightField.TabIndex = 12;
            this.CoPilotWeightField.Text = "85";
            this.CoPilotWeightField.TextChanged += new System.EventHandler(this.CoPilotWeightField_TextChanged);
            // 
            // CoPilotWeightLabel
            // 
            this.CoPilotWeightLabel.AutoSize = true;
            this.CoPilotWeightLabel.Location = new System.Drawing.Point(12, 136);
            this.CoPilotWeightLabel.Name = "CoPilotWeightLabel";
            this.CoPilotWeightLabel.Size = new System.Drawing.Size(80, 13);
            this.CoPilotWeightLabel.TabIndex = 11;
            this.CoPilotWeightLabel.Text = "CoPilot Weight:";
            // 
            // CargoWeightMomentField
            // 
            this.CargoWeightMomentField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CargoWeightMomentField.Location = new System.Drawing.Point(358, 158);
            this.CargoWeightMomentField.Name = "CargoWeightMomentField";
            this.CargoWeightMomentField.Size = new System.Drawing.Size(100, 22);
            this.CargoWeightMomentField.TabIndex = 18;
            this.CargoWeightMomentField.Text = "";
            this.CargoWeightMomentField.TextChanged += new System.EventHandler(this.CargoWeightMomentField_TextChanged);
            // 
            // CargoWeightMoment
            // 
            this.CargoWeightMoment.AutoSize = true;
            this.CargoWeightMoment.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.CargoWeightMoment.Location = new System.Drawing.Point(235, 161);
            this.CargoWeightMoment.Name = "CargoWeightMoment";
            this.CargoWeightMoment.Size = new System.Drawing.Size(116, 13);
            this.CargoWeightMoment.TabIndex = 17;
            this.CargoWeightMoment.Text = "Cargo Weight Moment:";
            // 
            // CargoWeightField
            // 
            this.CargoWeightField.Location = new System.Drawing.Point(103, 158);
            this.CargoWeightField.Name = "CargoWeightField";
            this.CargoWeightField.Size = new System.Drawing.Size(100, 22);
            this.CargoWeightField.TabIndex = 16;
            this.CargoWeightField.Text = "2";
            this.CargoWeightField.TextChanged += new System.EventHandler(this.CargoWeightField_TextChanged);
            // 
            // CargoWeightLabel
            // 
            this.CargoWeightLabel.AutoSize = true;
            this.CargoWeightLabel.Location = new System.Drawing.Point(12, 161);
            this.CargoWeightLabel.Name = "CargoWeightLabel";
            this.CargoWeightLabel.Size = new System.Drawing.Size(75, 13);
            this.CargoWeightLabel.TabIndex = 15;
            this.CargoWeightLabel.Text = "Cargo Weight:";
            // 
            // FuelWeightMomentField
            // 
            this.FuelWeightMomentField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FuelWeightMomentField.Location = new System.Drawing.Point(358, 186);
            this.FuelWeightMomentField.Name = "FuelWeightMomentField";
            this.FuelWeightMomentField.Size = new System.Drawing.Size(100, 22);
            this.FuelWeightMomentField.TabIndex = 22;
            this.FuelWeightMomentField.Text = "";
            this.FuelWeightMomentField.TextChanged += new System.EventHandler(this.FuelWeightMomentField_TextChanged);
            // 
            // FuelWeightMoment
            // 
            this.FuelWeightMoment.AutoSize = true;
            this.FuelWeightMoment.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FuelWeightMoment.Location = new System.Drawing.Point(235, 189);
            this.FuelWeightMoment.Name = "FuelWeightMoment";
            this.FuelWeightMoment.Size = new System.Drawing.Size(108, 13);
            this.FuelWeightMoment.TabIndex = 21;
            this.FuelWeightMoment.Text = "Fuel Weight Moment:";
            // 
            // FuelWeightField
            // 
            this.FuelWeightField.Location = new System.Drawing.Point(103, 186);
            this.FuelWeightField.Name = "FuelWeightField";
            this.FuelWeightField.Size = new System.Drawing.Size(100, 22);
            this.FuelWeightField.TabIndex = 20;
            this.FuelWeightField.Text = "32";
            this.FuelWeightField.TextChanged += new System.EventHandler(this.FuelWeightField_TextChanged);
            // 
            // FuelWeightLabel
            // 
            this.FuelWeightLabel.AutoSize = true;
            this.FuelWeightLabel.Location = new System.Drawing.Point(12, 189);
            this.FuelWeightLabel.Name = "FuelWeightLabel";
            this.FuelWeightLabel.Size = new System.Drawing.Size(67, 13);
            this.FuelWeightLabel.TabIndex = 19;
            this.FuelWeightLabel.Text = "Fuel Weight:";
            // 
            // TotalTakeOFFtMomentField
            // 
            this.TotalTakeOFFtMomentField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalTakeOFFtMomentField.Location = new System.Drawing.Point(356, 252);
            this.TotalTakeOFFtMomentField.Name = "TotalTakeOFFtMomentField";
            this.TotalTakeOFFtMomentField.Size = new System.Drawing.Size(100, 22);
            this.TotalTakeOFFtMomentField.TabIndex = 26;
            this.TotalTakeOFFtMomentField.Text = "";
            this.TotalTakeOFFtMomentField.TextChanged += new System.EventHandler(this.TotalTakeOFFtMomentField_TextChanged);
            // 
            // TotalTakeOFFMoment
            // 
            this.TotalTakeOFFMoment.AutoSize = true;
            this.TotalTakeOFFMoment.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TotalTakeOFFMoment.Location = new System.Drawing.Point(233, 255);
            this.TotalTakeOFFMoment.Name = "TotalTakeOFFMoment";
            this.TotalTakeOFFMoment.Size = new System.Drawing.Size(94, 13);
            this.TotalTakeOFFMoment.TabIndex = 25;
            this.TotalTakeOFFMoment.Text = "Take off Moment: ";
            // 
            // TotalTakeOFFField
            // 
            this.TotalTakeOFFField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalTakeOFFField.Location = new System.Drawing.Point(101, 252);
            this.TotalTakeOFFField.Name = "TotalTakeOFFField";
            this.TotalTakeOFFField.Size = new System.Drawing.Size(100, 22);
            this.TotalTakeOFFField.TabIndex = 24;
            this.TotalTakeOFFField.Text = "";
            this.TotalTakeOFFField.TextChanged += new System.EventHandler(this.TotalTakeOFFField_TextChanged);
            // 
            // TotalTakeOFFWeightLabel
            // 
            this.TotalTakeOFFWeightLabel.AutoSize = true;
            this.TotalTakeOFFWeightLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TotalTakeOFFWeightLabel.Location = new System.Drawing.Point(10, 255);
            this.TotalTakeOFFWeightLabel.Name = "TotalTakeOFFWeightLabel";
            this.TotalTakeOFFWeightLabel.Size = new System.Drawing.Size(87, 13);
            this.TotalTakeOFFWeightLabel.TabIndex = 23;
            this.TotalTakeOFFWeightLabel.Text = "Take off Weight:";
            // 
            // TotalLandingtMomentField
            // 
            this.TotalLandingtMomentField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalLandingtMomentField.Location = new System.Drawing.Point(356, 345);
            this.TotalLandingtMomentField.Name = "TotalLandingtMomentField";
            this.TotalLandingtMomentField.Size = new System.Drawing.Size(100, 22);
            this.TotalLandingtMomentField.TabIndex = 30;
            this.TotalLandingtMomentField.Text = "";
            // 
            // TotalLandingMoment
            // 
            this.TotalLandingMoment.AutoSize = true;
            this.TotalLandingMoment.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TotalLandingMoment.Location = new System.Drawing.Point(233, 348);
            this.TotalLandingMoment.Name = "TotalLandingMoment";
            this.TotalLandingMoment.Size = new System.Drawing.Size(89, 13);
            this.TotalLandingMoment.TabIndex = 29;
            this.TotalLandingMoment.Text = "Landing Moment:";
            // 
            // TotalLandingField
            // 
            this.TotalLandingField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalLandingField.Location = new System.Drawing.Point(101, 345);
            this.TotalLandingField.Name = "TotalLandingField";
            this.TotalLandingField.Size = new System.Drawing.Size(100, 22);
            this.TotalLandingField.TabIndex = 28;
            this.TotalLandingField.Text = "";
            this.TotalLandingField.TextChanged += new System.EventHandler(this.TotalLandingField_TextChanged);
            // 
            // TotalLandingWeightLabel
            // 
            this.TotalLandingWeightLabel.AutoSize = true;
            this.TotalLandingWeightLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TotalLandingWeightLabel.Location = new System.Drawing.Point(10, 348);
            this.TotalLandingWeightLabel.Name = "TotalLandingWeightLabel";
            this.TotalLandingWeightLabel.Size = new System.Drawing.Size(85, 13);
            this.TotalLandingWeightLabel.TabIndex = 27;
            this.TotalLandingWeightLabel.Text = "Landing Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Landing Condition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Take off Condition";
            // 
            // FuelBurnedField
            // 
            this.FuelBurnedField.Location = new System.Drawing.Point(101, 317);
            this.FuelBurnedField.Name = "FuelBurnedField";
            this.FuelBurnedField.Size = new System.Drawing.Size(100, 22);
            this.FuelBurnedField.TabIndex = 34;
            this.FuelBurnedField.Text = "10";
            this.FuelBurnedField.TextChanged += new System.EventHandler(this.FuelBurnedField_TextChanged);
            // 
            // FuelBurnedLabel
            // 
            this.FuelBurnedLabel.AutoSize = true;
            this.FuelBurnedLabel.Location = new System.Drawing.Point(10, 320);
            this.FuelBurnedLabel.Name = "FuelBurnedLabel";
            this.FuelBurnedLabel.Size = new System.Drawing.Size(66, 13);
            this.FuelBurnedLabel.TabIndex = 33;
            this.FuelBurnedLabel.Text = "Fuel burned:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(597, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(746, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // FuelBurnMomentField
            // 
            this.FuelBurnMomentField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FuelBurnMomentField.Location = new System.Drawing.Point(358, 314);
            this.FuelBurnMomentField.Name = "FuelBurnMomentField";
            this.FuelBurnMomentField.Size = new System.Drawing.Size(100, 22);
            this.FuelBurnMomentField.TabIndex = 37;
            this.FuelBurnMomentField.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(235, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Fuel burned Moment:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(881, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "<--";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(962, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "-->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1290, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "1/3";
            // 
            // TakeoffCG
            // 
            this.TakeoffCG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TakeoffCG.Location = new System.Drawing.Point(462, 252);
            this.TakeoffCG.Name = "TakeoffCG";
            this.TakeoffCG.ReadOnly = true;
            this.TakeoffCG.Size = new System.Drawing.Size(79, 22);
            this.TakeoffCG.TabIndex = 42;
            this.TakeoffCG.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "C.G Position";
            // 
            // LandingCG
            // 
            this.LandingCG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LandingCG.Location = new System.Drawing.Point(462, 345);
            this.LandingCG.Name = "LandingCG";
            this.LandingCG.ReadOnly = true;
            this.LandingCG.Size = new System.Drawing.Size(79, 22);
            this.LandingCG.TabIndex = 44;
            this.LandingCG.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(465, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "C.G Position";
            // 
            // Weighing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 572);
            this.Controls.Add(this.LandingCG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TakeoffCG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FuelBurnMomentField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FuelBurnedField);
            this.Controls.Add(this.FuelBurnedLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalLandingtMomentField);
            this.Controls.Add(this.TotalLandingMoment);
            this.Controls.Add(this.TotalLandingField);
            this.Controls.Add(this.TotalLandingWeightLabel);
            this.Controls.Add(this.TotalTakeOFFtMomentField);
            this.Controls.Add(this.TotalTakeOFFMoment);
            this.Controls.Add(this.TotalTakeOFFField);
            this.Controls.Add(this.TotalTakeOFFWeightLabel);
            this.Controls.Add(this.FuelWeightMomentField);
            this.Controls.Add(this.FuelWeightMoment);
            this.Controls.Add(this.FuelWeightField);
            this.Controls.Add(this.FuelWeightLabel);
            this.Controls.Add(this.CargoWeightMomentField);
            this.Controls.Add(this.CargoWeightMoment);
            this.Controls.Add(this.CargoWeightField);
            this.Controls.Add(this.CargoWeightLabel);
            this.Controls.Add(this.CoPilotWeightMomentField);
            this.Controls.Add(this.CoPilotWeightMoment);
            this.Controls.Add(this.CoPilotWeightField);
            this.Controls.Add(this.CoPilotWeightLabel);
            this.Controls.Add(this.PilotWeightMomentField);
            this.Controls.Add(this.PilotWeightMoment);
            this.Controls.Add(this.PilotWeightField);
            this.Controls.Add(this.PilotWeightLabel);
            this.Controls.Add(this.EmptyWeightMomentField);
            this.Controls.Add(this.EmptyWeightMoment);
            this.Controls.Add(this.EmptyWeightField);
            this.Controls.Add(this.EmptyWeightLabel);
            this.Controls.Add(this.WeightandBalance);
            this.Controls.Add(this.DownloadMetar);
            this.Controls.Add(this.Plane);
            this.Name = "Weighing";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Weather_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Plane;
        private System.Windows.Forms.Button DownloadMetar;
        private System.Windows.Forms.Label WeightandBalance;
        private System.Windows.Forms.Label EmptyWeightLabel;
        private System.Windows.Forms.RichTextBox EmptyWeightField;
        private System.Windows.Forms.RichTextBox EmptyWeightMomentField;
        private System.Windows.Forms.Label EmptyWeightMoment;
        private System.Windows.Forms.RichTextBox PilotWeightMomentField;
        private System.Windows.Forms.Label PilotWeightMoment;
        private System.Windows.Forms.RichTextBox PilotWeightField;
        private System.Windows.Forms.Label PilotWeightLabel;
        private System.Windows.Forms.RichTextBox CoPilotWeightMomentField;
        private System.Windows.Forms.Label CoPilotWeightMoment;
        private System.Windows.Forms.RichTextBox CoPilotWeightField;
        private System.Windows.Forms.Label CoPilotWeightLabel;
        private System.Windows.Forms.RichTextBox CargoWeightMomentField;
        private System.Windows.Forms.Label CargoWeightMoment;
        private System.Windows.Forms.RichTextBox CargoWeightField;
        private System.Windows.Forms.Label CargoWeightLabel;
        private System.Windows.Forms.RichTextBox FuelWeightMomentField;
        private System.Windows.Forms.Label FuelWeightMoment;
        private System.Windows.Forms.RichTextBox FuelWeightField;
        private System.Windows.Forms.Label FuelWeightLabel;
        private System.Windows.Forms.RichTextBox TotalTakeOFFtMomentField;
        private System.Windows.Forms.Label TotalTakeOFFMoment;
        private System.Windows.Forms.RichTextBox TotalTakeOFFField;
        private System.Windows.Forms.Label TotalTakeOFFWeightLabel;
        private System.Windows.Forms.RichTextBox TotalLandingtMomentField;
        private System.Windows.Forms.Label TotalLandingMoment;
        private System.Windows.Forms.RichTextBox TotalLandingField;
        private System.Windows.Forms.Label TotalLandingWeightLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox FuelBurnedField;
        private System.Windows.Forms.Label FuelBurnedLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox FuelBurnMomentField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TakeoffCG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox LandingCG;
        private System.Windows.Forms.Label label6;
    }
}