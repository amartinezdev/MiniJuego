namespace VegaJuego
{
    partial class PantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            VegaMediaLogo = new PictureBox();
            ZeldaLogo = new PictureBox();
            CreadoPor = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)VegaMediaLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ZeldaLogo).BeginInit();
            SuspendLayout();
            // 
            // VegaMediaLogo
            // 
            VegaMediaLogo.BackColor = Color.Transparent;
            VegaMediaLogo.Image = Properties.Resources.LogoBueno;
            VegaMediaLogo.Location = new Point(0, -1);
            VegaMediaLogo.Name = "VegaMediaLogo";
            VegaMediaLogo.Size = new Size(210, 203);
            VegaMediaLogo.TabIndex = 0;
            VegaMediaLogo.TabStop = false;
            VegaMediaLogo.Click += pictureBox1_Click;
            // 
            // ZeldaLogo
            // 
            ZeldaLogo.BackColor = Color.Transparent;
            ZeldaLogo.BackgroundImageLayout = ImageLayout.Center;
            ZeldaLogo.Image = Properties.Resources.ZeldaLogo;
            ZeldaLogo.Location = new Point(527, 100);
            ZeldaLogo.Name = "ZeldaLogo";
            ZeldaLogo.Size = new Size(200, 86);
            ZeldaLogo.TabIndex = 1;
            ZeldaLogo.TabStop = false;
            // 
            // CreadoPor
            // 
            CreadoPor.AutoSize = true;
            CreadoPor.BackColor = Color.Transparent;
            CreadoPor.Font = new Font("CaskaydiaMono NF", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreadoPor.Location = new Point(410, 9);
            CreadoPor.Name = "CreadoPor";
            CreadoPor.Size = new Size(384, 22);
            CreadoPor.TabIndex = 2;
            CreadoPor.Text = "Creado por Álvaro Martínez Cuadros";
            CreadoPor.Click += label1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("CaskaydiaMono NF", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(527, 203);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(144, 22);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Sonido ON/OFF";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("CaskaydiaMono NF", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Image = Properties.Resources.Boton;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(234, 389);
            button1.Name = "button1";
            button1.Size = new Size(318, 46);
            button1.TabIndex = 4;
            button1.Text = "Comienza la aventura";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PantallaInicio
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.FondoPantalla;
            ClientSize = new Size(806, 467);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(CreadoPor);
            Controls.Add(ZeldaLogo);
            Controls.Add(VegaMediaLogo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PantallaInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaInicio";
            FormClosed += PantallaInicio_FormClosed;
            Load += PantallaInicio_Load;
            ((System.ComponentModel.ISupportInitialize)VegaMediaLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ZeldaLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox VegaMediaLogo;
        private PictureBox ZeldaLogo;
        private Label CreadoPor;
        private CheckBox checkBox1;
        private Button button1;
    }
}