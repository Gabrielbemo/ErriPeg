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
            this.SuspendLayout();
            // 
            // createSpellButton
            // 
            this.createSpellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSpellButton.Location = new System.Drawing.Point(72, 358);
            this.createSpellButton.Name = "createSpellButton";
            this.createSpellButton.Size = new System.Drawing.Size(76, 34);
            this.createSpellButton.TabIndex = 21;
            this.createSpellButton.Text = "Create spell";
            this.createSpellButton.UseVisualStyleBackColor = true;
            this.createSpellButton.Click += new System.EventHandler(this.createSpellButton_Click);
            // 
            // spellCooldownPrefixLabel
            // 
            this.spellCooldownPrefixLabel.AutoSize = true;
            this.spellCooldownPrefixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellCooldownPrefixLabel.Location = new System.Drawing.Point(29, 280);
            this.spellCooldownPrefixLabel.Name = "spellCooldownPrefixLabel";
            this.spellCooldownPrefixLabel.Size = new System.Drawing.Size(196, 24);
            this.spellCooldownPrefixLabel.TabIndex = 20;
            this.spellCooldownPrefixLabel.Text = "Spell cooldown prefix:";
            // 
            // spellCooldownPrefixTextBox
            // 
            this.spellCooldownPrefixTextBox.Location = new System.Drawing.Point(66, 307);
            this.spellCooldownPrefixTextBox.Name = "spellCooldownPrefixTextBox";
            this.spellCooldownPrefixTextBox.Size = new System.Drawing.Size(100, 20);
            this.spellCooldownPrefixTextBox.TabIndex = 19;
            // 
            // spellCooldownLabel
            // 
            this.spellCooldownLabel.AutoSize = true;
            this.spellCooldownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellCooldownLabel.Location = new System.Drawing.Point(42, 219);
            this.spellCooldownLabel.Name = "spellCooldownLabel";
            this.spellCooldownLabel.Size = new System.Drawing.Size(145, 24);
            this.spellCooldownLabel.TabIndex = 18;
            this.spellCooldownLabel.Text = "Spell cooldown:";
            // 
            // spellCooldownTextBox
            // 
            this.spellCooldownTextBox.Location = new System.Drawing.Point(66, 246);
            this.spellCooldownTextBox.Name = "spellCooldownTextBox";
            this.spellCooldownTextBox.Size = new System.Drawing.Size(100, 20);
            this.spellCooldownTextBox.TabIndex = 17;
            // 
            // spellCostLabel
            // 
            this.spellCostLabel.AutoSize = true;
            this.spellCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellCostLabel.Location = new System.Drawing.Point(68, 158);
            this.spellCostLabel.Name = "spellCostLabel";
            this.spellCostLabel.Size = new System.Drawing.Size(96, 24);
            this.spellCostLabel.TabIndex = 16;
            this.spellCostLabel.Text = "Spell cost:";
            // 
            // spellCostTextBox
            // 
            this.spellCostTextBox.Location = new System.Drawing.Point(66, 185);
            this.spellCostTextBox.Name = "spellCostTextBox";
            this.spellCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.spellCostTextBox.TabIndex = 15;
            // 
            // spellDamageLabel
            // 
            this.spellDamageLabel.AutoSize = true;
            this.spellDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellDamageLabel.Location = new System.Drawing.Point(56, 101);
            this.spellDamageLabel.Name = "spellDamageLabel";
            this.spellDamageLabel.Size = new System.Drawing.Size(131, 24);
            this.spellDamageLabel.TabIndex = 14;
            this.spellDamageLabel.Text = "Spell damage:";
            // 
            // spellDamageTextBox
            // 
            this.spellDamageTextBox.Location = new System.Drawing.Point(66, 128);
            this.spellDamageTextBox.Name = "spellDamageTextBox";
            this.spellDamageTextBox.Size = new System.Drawing.Size(100, 20);
            this.spellDamageTextBox.TabIndex = 13;
            // 
            // spellNameTextBox
            // 
            this.spellNameTextBox.Location = new System.Drawing.Point(66, 77);
            this.spellNameTextBox.Name = "spellNameTextBox";
            this.spellNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.spellNameTextBox.TabIndex = 12;
            // 
            // spellNameLabel
            // 
            this.spellNameLabel.AutoSize = true;
            this.spellNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellNameLabel.Location = new System.Drawing.Point(56, 50);
            this.spellNameLabel.Name = "spellNameLabel";
            this.spellNameLabel.Size = new System.Drawing.Size(110, 24);
            this.spellNameLabel.TabIndex = 11;
            this.spellNameLabel.Text = "Spell name:";
            // 
            // CriaçãoMagias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 450);
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
            this.Name = "CriaçãoMagias";
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
    }
}