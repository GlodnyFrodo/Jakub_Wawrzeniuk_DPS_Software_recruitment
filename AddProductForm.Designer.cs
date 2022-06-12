namespace Jakub_Wawrzeniuk_DPS_Software_recruitment
{
    partial class AddProductForm
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
            this.productNameLabel = new System.Windows.Forms.Label();
            this.amountlabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(12, 12);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(125, 21);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Nazwa produktu";
            // 
            // amountlabel
            // 
            this.amountlabel.AutoSize = true;
            this.amountlabel.Location = new System.Drawing.Point(12, 92);
            this.amountlabel.Name = "amountlabel";
            this.amountlabel.Size = new System.Drawing.Size(41, 21);
            this.amountlabel.TabIndex = 1;
            this.amountlabel.Text = "Ilość";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 52);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(81, 21);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Cena [szt.]";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(172, 9);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(230, 29);
            this.productNameTextBox.TabIndex = 3;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(172, 89);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(230, 29);
            this.amountTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(172, 49);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(230, 29);
            this.priceTextBox.TabIndex = 5;
            // 
            // addProductButton
            // 
            this.addProductButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addProductButton.Location = new System.Drawing.Point(18, 157);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(119, 47);
            this.addProductButton.TabIndex = 6;
            this.addProductButton.Text = "Dodaj";
            this.addProductButton.UseVisualStyleBackColor = true;
            // 
            // AddProductForm
            // 
            this.AcceptButton = this.addProductButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(475, 237);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.amountlabel);
            this.Controls.Add(this.productNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProductForm";
            this.ShowIcon = false;
            this.Text = "Wprowadź dane produktu:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label amountlabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button addProductButton;
    }
}