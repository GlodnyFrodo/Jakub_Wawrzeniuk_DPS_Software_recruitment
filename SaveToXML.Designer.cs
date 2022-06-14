namespace Jakub_Wawrzeniuk_DPS_Software_recruitment
{
    partial class SaveToXmlForm
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
            this.productNameDeleteButton = new System.Windows.Forms.Button();
            this.filenameForProductsTextBox = new System.Windows.Forms.TextBox();
            this.filenameForProductsLabel = new System.Windows.Forms.Label();
            this.filenameForOrderTextBox = new System.Windows.Forms.TextBox();
            this.filenameForOrderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productNameDeleteButton
            // 
            this.productNameDeleteButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.productNameDeleteButton.Location = new System.Drawing.Point(13, 115);
            this.productNameDeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.productNameDeleteButton.Name = "productNameDeleteButton";
            this.productNameDeleteButton.Size = new System.Drawing.Size(132, 60);
            this.productNameDeleteButton.TabIndex = 5;
            this.productNameDeleteButton.Text = "Zapisz";
            this.productNameDeleteButton.UseVisualStyleBackColor = true;
            // 
            // filenameForProductsTextBox
            // 
            this.filenameForProductsTextBox.Location = new System.Drawing.Point(235, 13);
            this.filenameForProductsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.filenameForProductsTextBox.Name = "filenameForProductsTextBox";
            this.filenameForProductsTextBox.Size = new System.Drawing.Size(739, 29);
            this.filenameForProductsTextBox.TabIndex = 4;
            // 
            // filenameForProductsLabel
            // 
            this.filenameForProductsLabel.AutoSize = true;
            this.filenameForProductsLabel.Location = new System.Drawing.Point(12, 16);
            this.filenameForProductsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.filenameForProductsLabel.Name = "filenameForProductsLabel";
            this.filenameForProductsLabel.Size = new System.Drawing.Size(214, 21);
            this.filenameForProductsLabel.TabIndex = 3;
            this.filenameForProductsLabel.Text = "Ścieżka zapisu dla produktów";
            // 
            // filenameForOrderTextBox
            // 
            this.filenameForOrderTextBox.Location = new System.Drawing.Point(235, 68);
            this.filenameForOrderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.filenameForOrderTextBox.Name = "filenameForOrderTextBox";
            this.filenameForOrderTextBox.Size = new System.Drawing.Size(739, 29);
            this.filenameForOrderTextBox.TabIndex = 7;
            // 
            // filenameForOrderLabel
            // 
            this.filenameForOrderLabel.AutoSize = true;
            this.filenameForOrderLabel.Location = new System.Drawing.Point(12, 71);
            this.filenameForOrderLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.filenameForOrderLabel.Name = "filenameForOrderLabel";
            this.filenameForOrderLabel.Size = new System.Drawing.Size(221, 21);
            this.filenameForOrderLabel.TabIndex = 6;
            this.filenameForOrderLabel.Text = "Ścieżka zapisu dla zamówienia";
            // 
            // SaveToXmlForm
            // 
            this.AcceptButton = this.productNameDeleteButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 202);
            this.Controls.Add(this.filenameForOrderTextBox);
            this.Controls.Add(this.filenameForOrderLabel);
            this.Controls.Add(this.productNameDeleteButton);
            this.Controls.Add(this.filenameForProductsTextBox);
            this.Controls.Add(this.filenameForProductsLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaveToXmlForm";
            this.Text = "Wpisz ścieżki do zapisu danych";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button productNameDeleteButton;
        private System.Windows.Forms.TextBox filenameForProductsTextBox;
        private System.Windows.Forms.Label filenameForProductsLabel;
        private System.Windows.Forms.TextBox filenameForOrderTextBox;
        private System.Windows.Forms.Label filenameForOrderLabel;
    }
}