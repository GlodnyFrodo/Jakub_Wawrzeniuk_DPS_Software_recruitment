namespace Jakub_Wawrzeniuk_DPS_Software_recruitment
{
    partial class ProductParameters
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.productNameLabel = new System.Windows.Forms.Label();
            this.amountlabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(16, 6);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(125, 21);
            this.productNameLabel.TabIndex = 7;
            this.productNameLabel.Text = "Nazwa produktu";
            // 
            // amountlabel
            // 
            this.amountlabel.AutoSize = true;
            this.amountlabel.Location = new System.Drawing.Point(16, 86);
            this.amountlabel.Name = "amountlabel";
            this.amountlabel.Size = new System.Drawing.Size(41, 21);
            this.amountlabel.TabIndex = 8;
            this.amountlabel.Text = "Ilość";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(16, 46);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(81, 21);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "Cena [szt.]";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(176, 3);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(230, 29);
            this.productNameTextBox.TabIndex = 10;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(176, 83);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(230, 29);
            this.amountTextBox.TabIndex = 11;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(176, 43);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(230, 29);
            this.priceTextBox.TabIndex = 12;
            // 
            // sqlCommandBuilder1
            // 
            this.sqlCommandBuilder1.DataAdapter = null;
            this.sqlCommandBuilder1.QuotePrefix = "[";
            this.sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // ProductParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.amountlabel);
            this.Controls.Add(this.productNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductParameters";
            this.Size = new System.Drawing.Size(415, 122);
            this.Load += new System.EventHandler(this.ProductParameters_Load);
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
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}
