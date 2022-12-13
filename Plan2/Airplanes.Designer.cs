namespace Planner
{
    partial class Airplanes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Airplanes));
            this.ECHO = new System.Windows.Forms.CheckBox();
            this.PAPA = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ECHO
            // 
            this.ECHO.Appearance = System.Windows.Forms.Appearance.Button;
            this.ECHO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ECHO.Image = ((System.Drawing.Image)(resources.GetObject("ECHO.Image")));
            this.ECHO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ECHO.Location = new System.Drawing.Point(12, 12);
            this.ECHO.Name = "ECHO";
            this.ECHO.Size = new System.Drawing.Size(347, 200);
            this.ECHO.TabIndex = 0;
            this.ECHO.Text = "ECHO";
            this.ECHO.UseVisualStyleBackColor = true;
            this.ECHO.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // PAPA
            // 
            this.PAPA.Appearance = System.Windows.Forms.Appearance.Button;
            this.PAPA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PAPA.Image = ((System.Drawing.Image)(resources.GetObject("PAPA.Image")));
            this.PAPA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PAPA.Location = new System.Drawing.Point(12, 218);
            this.PAPA.Name = "PAPA";
            this.PAPA.Size = new System.Drawing.Size(347, 200);
            this.PAPA.TabIndex = 1;
            this.PAPA.Text = "PAPA";
            this.PAPA.UseVisualStyleBackColor = true;
            this.PAPA.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Weather briefing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Airplanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PAPA);
            this.Controls.Add(this.ECHO);
            this.Name = "Airplanes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ECHO;
        private System.Windows.Forms.CheckBox PAPA;
        private System.Windows.Forms.Button button1;
    }
}

