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
            lblExceptionPeople = new Label();
            SuspendLayout();
            // 
            // chkHealthyMenu
            // 
            chkHealthyMenu.AutoSize = true;
            chkHealthyMenu.Location = new Point(304, 382);
            chkHealthyMenu.Margin = new Padding(4, 5, 4, 5);
            chkHealthyMenu.Name = "chkHealthyMenu";
            chkHealthyMenu.Size = new Size(163, 29);
            chkHealthyMenu.TabIndex = 27;
            chkHealthyMenu.Text = "Menu saludable";
            chkHealthyMenu.UseVisualStyleBackColor = true;
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateTotal.Location = new Point(204, 463);
            btnCalculateTotal.Margin = new Padding(4, 5, 4, 5);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new Size(220, 75);
            btnCalculateTotal.TabIndex = 26;
            btnCalculateTotal.Text = "CALCULAR COSTO";
            btnCalculateTotal.UseVisualStyleBackColor = true;
            btnCalculateTotal.Click += btnCalculateTotal_Click;
            // 
            // txtCostFoodPerson
            // 
            txtCostFoodPerson.Location = new Point(347, 164);
            txtCostFoodPerson.Margin = new Padding(4, 5, 4, 5);
            txtCostFoodPerson.Name = "txtCostFoodPerson";
            txtCostFoodPerson.Size = new Size(141, 31);
            txtCostFoodPerson.TabIndex = 25;
            // 
            // lblCostFoodPerson
            // 
            lblCostFoodPerson.AutoSize = true;
            lblCostFoodPerson.Font = new Font("Microsoft Sans Serif", 9.749999F);
            lblCostFoodPerson.Location = new Point(80, 166);
            lblCostFoodPerson.Margin = new Padding(4, 0, 4, 0);
            lblCostFoodPerson.Name = "lblCostFoodPerson";
            lblCostFoodPerson.Size = new Size(173, 25);
            lblCostFoodPerson.TabIndex = 24;
            lblCostFoodPerson.Text = "Costo por persona";
            // 
            // txtCakeText
            // 
            txtCakeText.Location = new Point(347, 304);
            txtCakeText.Margin = new Padding(4, 5, 4, 5);
            txtCakeText.Name = "txtCakeText";
            txtCakeText.Size = new Size(141, 31);
            txtCakeText.TabIndex = 23;
            // 
            // lblCakeText
            // 
            lblCakeText.AutoSize = true;
            lblCakeText.Font = new Font("Microsoft Sans Serif", 9.749999F);
            lblCakeText.Location = new Point(80, 306);
            lblCakeText.Margin = new Padding(4, 0, 4, 0);
            lblCakeText.Name = "lblCakeText";
            lblCakeText.Size = new Size(150, 25);
            lblCakeText.TabIndex = 22;
            lblCakeText.Text = "Texto del pastel";
            // 
            // cmbCakeSize
            // 
            cmbCakeSize.FormattingEnabled = true;
            cmbCakeSize.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbCakeSize.Location = new Point(347, 236);
            cmbCakeSize.Margin = new Padding(4, 5, 4, 5);
            cmbCakeSize.Name = "cmbCakeSize";
            cmbCakeSize.Size = new Size(141, 33);
            cmbCakeSize.TabIndex = 21;
            // 
            // lblCakeSize
            // 
            lblCakeSize.AutoSize = true;
            lblCakeSize.Font = new Font("Microsoft Sans Serif", 9.749999F);
            lblCakeSize.Location = new Point(80, 237);
            lblCakeSize.Margin = new Padding(4, 0, 4, 0);
            lblCakeSize.Name = "lblCakeSize";
            lblCakeSize.Size = new Size(173, 25);
            lblCakeSize.TabIndex = 20;
            lblCakeSize.Text = "Tamaño del pastel";
            // 
            // chkDecoration
            // 
            chkDecoration.AutoSize = true;
            chkDecoration.Location = new Point(110, 382);
            chkDecoration.Margin = new Padding(4, 5, 4, 5);
            chkDecoration.Name = "chkDecoration";
            chkDecoration.Size = new Size(127, 29);
            chkDecoration.TabIndex = 19;
            chkDecoration.Text = "Decoración";
            chkDecoration.UseVisualStyleBackColor = true;
            // 
            // txtNumPeople
            // 
            txtNumPeople.Location = new Point(347, 57);
            txtNumPeople.Margin = new Padding(4, 5, 4, 5);
            txtNumPeople.Name = "txtNumPeople";
            txtNumPeople.Size = new Size(141, 31);
            txtNumPeople.TabIndex = 18;
            txtNumPeople.TextChanged += txtNumPeople_TextChanged;
            // 
            // lblNumPeople
            // 
            lblNumPeople.AutoSize = true;
            lblNumPeople.Font = new Font("Microsoft Sans Serif", 9.749999F);
            lblNumPeople.Location = new Point(80, 59);
            lblNumPeople.Margin = new Padding(4, 0, 4, 0);
            lblNumPeople.Name = "lblNumPeople";
            lblNumPeople.Size = new Size(194, 25);
            lblNumPeople.TabIndex = 17;
            lblNumPeople.Text = "Número de personas";
            // 
            // lblExceptionPeople
            // 
            lblExceptionPeople.AutoSize = true;
            lblExceptionPeople.Location = new Point(347, 109);
            lblExceptionPeople.Name = "lblExceptionPeople";
            lblExceptionPeople.Size = new Size(0, 25);
            lblExceptionPeople.TabIndex = 28;
            // 
            // BirthdayDinnerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 593);
            Controls.Add(lblExceptionPeople);
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
            Margin = new Padding(4, 5, 4, 5);
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
        private Label lblExceptionPeople;
    }
}