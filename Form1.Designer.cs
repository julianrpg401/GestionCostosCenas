namespace GestionCostosCenas
{
    partial class Form1
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
            cmbTypeDinner = new ComboBox();
            lblTypeDinner = new Label();
            lblNumPeople = new Label();
            txtNumPeople = new TextBox();
            chkDecoration = new CheckBox();
            lblCakeSize = new Label();
            cmbCakeSize = new ComboBox();
            lblCakeText = new Label();
            txtCakeText = new TextBox();
            txtCostFoodPerson = new TextBox();
            lblCostFoodPerson = new Label();
            btnCalculateTotal = new Button();
            chkHealthyMenu = new CheckBox();
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
            // cmbTypeDinner
            // 
            cmbTypeDinner.FormattingEnabled = true;
            cmbTypeDinner.Location = new Point(281, 131);
            cmbTypeDinner.Name = "cmbTypeDinner";
            cmbTypeDinner.Size = new Size(100, 23);
            cmbTypeDinner.TabIndex = 1;
            // 
            // lblTypeDinner
            // 
            lblTypeDinner.AutoSize = true;
            lblTypeDinner.Font = new Font("Montserrat", 9.749999F);
            lblTypeDinner.Location = new Point(94, 136);
            lblTypeDinner.Name = "lblTypeDinner";
            lblTypeDinner.Size = new Size(90, 18);
            lblTypeDinner.TabIndex = 2;
            lblTypeDinner.Text = "Tipo de cena";
            // 
            // lblNumPeople
            // 
            lblNumPeople.AutoSize = true;
            lblNumPeople.Font = new Font("Montserrat", 9.749999F);
            lblNumPeople.Location = new Point(94, 178);
            lblNumPeople.Name = "lblNumPeople";
            lblNumPeople.Size = new Size(145, 18);
            lblNumPeople.TabIndex = 3;
            lblNumPeople.Text = "Número de personas";
            // 
            // txtNumPeople
            // 
            txtNumPeople.Location = new Point(281, 177);
            txtNumPeople.Name = "txtNumPeople";
            txtNumPeople.Size = new Size(100, 23);
            txtNumPeople.TabIndex = 4;
            // 
            // chkDecoration
            // 
            chkDecoration.AutoSize = true;
            chkDecoration.Location = new Point(115, 353);
            chkDecoration.Name = "chkDecoration";
            chkDecoration.Size = new Size(86, 19);
            chkDecoration.TabIndex = 8;
            chkDecoration.Text = "Decoración";
            chkDecoration.UseVisualStyleBackColor = true;
            // 
            // lblCakeSize
            // 
            lblCakeSize.AutoSize = true;
            lblCakeSize.Font = new Font("Montserrat", 9.749999F);
            lblCakeSize.Location = new Point(94, 266);
            lblCakeSize.Name = "lblCakeSize";
            lblCakeSize.Size = new Size(127, 18);
            lblCakeSize.TabIndex = 9;
            lblCakeSize.Text = "Tamaño del pastel";
            // 
            // cmbCakeSize
            // 
            cmbCakeSize.FormattingEnabled = true;
            cmbCakeSize.Location = new Point(281, 265);
            cmbCakeSize.Name = "cmbCakeSize";
            cmbCakeSize.Size = new Size(100, 23);
            cmbCakeSize.TabIndex = 10;
            // 
            // lblCakeText
            // 
            lblCakeText.AutoSize = true;
            lblCakeText.Font = new Font("Montserrat", 9.749999F);
            lblCakeText.Location = new Point(94, 307);
            lblCakeText.Name = "lblCakeText";
            lblCakeText.Size = new Size(107, 18);
            lblCakeText.TabIndex = 11;
            lblCakeText.Text = "Texto del pastel";
            // 
            // txtCakeText
            // 
            txtCakeText.Location = new Point(281, 306);
            txtCakeText.Name = "txtCakeText";
            txtCakeText.Size = new Size(100, 23);
            txtCakeText.TabIndex = 12;
            // 
            // txtCostFoodPerson
            // 
            txtCostFoodPerson.Location = new Point(281, 222);
            txtCostFoodPerson.Name = "txtCostFoodPerson";
            txtCostFoodPerson.Size = new Size(100, 23);
            txtCostFoodPerson.TabIndex = 14;
            // 
            // lblCostFoodPerson
            // 
            lblCostFoodPerson.AutoSize = true;
            lblCostFoodPerson.Font = new Font("Montserrat", 9.749999F);
            lblCostFoodPerson.Location = new Point(94, 223);
            lblCostFoodPerson.Name = "lblCostFoodPerson";
            lblCostFoodPerson.Size = new Size(125, 18);
            lblCostFoodPerson.TabIndex = 13;
            lblCostFoodPerson.Text = "Costo por persona";
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.Font = new Font("Montserrat SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateTotal.Location = new Point(152, 409);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new Size(154, 45);
            btnCalculateTotal.TabIndex = 15;
            btnCalculateTotal.Text = "CALCULAR COSTO";
            btnCalculateTotal.UseVisualStyleBackColor = true;
            // 
            // chkHealthyMenu
            // 
            chkHealthyMenu.AutoSize = true;
            chkHealthyMenu.Location = new Point(251, 353);
            chkHealthyMenu.Name = "chkHealthyMenu";
            chkHealthyMenu.Size = new Size(110, 19);
            chkHealthyMenu.TabIndex = 16;
            chkHealthyMenu.Text = "Menu saludable";
            chkHealthyMenu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
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
            Controls.Add(lblTypeDinner);
            Controls.Add(cmbTypeDinner);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ComboBox cmbTypeDinner;
        private Label lblTypeDinner;
        private Label lblNumPeople;
        private TextBox txtNumPeople;
        private CheckBox chkDecoration;
        private TextBox textBox1;
        private Label lblCakeSize;
        private ComboBox cmbCakeSize;
        private Label lblCakeText;
        private TextBox txtCakeText;
        private TextBox txtCostFoodPerson;
        private Label lblCostFoodPerson;
        private Button btnCalculateTotal;
        private CheckBox chkHealthyMenu;
    }
}
