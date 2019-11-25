namespace Erripeg.ObjectModel
{
    partial class ListaMagias
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.characterUpdateButton = new System.Windows.Forms.Button();
            this.spellCreateButton = new System.Windows.Forms.Button();
            this.spellSearchButton = new System.Windows.Forms.Button();
            this.spellDeleteButton = new System.Windows.Forms.Button();
            this.spellListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(645, 293);
            this.tableLayoutPanel1.TabIndex = 91;
            // 
            // characterUpdateButton
            // 
            this.characterUpdateButton.Location = new System.Drawing.Point(355, 407);
            this.characterUpdateButton.Name = "characterUpdateButton";
            this.characterUpdateButton.Size = new System.Drawing.Size(100, 23);
            this.characterUpdateButton.TabIndex = 90;
            this.characterUpdateButton.Text = "Update spell";
            this.characterUpdateButton.UseVisualStyleBackColor = true;
            // 
            // spellCreateButton
            // 
            this.spellCreateButton.Location = new System.Drawing.Point(355, 371);
            this.spellCreateButton.Name = "spellCreateButton";
            this.spellCreateButton.Size = new System.Drawing.Size(100, 23);
            this.spellCreateButton.TabIndex = 89;
            this.spellCreateButton.Text = "Create spell";
            this.spellCreateButton.UseVisualStyleBackColor = true;
            // 
            // spellSearchButton
            // 
            this.spellSearchButton.Location = new System.Drawing.Point(207, 371);
            this.spellSearchButton.Name = "spellSearchButton";
            this.spellSearchButton.Size = new System.Drawing.Size(100, 23);
            this.spellSearchButton.TabIndex = 88;
            this.spellSearchButton.Text = "Search spell";
            this.spellSearchButton.UseVisualStyleBackColor = true;
            // 
            // spellDeleteButton
            // 
            this.spellDeleteButton.Location = new System.Drawing.Point(207, 407);
            this.spellDeleteButton.Name = "spellDeleteButton";
            this.spellDeleteButton.Size = new System.Drawing.Size(100, 23);
            this.spellDeleteButton.TabIndex = 87;
            this.spellDeleteButton.Text = "Delete spell";
            this.spellDeleteButton.UseVisualStyleBackColor = true;
            // 
            // spellListLabel
            // 
            this.spellListLabel.AutoSize = true;
            this.spellListLabel.Location = new System.Drawing.Point(12, 23);
            this.spellListLabel.Name = "spellListLabel";
            this.spellListLabel.Size = new System.Drawing.Size(49, 13);
            this.spellListLabel.TabIndex = 86;
            this.spellListLabel.Text = "Spell List";
            // 
            // ListaMagias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.characterUpdateButton);
            this.Controls.Add(this.spellCreateButton);
            this.Controls.Add(this.spellSearchButton);
            this.Controls.Add(this.spellDeleteButton);
            this.Controls.Add(this.spellListLabel);
            this.Name = "ListaMagias";
            this.Text = "ListaMagias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button characterUpdateButton;
        private System.Windows.Forms.Button spellCreateButton;
        private System.Windows.Forms.Button spellSearchButton;
        private System.Windows.Forms.Button spellDeleteButton;
        private System.Windows.Forms.Label spellListLabel;
    }
}