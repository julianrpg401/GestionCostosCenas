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
            lblTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(142, 94);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(453, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sistema de gestión de cenas";
            // 
            // btnGalaDinner
            // 
            btnGalaDinner.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGalaDinner.Location = new Point(89, 247);
            btnGalaDinner.Margin = new Padding(4, 5, 4, 5);
            btnGalaDinner.Name = "btnGalaDinner";
            btnGalaDinner.Size = new Size(220, 75);
            btnGalaDinner.TabIndex = 17;
            btnGalaDinner.Text = "CENA DE GALA";
            btnGalaDinner.UseVisualStyleBackColor = true;
            btnGalaDinner.Click += btnGalaDinner_Click;
            // 
            // btnBirthdayDinner
            // 
            btnBirthdayDinner.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBirthdayDinner.Location = new Point(443, 247);
            btnBirthdayDinner.Margin = new Padding(4, 5, 4, 5);
            btnBirthdayDinner.Name = "btnBirthdayDinner";
            btnBirthdayDinner.Size = new Size(220, 75);
            btnBirthdayDinner.TabIndex = 18;
            btnBirthdayDinner.Text = "CENA DE CUMPLEAÑOS";
            btnBirthdayDinner.UseVisualStyleBackColor = true;
            btnBirthdayDinner.Click += btnBirthdayDinner_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 417);
            Controls.Add(btnBirthdayDinner);
            Controls.Add(btnGalaDinner);
            Controls.Add(lblTitle);
            Margin = new Padding(4, 5, 4, 5);
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
