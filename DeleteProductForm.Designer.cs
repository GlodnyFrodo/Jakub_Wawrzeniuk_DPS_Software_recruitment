namespace Jakub_Wawrzeniuk_DPS_Software_recruitment
{
    partial class DeleteProductForm
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
            this.productNameDeleteLabel = new System.Windows.Forms.Label();
            this.productNameDeleteTextBox = new System.Windows.Forms.TextBox();
            this.productNameDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productNameDeleteLabel
            // 
            this.productNameDeleteLabel.AutoSize = true;
            this.productNameDeleteLabel.Location = new System.Drawing.Point(13, 19);
            this.productNameDeleteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productNameDeleteLabel.Name = "productNameDeleteLabel";
            this.productNameDeleteLabel.Size = new System.Drawing.Size(125, 21);
            this.productNameDeleteLabel.TabIndex = 0;
            this.productNameDeleteLabel.Text = "Nazwa produktu";
            // 
            // productNameDeleteTextBox
            // 
            this.productNameDeleteTextBox.Location = new System.Drawing.Point(13, 53);
            this.productNameDeleteTextBox.Name = "productNameDeleteTextBox";
            this.productNameDeleteTextBox.Size = new System.Drawing.Size(270, 29);
            this.productNameDeleteTextBox.TabIndex = 1;
            // 
            // productNameDeleteButton
            // 
            this.productNameDeleteButton.Location = new System.Drawing.Point(13, 105);
            this.productNameDeleteButton.Name = "productNameDeleteButton";
            this.productNameDeleteButton.Size = new System.Drawing.Size(103, 43);
            this.productNameDeleteButton.TabIndex = 2;
            this.productNameDeleteButton.Text = "Usuń";
            this.productNameDeleteButton.UseVisualStyleBackColor = true;
            // 
            // DeleteProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(318, 177);
            this.Controls.Add(this.productNameDeleteButton);
            this.Controls.Add(this.productNameDeleteTextBox);
            this.Controls.Add(this.productNameDeleteLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteProductForm";
            this.ShowIcon = false;
            this.Text = "Podaj nazwę produktu, który chesz usunąć";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productNameDeleteLabel;
        private System.Windows.Forms.TextBox productNameDeleteTextBox;
        private System.Windows.Forms.Button productNameDeleteButton;
    }
}