namespace Erripeg.ObjectModel
{
    partial class Inventário
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
            this.inventoryUserItemButton = new System.Windows.Forms.Button();
            this.inventoryDropItemTextBox = new System.Windows.Forms.Button();
            this.inventoryTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.inventorySizeTextBox = new System.Windows.Forms.TextBox();
            this.inventorySizeLabel = new System.Windows.Forms.Label();
            this.inventoryOwnerTextBox = new System.Windows.Forms.TextBox();
            this.inventoryOwnerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inventoryUserItemButton
            // 
            this.inventoryUserItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryUserItemButton.Location = new System.Drawing.Point(146, 415);
            this.inventoryUserItemButton.Name = "inventoryUserItemButton";
            this.inventoryUserItemButton.Size = new System.Drawing.Size(75, 33);
            this.inventoryUserItemButton.TabIndex = 13;
            this.inventoryUserItemButton.Text = "Use item";
            this.inventoryUserItemButton.UseVisualStyleBackColor = true;
            // 
            // inventoryDropItemTextBox
            // 
            this.inventoryDropItemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryDropItemTextBox.Location = new System.Drawing.Point(32, 415);
            this.inventoryDropItemTextBox.Name = "inventoryDropItemTextBox";
            this.inventoryDropItemTextBox.Size = new System.Drawing.Size(75, 33);
            this.inventoryDropItemTextBox.TabIndex = 12;
            this.inventoryDropItemTextBox.Text = "Drop item";
            this.inventoryDropItemTextBox.UseVisualStyleBackColor = true;
            // 
            // inventoryTableLayoutPanel
            // 
            this.inventoryTableLayoutPanel.ColumnCount = 2;
            this.inventoryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inventoryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inventoryTableLayoutPanel.Location = new System.Drawing.Point(32, 42);
            this.inventoryTableLayoutPanel.Name = "inventoryTableLayoutPanel";
            this.inventoryTableLayoutPanel.RowCount = 2;
            this.inventoryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inventoryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inventoryTableLayoutPanel.Size = new System.Drawing.Size(773, 364);
            this.inventoryTableLayoutPanel.TabIndex = 11;
            // 
            // inventorySizeTextBox
            // 
            this.inventorySizeTextBox.Location = new System.Drawing.Point(366, 21);
            this.inventorySizeTextBox.Name = "inventorySizeTextBox";
            this.inventorySizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventorySizeTextBox.TabIndex = 10;
            // 
            // inventorySizeLabel
            // 
            this.inventorySizeLabel.AutoSize = true;
            this.inventorySizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventorySizeLabel.Location = new System.Drawing.Point(318, 16);
            this.inventorySizeLabel.Name = "inventorySizeLabel";
            this.inventorySizeLabel.Size = new System.Drawing.Size(51, 24);
            this.inventorySizeLabel.TabIndex = 9;
            this.inventorySizeLabel.Text = "Size:";
            // 
            // inventoryOwnerTextBox
            // 
            this.inventoryOwnerTextBox.Location = new System.Drawing.Point(183, 21);
            this.inventoryOwnerTextBox.Name = "inventoryOwnerTextBox";
            this.inventoryOwnerTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventoryOwnerTextBox.TabIndex = 8;
            // 
            // inventoryOwnerLabel
            // 
            this.inventoryOwnerLabel.AutoSize = true;
            this.inventoryOwnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryOwnerLabel.Location = new System.Drawing.Point(28, 15);
            this.inventoryOwnerLabel.Name = "inventoryOwnerLabel";
            this.inventoryOwnerLabel.Size = new System.Drawing.Size(149, 24);
            this.inventoryOwnerLabel.TabIndex = 7;
            this.inventoryOwnerLabel.Text = "Inventory owner:";
            // 
            // Inventário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.inventoryUserItemButton);
            this.Controls.Add(this.inventoryDropItemTextBox);
            this.Controls.Add(this.inventoryTableLayoutPanel);
            this.Controls.Add(this.inventorySizeTextBox);
            this.Controls.Add(this.inventorySizeLabel);
            this.Controls.Add(this.inventoryOwnerTextBox);
            this.Controls.Add(this.inventoryOwnerLabel);
            this.Name = "Inventário";
            this.Text = "Inventário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inventoryUserItemButton;
        private System.Windows.Forms.Button inventoryDropItemTextBox;
        private System.Windows.Forms.TableLayoutPanel inventoryTableLayoutPanel;
        private System.Windows.Forms.TextBox inventorySizeTextBox;
        private System.Windows.Forms.Label inventorySizeLabel;
        private System.Windows.Forms.TextBox inventoryOwnerTextBox;
        private System.Windows.Forms.Label inventoryOwnerLabel;
    }
}