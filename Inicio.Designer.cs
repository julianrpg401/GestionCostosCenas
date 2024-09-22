namespace GestionCostosCenas
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnGalaDinner = new Button();
            btnBirthdayDinner = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(242, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(327, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sistema de gestión de cenas";
            // 
            // btnGalaDinner
            // 
            btnGalaDinner.Font = new Font("Montserrat SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGalaDinner.Location = new Point(497, 200);
            btnGalaDinner.Name = "btnGalaDinner";
            btnGalaDinner.Size = new Size(154, 45);
            btnGalaDinner.TabIndex = 17;
            btnGalaDinner.Text = "CENA DE GALA";
            btnGalaDinner.UseVisualStyleBackColor = true;
            btnGalaDinner.Click += btnGalaDinner_Click;
            // 
            // btnBirthdayDinner
            // 
            btnBirthdayDinner.Font = new Font("Montserrat SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBirthdayDinner.Location = new Point(484, 327);
            btnBirthdayDinner.Name = "btnBirthdayDinner";
            btnBirthdayDinner.Size = new Size(154, 45);
            btnBirthdayDinner.TabIndex = 18;
            btnBirthdayDinner.Text = "CENA DE CUMPLEAÑOS";
            btnBirthdayDinner.UseVisualStyleBackColor = true;
            btnBirthdayDinner.Click += btnBirthdayDinner_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(btnBirthdayDinner);
            Controls.Add(btnGalaDinner);
            Controls.Add(lblTitle);
            Name = "Inicio";
            Text = "INICIO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox textBox1;
        private Button btnGalaDinner;
        private Button btnBirthdayDinner;
    }
}
