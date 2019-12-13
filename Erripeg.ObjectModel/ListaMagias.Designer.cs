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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaMagias));
            this.characterUpdateButton = new System.Windows.Forms.Button();
            this.spellCreateButton = new System.Windows.Forms.Button();
            this.spellDeleteButton = new System.Windows.Forms.Button();
            this.spellListLabel = new System.Windows.Forms.Label();
            this.selectSpellDataGridView = new System.Windows.Forms.DataGridView();
            this.updateTableButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectSpellDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // characterUpdateButton
            // 
            this.characterUpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.characterUpdateButton.FlatAppearance.BorderSize = 10;
            this.characterUpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.characterUpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.characterUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterUpdateButton.ForeColor = System.Drawing.Color.Black;
            this.characterUpdateButton.Location = new System.Drawing.Point(358, 371);
            this.characterUpdateButton.Name = "characterUpdateButton";
            this.characterUpdateButton.Size = new System.Drawing.Size(100, 30);
            this.characterUpdateButton.TabIndex = 90;
            this.characterUpdateButton.Text = "Editar";
            this.characterUpdateButton.UseVisualStyleBackColor = true;
            // 
            // spellCreateButton
            // 
            this.spellCreateButton.FlatAppearance.BorderSize = 20;
            this.spellCreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellCreateButton.ForeColor = System.Drawing.Color.Black;
            this.spellCreateButton.Location = new System.Drawing.Point(207, 371);
            this.spellCreateButton.Name = "spellCreateButton";
            this.spellCreateButton.Size = new System.Drawing.Size(100, 30);
            this.spellCreateButton.TabIndex = 89;
            this.spellCreateButton.Text = "Criar";
            this.spellCreateButton.UseVisualStyleBackColor = true;
            this.spellCreateButton.Click += new System.EventHandler(this.spellCreateButton_Click);
            // 
            // spellDeleteButton
            // 
            this.spellDeleteButton.FlatAppearance.BorderSize = 20;
            this.spellDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellDeleteButton.ForeColor = System.Drawing.Color.Black;
            this.spellDeleteButton.Location = new System.Drawing.Point(207, 407);
            this.spellDeleteButton.Name = "spellDeleteButton";
            this.spellDeleteButton.Size = new System.Drawing.Size(100, 31);
            this.spellDeleteButton.TabIndex = 87;
            this.spellDeleteButton.Text = "Procurar";
            this.spellDeleteButton.UseVisualStyleBackColor = true;
            // 
            // spellListLabel
            // 
            this.spellListLabel.AutoSize = true;
            this.spellListLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spellListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellListLabel.ForeColor = System.Drawing.Color.Black;
            this.spellListLabel.Location = new System.Drawing.Point(12, 12);
            this.spellListLabel.Name = "spellListLabel";
            this.spellListLabel.Size = new System.Drawing.Size(139, 24);
            this.spellListLabel.TabIndex = 86;
            this.spellListLabel.Text = "Lista de magias";
            // 
            // selectSpellDataGridView
            // 
            this.selectSpellDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectSpellDataGridView.Location = new System.Drawing.Point(15, 48);
            this.selectSpellDataGridView.Name = "selectSpellDataGridView";
            this.selectSpellDataGridView.Size = new System.Drawing.Size(647, 317);
            this.selectSpellDataGridView.TabIndex = 91;
            this.selectSpellDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // updateTableButton
            // 
            this.updateTableButton.FlatAppearance.BorderSize = 20;
            this.updateTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTableButton.ForeColor = System.Drawing.Color.Black;
            this.updateTableButton.Location = new System.Drawing.Point(358, 407);
            this.updateTableButton.Name = "updateTableButton";
            this.updateTableButton.Size = new System.Drawing.Size(100, 31);
            this.updateTableButton.TabIndex = 92;
            this.updateTableButton.Text = "Deletar";
            this.updateTableButton.UseVisualStyleBackColor = true;
            this.updateTableButton.Click += new System.EventHandler(this.updateTableButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(587, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 93;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ListaMagias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateTableButton);
            this.Controls.Add(this.selectSpellDataGridView);
            this.Controls.Add(this.characterUpdateButton);
            this.Controls.Add(this.spellCreateButton);
            this.Controls.Add(this.spellDeleteButton);
            this.Controls.Add(this.spellListLabel);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "ListaMagias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaMagias";
            this.Load += new System.EventHandler(this.ListaMagias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectSpellDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button characterUpdateButton;
        private System.Windows.Forms.Button spellCreateButton;
        private System.Windows.Forms.Button spellDeleteButton;
        private System.Windows.Forms.Label spellListLabel;
        private System.Windows.Forms.Button updateTableButton;
        public System.Windows.Forms.DataGridView selectSpellDataGridView;
        private System.Windows.Forms.Button button1;
    }
}