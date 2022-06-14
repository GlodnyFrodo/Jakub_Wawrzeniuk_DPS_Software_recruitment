namespace Jakub_Wawrzeniuk_DPS_Software_recruitment
{
    partial class ModifyProductForm
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
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.amountlabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.modifyProductButton.Location = new System.Drawing.Point(20, 145);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(119, 47);
            this.modifyProductButton.TabIndex = 13;
            this.modifyProductButton.Text = "Modyfikuj";
            this.modifyProductButton.UseVisualStyleBackColor = true;
            // 
            // priceTextBox
            // 
            this.priceTextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.priceTextBox.Location = new System.Drawing.Point(180, 52);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.PlaceholderText = "0,00";
            this.priceTextBox.Size = new System.Drawing.Size(230, 29);
            this.priceTextBox.TabIndex = 12;
            this.priceTextBox.Enter += new System.EventHandler(this.priceTextBox_Enter);
            this.priceTextBox.Leave += new System.EventHandler(this.priceTextBox_Leave);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(180, 92);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(230, 29);
            this.amountTextBox.TabIndex = 11;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(180, 12);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(230, 29);
            this.productNameTextBox.TabIndex = 10;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(20, 55);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(45, 21);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "Cena";
            // 
            // amountlabel
            // 
            this.amountlabel.AutoSize = true;
            this.amountlabel.Location = new System.Drawing.Point(20, 95);
            this.amountlabel.Name = "amountlabel";
            this.amountlabel.Size = new System.Drawing.Size(41, 21);
            this.amountlabel.TabIndex = 8;
            this.amountlabel.Text = "Ilość";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(20, 15);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(125, 21);
            this.productNameLabel.TabIndex = 7;
            this.productNameLabel.Text = "Nazwa produktu";
            // 
            // ModifyProductForm
            // 
            this.AcceptButton = this.modifyProductButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(439, 213);
            this.Controls.Add(this.modifyProductButton);
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
            this.Name = "ModifyProductForm";
            this.ShowIcon = false;
            this.Text = "Podaj parametry produktu do modyfikacji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label amountlabel;
        private System.Windows.Forms.Label productNameLabel;
    }
}