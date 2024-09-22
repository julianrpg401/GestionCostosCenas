namespace GestionCostosCenas
{
    partial class BirthdayDinnerForm
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
            chkHealthyMenu = new CheckBox();
            btnCalculateTotal = new Button();
            txtCostFoodPerson = new TextBox();
            lblCostFoodPerson = new Label();
            txtCakeText = new TextBox();
            lblCakeText = new Label();
            cmbCakeSize = new ComboBox();
            lblCakeSize = new Label();
            chkDecoration = new CheckBox();
            txtNumPeople = new TextBox();
            lblNumPeople = new Label();
            SuspendLayout();
            // 
            // chkHealthyMenu
            // 
            chkHealthyMenu.AutoSize = true;
            chkHealthyMenu.Location = new Point(402, 260);
            chkHealthyMenu.Name = "chkHealthyMenu";
            chkHealthyMenu.Size = new Size(110, 19);
            chkHealthyMenu.TabIndex = 27;
            chkHealthyMenu.Text = "Menu saludable";
            chkHealthyMenu.UseVisualStyleBackColor = true;
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.Font = new Font("Montserrat SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateTotal.Location = new Point(303, 316);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new Size(154, 45);
            btnCalculateTotal.TabIndex = 26;
            btnCalculateTotal.Text = "CALCULAR COSTO";
            btnCalculateTotal.UseVisualStyleBackColor = true;
            // 
            // txtCostFoodPerson
            // 
            txtCostFoodPerson.Location = new Point(432, 129);
            txtCostFoodPerson.Name = "txtCostFoodPerson";
            txtCostFoodPerson.Size = new Size(100, 23);
            txtCostFoodPerson.TabIndex = 25;
            // 
            // lblCostFoodPerson
            // 
            lblCostFoodPerson.AutoSize = true;
            lblCostFoodPerson.Font = new Font("Montserrat", 9.749999F);
            lblCostFoodPerson.Location = new Point(245, 130);
            lblCostFoodPerson.Name = "lblCostFoodPerson";
            lblCostFoodPerson.Size = new Size(125, 18);
            lblCostFoodPerson.TabIndex = 24;
            lblCostFoodPerson.Text = "Costo por persona";
            // 
            // txtCakeText
            // 
            txtCakeText.Location = new Point(432, 213);
            txtCakeText.Name = "txtCakeText";
            txtCakeText.Size = new Size(100, 23);
            txtCakeText.TabIndex = 23;
            // 
            // lblCakeText
            // 
            lblCakeText.AutoSize = true;
            lblCakeText.Font = new Font("Montserrat", 9.749999F);
            lblCakeText.Location = new Point(245, 214);
            lblCakeText.Name = "lblCakeText";
            lblCakeText.Size = new Size(107, 18);
            lblCakeText.TabIndex = 22;
            lblCakeText.Text = "Texto del pastel";
            // 
            // cmbCakeSize
            // 
            cmbCakeSize.FormattingEnabled = true;
            cmbCakeSize.Location = new Point(432, 172);
            cmbCakeSize.Name = "cmbCakeSize";
            cmbCakeSize.Size = new Size(100, 23);
            cmbCakeSize.TabIndex = 21;
            // 
            // lblCakeSize
            // 
            lblCakeSize.AutoSize = true;
            lblCakeSize.Font = new Font("Montserrat", 9.749999F);
            lblCakeSize.Location = new Point(245, 173);
            lblCakeSize.Name = "lblCakeSize";
            lblCakeSize.Size = new Size(127, 18);
            lblCakeSize.TabIndex = 20;
            lblCakeSize.Text = "Tamaño del pastel";
            // 
            // chkDecoration
            // 
            chkDecoration.AutoSize = true;
            chkDecoration.Location = new Point(266, 260);
            chkDecoration.Name = "chkDecoration";
            chkDecoration.Size = new Size(86, 19);
            chkDecoration.TabIndex = 19;
            chkDecoration.Text = "Decoración";
            chkDecoration.UseVisualStyleBackColor = true;
            // 
            // txtNumPeople
            // 
            txtNumPeople.Location = new Point(432, 84);
            txtNumPeople.Name = "txtNumPeople";
            txtNumPeople.Size = new Size(100, 23);
            txtNumPeople.TabIndex = 18;
            // 
            // lblNumPeople
            // 
            lblNumPeople.AutoSize = true;
            lblNumPeople.Font = new Font("Montserrat", 9.749999F);
            lblNumPeople.Location = new Point(245, 85);
            lblNumPeople.Name = "lblNumPeople";
            lblNumPeople.Size = new Size(145, 18);
            lblNumPeople.TabIndex = 17;
            lblNumPeople.Text = "Número de personas";
            // 
            // BirthdayDinnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkHealthyMenu);
            Controls.Add(btnCalculateTotal);
            Controls.Add(txtCostFoodPerson);
            Controls.Add(lblCostFoodPerson);
            Controls.Add(txtCakeText);
            Controls.Add(lblCakeText);
            Controls.Add(cmbCakeSize);
            Controls.Add(lblCakeSize);
            Controls.Add(chkDecoration);
            Controls.Add(txtNumPeople);
            Controls.Add(lblNumPeople);
            Name = "BirthdayDinnerForm";
            Text = "CENA DE CUMPLEAÑOS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkHealthyMenu;
        private Button btnCalculateTotal;
        private TextBox txtCostFoodPerson;
        private Label lblCostFoodPerson;
        private TextBox txtCakeText;
        private Label lblCakeText;
        private ComboBox cmbCakeSize;
        private Label lblCakeSize;
        private CheckBox chkDecoration;
        private TextBox txtNumPeople;
        private Label lblNumPeople;
    }
}