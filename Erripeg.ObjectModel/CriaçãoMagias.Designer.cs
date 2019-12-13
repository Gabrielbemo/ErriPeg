namespace Erripeg.ObjectModel
{
    partial class CriaçãoMagias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriaçãoMagias));
            this.createSpellButton = new System.Windows.Forms.Button();
            this.spellCooldownPrefixLabel = new System.Windows.Forms.Label();
            this.spellCooldownPrefixTextBox = new System.Windows.Forms.TextBox();
            this.spellCooldownLabel = new System.Windows.Forms.Label();
            this.spellCooldownTextBox = new System.Windows.Forms.TextBox();
            this.spellCostLabel = new System.Windows.Forms.Label();
            this.spellCostTextBox = new System.Windows.Forms.TextBox();
            this.spellDamageLabel = new System.Windows.Forms.Label();
            this.spellDamageTextBox = new System.Windows.Forms.TextBox();
            this.spellNameTextBox = new System.Windows.Forms.TextBox();
            this.spellNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createSpellButton
            // 
            this.createSpellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSpellButton.ForeColor = System.Drawing.Color.Black;
            this.createSpellButton.Location = new System.Drawing.Point(121, 357);
            this.createSpellButton.Name = "createSpellButton";
            this.createSpellButton.Size = new System.Drawing.Size(76, 34);
            this.createSpellButton.TabIndex = 21;
            this.createSpellButton.Text = "Criar";
            this.createSpellButton.UseVisualStyleBackColor = true;
            this.createSpellButton.Click += new System.EventHandler(this.createSpellButton_Click);
            // 
            // spellCooldownPrefixLabel
            // 
            this.spellCooldownPrefixLabel.AutoSize = true;
            this.spellCooldownPrefixLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spellCooldownPrefixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellCooldownPrefixLabel.ForeColor = System.Drawing.Color.Black;
            this.spellCooldownPrefixLabel.Location = new System.Drawing.Point(8, 280);
            this.spellCooldownPrefixLabel.Name = "spellCooldownPrefixLabel";
            this.spellCooldownPrefixLabel.Size = new System.Drawing.Size(291, 24);
            this.spellCooldownPrefixLabel.TabIndex = 20;
            this.spellCooldownPrefixLabel.Text = "Tempo de recarga da mágia(tipo)";
            // 
            // spellCooldownPrefixTextBox
            // 
            this.spellCooldownPrefixTextBox.Location = new System.Drawing.Point(108, 307);
            this.spellCooldownPrefixTextBox.Name = "spellCooldownPrefixTextBox";
            this.spellCooldownPrefixTextBox.Size = new System.Drawing.Size(100, 20);
            this.spellCooldownPrefixTextBox.TabIndex = 19;
            // 
            // spellCooldownLabel
            // 
            this.spellCooldownLabel.AutoSize = true;
            this.spellCooldownLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spellCooldownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellCooldownLabel.ForeColor = System.Drawing.Color.Black;
            this.spellCooldownLabel.Location = new System.Drawing.Point(26, 221);
            this.spellCooldownLabel.Name = "spellCooldownLabel";
            this.spellCooldownLabel.Size = new System.Drawing.Size(249, 24);
            this.spellCooldownLabel.TabIndex = 18;
            this.spellCooldownLabel.Text = "Tempo de recarga da mágia";
            // 
            // spellCooldownTextBox
            // 
            this.spellCooldownTextBox.Location = new System.Drawing.Point(108, 248);
            this.spellCooldownTextBox.Name = "spellCooldownTextBox";
            this.spellCooldownTextBox.Size = new System.Drawing.Size(100, 20);
            this.spellCooldownTextBox.TabIndex = 17;
            // 
            // spellCostLabel
            // 
            this.spellCostLabel.AutoSize = true;
            this.spellCostLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spellCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellCostLabel.ForeColor = System.Drawing.Color.Black;
            this.spellCostLabel.Location = new System.Drawing.Point(83, 160);
            this.spellCostLabel.Name = "spellCostLabel";
            this.spellCostLabel.Size = new System.Drawing.Size(145, 24);
            this.spellCostLabel.TabIndex = 16;
            this.spellCostLabel.Text = "Custo da mágia:";
            // 
            // spellCostTextBox
            // 
            this.spellCostTextBox.Location = new System.Drawing.Point(108, 187);
            this.spellCostTextBox.Name = "spellCostTextBox";
            this.spellCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.spellCostTextBox.TabIndex = 15;
            // 
            // spellDamageLabel
            // 
            this.spellDamageLabel.AutoSize = true;
            this.spellDamageLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spellDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellDamageLabel.ForeColor = System.Drawing.Color.Black;
            this.spellDamageLabel.Location = new System.Drawing.Point(83, 110);
            this.spellDamageLabel.Name = "spellDamageLabel";
            this.spellDamageLabel.Size = new System.Drawing.Size(142, 24);
            this.spellDamageLabel.TabIndex = 14;
            this.spellDamageLabel.Text = "Dano da mágia:";
            // 
            // spellDamageTextBox
            // 
            this.spellDamageTextBox.Location = new System.Drawing.Point(108, 137);
            this.spellDamageTextBox.Name = "spellDamageTextBox";
            this.spellDamageTextBox.Size = new System.Drawing.Size(100, 20);
            this.spellDamageTextBox.TabIndex = 13;
            // 
            // spellNameTextBox
            // 
            this.spellNameTextBox.Location = new System.Drawing.Point(108, 86);
            this.spellNameTextBox.Name = "spellNameTextBox";
            this.spellNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.spellNameTextBox.TabIndex = 12;
            // 
            // spellNameLabel
            // 
            this.spellNameLabel.AutoSize = true;
            this.spellNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spellNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellNameLabel.ForeColor = System.Drawing.Color.Black;
            this.spellNameLabel.Location = new System.Drawing.Point(83, 59);
            this.spellNameLabel.Name = "spellNameLabel";
            this.spellNameLabel.Size = new System.Drawing.Size(149, 24);
            this.spellNameLabel.TabIndex = 11;
            this.spellNameLabel.Text = "Nome da mágia:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(231, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CriaçãoMagias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(318, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createSpellButton);
            this.Controls.Add(this.spellCooldownPrefixLabel);
            this.Controls.Add(this.spellCooldownPrefixTextBox);
            this.Controls.Add(this.spellCooldownLabel);
            this.Controls.Add(this.spellCooldownTextBox);
            this.Controls.Add(this.spellCostLabel);
            this.Controls.Add(this.spellCostTextBox);
            this.Controls.Add(this.spellDamageLabel);
            this.Controls.Add(this.spellDamageTextBox);
            this.Controls.Add(this.spellNameTextBox);
            this.Controls.Add(this.spellNameLabel);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "CriaçãoMagias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CriaçãoMagias";
            this.Load += new System.EventHandler(this.CriaçãoMagias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createSpellButton;
        private System.Windows.Forms.Label spellCooldownPrefixLabel;
        private System.Windows.Forms.TextBox spellCooldownPrefixTextBox;
        private System.Windows.Forms.Label spellCooldownLabel;
        private System.Windows.Forms.TextBox spellCooldownTextBox;
        private System.Windows.Forms.Label spellCostLabel;
        private System.Windows.Forms.TextBox spellCostTextBox;
        private System.Windows.Forms.Label spellDamageLabel;
        private System.Windows.Forms.TextBox spellDamageTextBox;
        private System.Windows.Forms.TextBox spellNameTextBox;
        private System.Windows.Forms.Label spellNameLabel;
        private System.Windows.Forms.Button button1;
    }
}