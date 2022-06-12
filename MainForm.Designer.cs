namespace Jakub_Wawrzeniuk_DPS_Software_recruitment
{
    partial class orderManagementSystemForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.changeProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.orderedProductsLabel = new System.Windows.Forms.Label();
            this.displayProductsTextBox = new System.Windows.Forms.TextBox();
            this.saveToDatabaseButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(12, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 19);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Imię";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateOfBirthLabel.Location = new System.Drawing.Point(12, 72);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(102, 19);
            this.dateOfBirthLabel.TabIndex = 1;
            this.dateOfBirthLabel.Text = "Data urodzenia";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameLabel.Location = new System.Drawing.Point(12, 42);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(66, 19);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Nazwisko";
            // 
            // dateOfBirthTextBox
            // 
            this.dateOfBirthTextBox.Location = new System.Drawing.Point(148, 70);
            this.dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            this.dateOfBirthTextBox.Size = new System.Drawing.Size(317, 25);
            this.dateOfBirthTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(148, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(317, 25);
            this.nameTextBox.TabIndex = 7;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(148, 38);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(317, 25);
            this.surnameTextBox.TabIndex = 8;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(12, 120);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(132, 38);
            this.addProductButton.TabIndex = 9;
            this.addProductButton.Text = "Dodaj produkt";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // changeProductButton
            // 
            this.changeProductButton.Location = new System.Drawing.Point(372, 120);
            this.changeProductButton.Name = "changeProductButton";
            this.changeProductButton.Size = new System.Drawing.Size(132, 38);
            this.changeProductButton.TabIndex = 10;
            this.changeProductButton.Text = "Zmień produkt";
            this.changeProductButton.UseVisualStyleBackColor = true;
            this.changeProductButton.Click += new System.EventHandler(this.changeProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(192, 120);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(132, 38);
            this.deleteProductButton.TabIndex = 11;
            this.deleteProductButton.Text = "Usuń produkt";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // orderedProductsLabel
            // 
            this.orderedProductsLabel.AutoSize = true;
            this.orderedProductsLabel.Location = new System.Drawing.Point(12, 170);
            this.orderedProductsLabel.Name = "orderedProductsLabel";
            this.orderedProductsLabel.Size = new System.Drawing.Size(143, 19);
            this.orderedProductsLabel.TabIndex = 13;
            this.orderedProductsLabel.Text = "Zamówione produkty:";
            // 
            // displayProductsTextBox
            // 
            this.displayProductsTextBox.Location = new System.Drawing.Point(15, 192);
            this.displayProductsTextBox.Multiline = true;
            this.displayProductsTextBox.Name = "displayProductsTextBox";
            this.displayProductsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.displayProductsTextBox.Size = new System.Drawing.Size(774, 255);
            this.displayProductsTextBox.TabIndex = 14;
            // 
            // saveToDatabaseButton
            // 
            this.saveToDatabaseButton.Location = new System.Drawing.Point(456, 460);
            this.saveToDatabaseButton.Name = "saveToDatabaseButton";
            this.saveToDatabaseButton.Size = new System.Drawing.Size(158, 38);
            this.saveToDatabaseButton.TabIndex = 15;
            this.saveToDatabaseButton.Text = "Zapisz do bazy danych";
            this.saveToDatabaseButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(657, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "Zapisz do XML";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // orderManagementSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveToDatabaseButton);
            this.Controls.Add(this.displayProductsTextBox);
            this.Controls.Add(this.orderedProductsLabel);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.changeProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.dateOfBirthTextBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "orderManagementSystemForm";
            this.Text = "Order management system";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox dateOfBirthTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button changeProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Label orderedProductsLabel;
        private System.Windows.Forms.TextBox displayProductsTextBox;
        private System.Windows.Forms.Button saveToDatabaseButton;
        private System.Windows.Forms.Button button2;
    }
}
