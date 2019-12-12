namespace Erripeg.ObjectModel
{
    partial class CriaçãoPersonagem
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
            this.characterCreateButton = new System.Windows.Forms.Button();
            this.characterSearchLabel = new System.Windows.Forms.Label();
            this.characterSearchTextBox = new System.Windows.Forms.TextBox();
            this.characterBackgroundLabel = new System.Windows.Forms.Label();
            this.characterXpTextBox = new System.Windows.Forms.TextBox();
            this.characterLvlTextBox = new System.Windows.Forms.TextBox();
            this.characterLvlLabel = new System.Windows.Forms.Label();
            this.characterNameTextBox = new System.Windows.Forms.TextBox();
            this.characterHeightTextBox = new System.Windows.Forms.TextBox();
            this.characterWeightTextBox = new System.Windows.Forms.TextBox();
            this.characterInfoLabel = new System.Windows.Forms.Label();
            this.characterManaTextBox = new System.Windows.Forms.TextBox();
            this.characterLifeTextBox = new System.Windows.Forms.TextBox();
            this.characterIdTextBox = new System.Windows.Forms.TextBox();
            this.characterBackgroundRichTextBox = new System.Windows.Forms.RichTextBox();
            this.characterIdLabel = new System.Windows.Forms.Label();
            this.characterXpLabel = new System.Windows.Forms.Label();
            this.characterHeightLabel = new System.Windows.Forms.Label();
            this.characterWeightLabel = new System.Windows.Forms.Label();
            this.characterManaLabel = new System.Windows.Forms.Label();
            this.characterLifeLabel = new System.Windows.Forms.Label();
            this.characterNameLabel = new System.Windows.Forms.Label();
            this.characterImagePictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.characterImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // characterCreateButton
            // 
            this.characterCreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterCreateButton.Location = new System.Drawing.Point(321, 398);
            this.characterCreateButton.Name = "characterCreateButton";
            this.characterCreateButton.Size = new System.Drawing.Size(100, 40);
            this.characterCreateButton.TabIndex = 118;
            this.characterCreateButton.Text = "Criar";
            this.characterCreateButton.UseVisualStyleBackColor = true;
            this.characterCreateButton.Click += new System.EventHandler(this.CharacterCreateButton_Click);
            // 
            // characterSearchLabel
            // 
            this.characterSearchLabel.AutoSize = true;
            this.characterSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterSearchLabel.Location = new System.Drawing.Point(247, 336);
            this.characterSearchLabel.Name = "characterSearchLabel";
            this.characterSearchLabel.Size = new System.Drawing.Size(247, 24);
            this.characterSearchLabel.TabIndex = 117;
            this.characterSearchLabel.Text = "Procurar personagem por id";
            this.characterSearchLabel.Click += new System.EventHandler(this.characterSearchLabel_Click);
            // 
            // characterSearchTextBox
            // 
            this.characterSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterSearchTextBox.Location = new System.Drawing.Point(251, 363);
            this.characterSearchTextBox.Name = "characterSearchTextBox";
            this.characterSearchTextBox.Size = new System.Drawing.Size(248, 29);
            this.characterSearchTextBox.TabIndex = 115;
            this.characterSearchTextBox.TextChanged += new System.EventHandler(this.characterSearchTextBox_TextChanged);
            // 
            // characterBackgroundLabel
            // 
            this.characterBackgroundLabel.AutoSize = true;
            this.characterBackgroundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterBackgroundLabel.Location = new System.Drawing.Point(530, 16);
            this.characterBackgroundLabel.Name = "characterBackgroundLabel";
            this.characterBackgroundLabel.Size = new System.Drawing.Size(77, 24);
            this.characterBackgroundLabel.TabIndex = 107;
            this.characterBackgroundLabel.Text = "História:";
            this.characterBackgroundLabel.Click += new System.EventHandler(this.characterBackgroundLabel_Click);
            // 
            // characterXpTextBox
            // 
            this.characterXpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterXpTextBox.Location = new System.Drawing.Point(399, 70);
            this.characterXpTextBox.Name = "characterXpTextBox";
            this.characterXpTextBox.Size = new System.Drawing.Size(100, 29);
            this.characterXpTextBox.TabIndex = 106;
            this.characterXpTextBox.TextChanged += new System.EventHandler(this.characterXpTextBox_TextChanged);
            // 
            // characterLvlTextBox
            // 
            this.characterLvlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterLvlTextBox.Location = new System.Drawing.Point(128, 43);
            this.characterLvlTextBox.Name = "characterLvlTextBox";
            this.characterLvlTextBox.Size = new System.Drawing.Size(100, 29);
            this.characterLvlTextBox.TabIndex = 105;
            this.characterLvlTextBox.TextChanged += new System.EventHandler(this.characterLvlTextBox_TextChanged);
            // 
            // characterLvlLabel
            // 
            this.characterLvlLabel.AutoSize = true;
            this.characterLvlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterLvlLabel.Location = new System.Drawing.Point(124, 16);
            this.characterLvlLabel.Name = "characterLvlLabel";
            this.characterLvlLabel.Size = new System.Drawing.Size(57, 24);
            this.characterLvlLabel.TabIndex = 104;
            this.characterLvlLabel.Text = "Nível:";
            this.characterLvlLabel.Click += new System.EventHandler(this.characterLvlLabel_Click);
            // 
            // characterNameTextBox
            // 
            this.characterNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterNameTextBox.Location = new System.Drawing.Point(18, 43);
            this.characterNameTextBox.Name = "characterNameTextBox";
            this.characterNameTextBox.Size = new System.Drawing.Size(100, 29);
            this.characterNameTextBox.TabIndex = 103;
            this.characterNameTextBox.TextChanged += new System.EventHandler(this.characterNameTextBox_TextChanged);
            // 
            // characterHeightTextBox
            // 
            this.characterHeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterHeightTextBox.Location = new System.Drawing.Point(251, 304);
            this.characterHeightTextBox.Name = "characterHeightTextBox";
            this.characterHeightTextBox.Size = new System.Drawing.Size(100, 29);
            this.characterHeightTextBox.TabIndex = 102;
            this.characterHeightTextBox.TextChanged += new System.EventHandler(this.characterHeightTextBox_TextChanged);
            // 
            // characterWeightTextBox
            // 
            this.characterWeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterWeightTextBox.Location = new System.Drawing.Point(251, 245);
            this.characterWeightTextBox.Name = "characterWeightTextBox";
            this.characterWeightTextBox.Size = new System.Drawing.Size(100, 29);
            this.characterWeightTextBox.TabIndex = 101;
            this.characterWeightTextBox.TextChanged += new System.EventHandler(this.characterWeightTextBox_TextChanged);
            // 
            // characterInfoLabel
            // 
            this.characterInfoLabel.AutoSize = true;
            this.characterInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterInfoLabel.Location = new System.Drawing.Point(247, 9);
            this.characterInfoLabel.Name = "characterInfoLabel";
            this.characterInfoLabel.Size = new System.Drawing.Size(113, 24);
            this.characterInfoLabel.TabIndex = 100;
            this.characterInfoLabel.Text = "Informações";
            this.characterInfoLabel.Click += new System.EventHandler(this.characterInfoLabel_Click);
            // 
            // characterManaTextBox
            // 
            this.characterManaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterManaTextBox.Location = new System.Drawing.Point(252, 186);
            this.characterManaTextBox.Name = "characterManaTextBox";
            this.characterManaTextBox.Size = new System.Drawing.Size(100, 29);
            this.characterManaTextBox.TabIndex = 99;
            this.characterManaTextBox.TextChanged += new System.EventHandler(this.characterManaTextBox_TextChanged);
            // 
            // characterLifeTextBox
            // 
            this.characterLifeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterLifeTextBox.Location = new System.Drawing.Point(251, 127);
            this.characterLifeTextBox.Name = "characterLifeTextBox";
            this.characterLifeTextBox.Size = new System.Drawing.Size(100, 29);
            this.characterLifeTextBox.TabIndex = 98;
            this.characterLifeTextBox.TextChanged += new System.EventHandler(this.CharacterLifeTextBox_TextChanged);
            // 
            // characterIdTextBox
            // 
            this.characterIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterIdTextBox.Location = new System.Drawing.Point(251, 70);
            this.characterIdTextBox.Name = "characterIdTextBox";
            this.characterIdTextBox.Size = new System.Drawing.Size(100, 29);
            this.characterIdTextBox.TabIndex = 97;
            this.characterIdTextBox.TextChanged += new System.EventHandler(this.characterIdTextBox_TextChanged);
            // 
            // characterBackgroundRichTextBox
            // 
            this.characterBackgroundRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterBackgroundRichTextBox.Location = new System.Drawing.Point(534, 59);
            this.characterBackgroundRichTextBox.Name = "characterBackgroundRichTextBox";
            this.characterBackgroundRichTextBox.Size = new System.Drawing.Size(286, 359);
            this.characterBackgroundRichTextBox.TabIndex = 95;
            this.characterBackgroundRichTextBox.Text = "";
            this.characterBackgroundRichTextBox.TextChanged += new System.EventHandler(this.characterBackgroundRichTextBox_TextChanged);
            // 
            // characterIdLabel
            // 
            this.characterIdLabel.AutoSize = true;
            this.characterIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterIdLabel.Location = new System.Drawing.Point(248, 43);
            this.characterIdLabel.Name = "characterIdLabel";
            this.characterIdLabel.Size = new System.Drawing.Size(144, 24);
            this.characterIdLabel.TabIndex = 89;
            this.characterIdLabel.Text = "ID personagem:";
            this.characterIdLabel.Click += new System.EventHandler(this.characterIdLabel_Click);
            // 
            // characterXpLabel
            // 
            this.characterXpLabel.AutoSize = true;
            this.characterXpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterXpLabel.Location = new System.Drawing.Point(395, 43);
            this.characterXpLabel.Name = "characterXpLabel";
            this.characterXpLabel.Size = new System.Drawing.Size(41, 24);
            this.characterXpLabel.TabIndex = 87;
            this.characterXpLabel.Text = "XP:";
            this.characterXpLabel.Click += new System.EventHandler(this.characterXpLabel_Click);
            // 
            // characterHeightLabel
            // 
            this.characterHeightLabel.AutoSize = true;
            this.characterHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterHeightLabel.Location = new System.Drawing.Point(247, 277);
            this.characterHeightLabel.Name = "characterHeightLabel";
            this.characterHeightLabel.Size = new System.Drawing.Size(63, 24);
            this.characterHeightLabel.TabIndex = 86;
            this.characterHeightLabel.Text = "Altura:";
            this.characterHeightLabel.Click += new System.EventHandler(this.characterHeightLabel_Click);
            // 
            // characterWeightLabel
            // 
            this.characterWeightLabel.AutoSize = true;
            this.characterWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterWeightLabel.Location = new System.Drawing.Point(247, 218);
            this.characterWeightLabel.Name = "characterWeightLabel";
            this.characterWeightLabel.Size = new System.Drawing.Size(58, 24);
            this.characterWeightLabel.TabIndex = 85;
            this.characterWeightLabel.Text = "Peso:";
            this.characterWeightLabel.Click += new System.EventHandler(this.characterWeightLabel_Click);
            // 
            // characterManaLabel
            // 
            this.characterManaLabel.AutoSize = true;
            this.characterManaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterManaLabel.Location = new System.Drawing.Point(248, 159);
            this.characterManaLabel.Name = "characterManaLabel";
            this.characterManaLabel.Size = new System.Drawing.Size(62, 24);
            this.characterManaLabel.TabIndex = 84;
            this.characterManaLabel.Text = "Mana:";
            this.characterManaLabel.Click += new System.EventHandler(this.characterManaLabel_Click);
            // 
            // characterLifeLabel
            // 
            this.characterLifeLabel.AutoSize = true;
            this.characterLifeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterLifeLabel.Location = new System.Drawing.Point(248, 102);
            this.characterLifeLabel.Name = "characterLifeLabel";
            this.characterLifeLabel.Size = new System.Drawing.Size(53, 24);
            this.characterLifeLabel.TabIndex = 83;
            this.characterLifeLabel.Text = "Vida:";
            this.characterLifeLabel.Click += new System.EventHandler(this.characterLifeLabel_Click);
            // 
            // characterNameLabel
            // 
            this.characterNameLabel.AutoSize = true;
            this.characterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterNameLabel.Location = new System.Drawing.Point(14, 16);
            this.characterNameLabel.Name = "characterNameLabel";
            this.characterNameLabel.Size = new System.Drawing.Size(67, 24);
            this.characterNameLabel.TabIndex = 82;
            this.characterNameLabel.Text = "Nome:";
            this.characterNameLabel.Click += new System.EventHandler(this.characterNameLabel_Click);
            // 
            // characterImagePictureBox
            // 
            this.characterImagePictureBox.Location = new System.Drawing.Point(18, 85);
            this.characterImagePictureBox.Name = "characterImagePictureBox";
            this.characterImagePictureBox.Size = new System.Drawing.Size(210, 333);
            this.characterImagePictureBox.TabIndex = 81;
            this.characterImagePictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(745, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 119;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CriaçãoPersonagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.characterCreateButton);
            this.Controls.Add(this.characterSearchLabel);
            this.Controls.Add(this.characterSearchTextBox);
            this.Controls.Add(this.characterBackgroundLabel);
            this.Controls.Add(this.characterXpTextBox);
            this.Controls.Add(this.characterLvlTextBox);
            this.Controls.Add(this.characterLvlLabel);
            this.Controls.Add(this.characterNameTextBox);
            this.Controls.Add(this.characterHeightTextBox);
            this.Controls.Add(this.characterWeightTextBox);
            this.Controls.Add(this.characterInfoLabel);
            this.Controls.Add(this.characterManaTextBox);
            this.Controls.Add(this.characterLifeTextBox);
            this.Controls.Add(this.characterIdTextBox);
            this.Controls.Add(this.characterBackgroundRichTextBox);
            this.Controls.Add(this.characterIdLabel);
            this.Controls.Add(this.characterXpLabel);
            this.Controls.Add(this.characterHeightLabel);
            this.Controls.Add(this.characterWeightLabel);
            this.Controls.Add(this.characterManaLabel);
            this.Controls.Add(this.characterLifeLabel);
            this.Controls.Add(this.characterNameLabel);
            this.Controls.Add(this.characterImagePictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CriaçãoPersonagem";
            this.Text = "CriaçãoPersonagem";
            ((System.ComponentModel.ISupportInitialize)(this.characterImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button characterCreateButton;
        private System.Windows.Forms.Label characterSearchLabel;
        private System.Windows.Forms.TextBox characterSearchTextBox;
        private System.Windows.Forms.Label characterBackgroundLabel;
        private System.Windows.Forms.TextBox characterXpTextBox;
        private System.Windows.Forms.TextBox characterLvlTextBox;
        private System.Windows.Forms.Label characterLvlLabel;
        private System.Windows.Forms.TextBox characterNameTextBox;
        private System.Windows.Forms.TextBox characterHeightTextBox;
        private System.Windows.Forms.TextBox characterWeightTextBox;
        private System.Windows.Forms.Label characterInfoLabel;
        private System.Windows.Forms.TextBox characterManaTextBox;
        private System.Windows.Forms.TextBox characterLifeTextBox;
        private System.Windows.Forms.TextBox characterIdTextBox;
        private System.Windows.Forms.RichTextBox characterBackgroundRichTextBox;
        private System.Windows.Forms.Label characterIdLabel;
        private System.Windows.Forms.Label characterXpLabel;
        private System.Windows.Forms.Label characterHeightLabel;
        private System.Windows.Forms.Label characterWeightLabel;
        private System.Windows.Forms.Label characterManaLabel;
        private System.Windows.Forms.Label characterLifeLabel;
        private System.Windows.Forms.Label characterNameLabel;
        private System.Windows.Forms.PictureBox characterImagePictureBox;
        private System.Windows.Forms.Button button1;
    }
}