namespace GestionCostosCenas
{
    partial class GalaDinnerForm
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
            lblExceptionCostFoodPerson = new Label();
            lblExceptionPeople = new Label();
            btnCalculateTotal = new Button();
            txtCostFoodPerson = new TextBox();
            lblCostFoodPerson = new Label();
            chkDecoration = new CheckBox();
            txtNumPeople = new TextBox();
            lblNumPeople = new Label();
            chkHealthyOption = new CheckBox();
            SuspendLayout();
            // 
            // lblExceptionCostFoodPerson
            // 
            lblExceptionCostFoodPerson.AutoSize = true;
            lblExceptionCostFoodPerson.Location = new Point(274, 114);
            lblExceptionCostFoodPerson.Margin = new Padding(2, 0, 2, 0);
            lblExceptionCostFoodPerson.Name = "lblExceptionCostFoodPerson";
            lblExceptionCostFoodPerson.Size = new Size(0, 15);
            lblExceptionCostFoodPerson.TabIndex = 43;
            // 
            // lblExceptionPeople
            // 
            lblExceptionPeople.AutoSize = true;
            lblExceptionPeople.Location = new Point(274, 69);
            lblExceptionPeople.Margin = new Padding(2, 0, 2, 0);
            lblExceptionPeople.Name = "lblExceptionPeople";
            lblExceptionPeople.Size = new Size(0, 15);
            lblExceptionPeople.TabIndex = 41;
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateTotal.Location = new Point(169, 257);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new Size(154, 45);
            btnCalculateTotal.TabIndex = 40;
            btnCalculateTotal.Text = "CALCULAR COSTO";
            btnCalculateTotal.UseVisualStyleBackColor = true;
            btnCalculateTotal.Click += btnCalculateTotal_Click;
            // 
            // txtCostFoodPerson
            // 
            txtCostFoodPerson.Location = new Point(274, 93);
            txtCostFoodPerson.Name = "txtCostFoodPerson";
            txtCostFoodPerson.Size = new Size(100, 23);
            txtCostFoodPerson.TabIndex = 39;
            txtCostFoodPerson.TextChanged += txtCostFoodPerson_TextChanged;
            // 
            // lblCostFoodPerson
            // 
            lblCostFoodPerson.AutoSize = true;
            lblCostFoodPerson.Font = new Font("Microsoft Sans Serif", 9.749999F);
            lblCostFoodPerson.Location = new Point(87, 94);
            lblCostFoodPerson.Name = "lblCostFoodPerson";
            lblCostFoodPerson.Size = new Size(118, 16);
            lblCostFoodPerson.TabIndex = 38;
            lblCostFoodPerson.Text = "Costo por persona";
            // 
            // chkDecoration
            // 
            chkDecoration.AutoSize = true;
            chkDecoration.Location = new Point(125, 185);
            chkDecoration.Name = "chkDecoration";
            chkDecoration.Size = new Size(86, 19);
            chkDecoration.TabIndex = 33;
            chkDecoration.Text = "Decoración";
            chkDecoration.UseVisualStyleBackColor = true;
            chkDecoration.CheckedChanged += chkDecoration_CheckedChanged;
            // 
            // txtNumPeople
            // 
            txtNumPeople.Location = new Point(274, 47);
            txtNumPeople.Name = "txtNumPeople";
            txtNumPeople.Size = new Size(100, 23);
            txtNumPeople.TabIndex = 32;
            txtNumPeople.TextChanged += txtNumPeople_TextChanged;
            // 
            // lblNumPeople
            // 
            lblNumPeople.AutoSize = true;
            lblNumPeople.Font = new Font("Microsoft Sans Serif", 9.749999F);
            lblNumPeople.Location = new Point(87, 48);
            lblNumPeople.Name = "lblNumPeople";
            lblNumPeople.Size = new Size(134, 16);
            lblNumPeople.TabIndex = 31;
            lblNumPeople.Text = "Número de personas";
            // 
            // chkHealthyOption
            // 
            chkHealthyOption.AutoSize = true;
            chkHealthyOption.Location = new Point(265, 185);
            chkHealthyOption.Name = "chkHealthyOption";
            chkHealthyOption.Size = new Size(118, 19);
            chkHealthyOption.TabIndex = 44;
            chkHealthyOption.Text = "Opción saludable";
            chkHealthyOption.UseVisualStyleBackColor = true;
            chkHealthyOption.CheckedChanged += chkHealthyOption_CheckedChanged;
            // 
            // GalaDinnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 366);
            Controls.Add(chkHealthyOption);
            Controls.Add(lblExceptionCostFoodPerson);
            Controls.Add(lblExceptionPeople);
            Controls.Add(btnCalculateTotal);
            Controls.Add(txtCostFoodPerson);
            Controls.Add(lblCostFoodPerson);
            Controls.Add(chkDecoration);
            Controls.Add(txtNumPeople);
            Controls.Add(lblNumPeople);
            Name = "GalaDinnerForm";
            Text = "CENA DE GALA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExceptionCostFoodPerson;
        private Label lblExceptionPeople;
        private Button btnCalculateTotal;
        private TextBox txtCostFoodPerson;
        private Label lblCostFoodPerson;
        private CheckBox chkDecoration;
        private TextBox txtNumPeople;
        private Label lblNumPeople;
        private CheckBox chkHealthyOption;
    }
}