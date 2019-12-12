namespace Erripeg.ObjectModel
{
    partial class Bestiario
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
            this.creatureUpdateButton = new System.Windows.Forms.Button();
            this.creatureCreateButton = new System.Windows.Forms.Button();
            this.creatureSearchLabel = new System.Windows.Forms.Label();
            this.creatureSearchButton = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.TextBox();
            this.creatureBackgroundLabel = new System.Windows.Forms.Label();
            this.creatureXpTextBox = new System.Windows.Forms.TextBox();
            this.creatureLvlTextBox = new System.Windows.Forms.TextBox();
            this.creatureLvlLabel = new System.Windows.Forms.Label();
            this.creatureNameTextBox = new System.Windows.Forms.TextBox();
            this.creatureHeightTextBox = new System.Windows.Forms.TextBox();
            this.creatureWeightTextBox = new System.Windows.Forms.TextBox();
            this.creatureInfoLabel = new System.Windows.Forms.Label();
            this.creatureManaTextBox = new System.Windows.Forms.TextBox();
            this.creatureLifeTextBox = new System.Windows.Forms.TextBox();
            this.creatureIdTextBox = new System.Windows.Forms.TextBox();
            this.creatureDeleteButton = new System.Windows.Forms.Button();
            this.creatureBackgroundRichTextBox = new System.Windows.Forms.RichTextBox();
            this.creatureIdLabel = new System.Windows.Forms.Label();
            this.creatureXpLabel = new System.Windows.Forms.Label();
            this.creatureHeightLabel = new System.Windows.Forms.Label();
            this.creatureWeightLabel = new System.Windows.Forms.Label();
            this.creatureManaLabel = new System.Windows.Forms.Label();
            this.creatureLifeLabel = new System.Windows.Forms.Label();
            this.creatureNameLabel = new System.Windows.Forms.Label();
            this.creatureImagePictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.creatureImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // creatureUpdateButton
            // 
            this.creatureUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureUpdateButton.Location = new System.Drawing.Point(398, 373);
            this.creatureUpdateButton.Name = "creatureUpdateButton";
            this.creatureUpdateButton.Size = new System.Drawing.Size(100, 29);
            this.creatureUpdateButton.TabIndex = 80;
            this.creatureUpdateButton.Text = "Editar";
            this.creatureUpdateButton.UseVisualStyleBackColor = true;
            // 
            // creatureCreateButton
            // 
            this.creatureCreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureCreateButton.Location = new System.Drawing.Point(398, 338);
            this.creatureCreateButton.Name = "creatureCreateButton";
            this.creatureCreateButton.Size = new System.Drawing.Size(100, 29);
            this.creatureCreateButton.TabIndex = 79;
            this.creatureCreateButton.Text = "Criar";
            this.creatureCreateButton.UseVisualStyleBackColor = true;
            this.creatureCreateButton.Click += new System.EventHandler(this.CreatureCreateButton_Click);
            // 
            // creatureSearchLabel
            // 
            this.creatureSearchLabel.AutoSize = true;
            this.creatureSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureSearchLabel.Location = new System.Drawing.Point(249, 285);
            this.creatureSearchLabel.Name = "creatureSearchLabel";
            this.creatureSearchLabel.Size = new System.Drawing.Size(206, 24);
            this.creatureSearchLabel.TabIndex = 78;
            this.creatureSearchLabel.Text = "Procurar criatura por id:";
            // 
            // creatureSearchButton
            // 
            this.creatureSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureSearchButton.Location = new System.Drawing.Point(250, 338);
            this.creatureSearchButton.Name = "creatureSearchButton";
            this.creatureSearchButton.Size = new System.Drawing.Size(100, 29);
            this.creatureSearchButton.TabIndex = 77;
            this.creatureSearchButton.Text = "Procurar criatura";
            this.creatureSearchButton.UseVisualStyleBackColor = true;
            this.creatureSearchButton.Click += new System.EventHandler(this.CreatureSearchButton_Click);
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(250, 312);
            this.c.Name = "c";
            this.c.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.c.Size = new System.Drawing.Size(248, 20);
            this.c.TabIndex = 76;
            // 
            // creatureBackgroundLabel
            // 
            this.creatureBackgroundLabel.AutoSize = true;
            this.creatureBackgroundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureBackgroundLabel.Location = new System.Drawing.Point(529, 24);
            this.creatureBackgroundLabel.Name = "creatureBackgroundLabel";
            this.creatureBackgroundLabel.Size = new System.Drawing.Size(77, 24);
            this.creatureBackgroundLabel.TabIndex = 68;
            this.creatureBackgroundLabel.Text = "História:";
            // 
            // creatureXpTextBox
            // 
            this.creatureXpTextBox.Location = new System.Drawing.Point(384, 62);
            this.creatureXpTextBox.Name = "creatureXpTextBox";
            this.creatureXpTextBox.Size = new System.Drawing.Size(100, 20);
            this.creatureXpTextBox.TabIndex = 67;
            // 
            // creatureLvlTextBox
            // 
            this.creatureLvlTextBox.Location = new System.Drawing.Point(127, 60);
            this.creatureLvlTextBox.Name = "creatureLvlTextBox";
            this.creatureLvlTextBox.Size = new System.Drawing.Size(100, 20);
            this.creatureLvlTextBox.TabIndex = 66;
            // 
            // creatureLvlLabel
            // 
            this.creatureLvlLabel.AutoSize = true;
            this.creatureLvlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureLvlLabel.Location = new System.Drawing.Point(123, 29);
            this.creatureLvlLabel.Name = "creatureLvlLabel";
            this.creatureLvlLabel.Size = new System.Drawing.Size(57, 24);
            this.creatureLvlLabel.TabIndex = 65;
            this.creatureLvlLabel.Text = "Nível:";
            // 
            // creatureNameTextBox
            // 
            this.creatureNameTextBox.Location = new System.Drawing.Point(17, 60);
            this.creatureNameTextBox.Name = "creatureNameTextBox";
            this.creatureNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.creatureNameTextBox.TabIndex = 64;
            // 
            // creatureHeightTextBox
            // 
            this.creatureHeightTextBox.Location = new System.Drawing.Point(250, 254);
            this.creatureHeightTextBox.Name = "creatureHeightTextBox";
            this.creatureHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.creatureHeightTextBox.TabIndex = 63;
            // 
            // creatureWeightTextBox
            // 
            this.creatureWeightTextBox.Location = new System.Drawing.Point(250, 204);
            this.creatureWeightTextBox.Name = "creatureWeightTextBox";
            this.creatureWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.creatureWeightTextBox.TabIndex = 62;
            // 
            // creatureInfoLabel
            // 
            this.creatureInfoLabel.AutoSize = true;
            this.creatureInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureInfoLabel.Location = new System.Drawing.Point(246, 9);
            this.creatureInfoLabel.Name = "creatureInfoLabel";
            this.creatureInfoLabel.Size = new System.Drawing.Size(205, 24);
            this.creatureInfoLabel.TabIndex = 61;
            this.creatureInfoLabel.Text = "Informações da criatura";
            // 
            // creatureManaTextBox
            // 
            this.creatureManaTextBox.Location = new System.Drawing.Point(250, 154);
            this.creatureManaTextBox.Name = "creatureManaTextBox";
            this.creatureManaTextBox.Size = new System.Drawing.Size(100, 20);
            this.creatureManaTextBox.TabIndex = 60;
            // 
            // creatureLifeTextBox
            // 
            this.creatureLifeTextBox.Location = new System.Drawing.Point(250, 109);
            this.creatureLifeTextBox.Name = "creatureLifeTextBox";
            this.creatureLifeTextBox.Size = new System.Drawing.Size(100, 20);
            this.creatureLifeTextBox.TabIndex = 59;
            // 
            // creatureIdTextBox
            // 
            this.creatureIdTextBox.Location = new System.Drawing.Point(250, 62);
            this.creatureIdTextBox.Name = "creatureIdTextBox";
            this.creatureIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.creatureIdTextBox.TabIndex = 58;
            // 
            // creatureDeleteButton
            // 
            this.creatureDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureDeleteButton.Location = new System.Drawing.Point(250, 373);
            this.creatureDeleteButton.Name = "creatureDeleteButton";
            this.creatureDeleteButton.Size = new System.Drawing.Size(100, 29);
            this.creatureDeleteButton.TabIndex = 57;
            this.creatureDeleteButton.Text = "Deletar criatura";
            this.creatureDeleteButton.UseVisualStyleBackColor = true;
            this.creatureDeleteButton.Click += new System.EventHandler(this.CreatureDeleteButton_Click);
            // 
            // creatureBackgroundRichTextBox
            // 
            this.creatureBackgroundRichTextBox.Location = new System.Drawing.Point(533, 60);
            this.creatureBackgroundRichTextBox.Name = "creatureBackgroundRichTextBox";
            this.creatureBackgroundRichTextBox.Size = new System.Drawing.Size(286, 359);
            this.creatureBackgroundRichTextBox.TabIndex = 56;
            this.creatureBackgroundRichTextBox.Text = "";
            // 
            // creatureIdLabel
            // 
            this.creatureIdLabel.AutoSize = true;
            this.creatureIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureIdLabel.Location = new System.Drawing.Point(246, 35);
            this.creatureIdLabel.Name = "creatureIdLabel";
            this.creatureIdLabel.Size = new System.Drawing.Size(127, 24);
            this.creatureIdLabel.TabIndex = 50;
            this.creatureIdLabel.Text = "ID da Criatura:";
            // 
            // creatureXpLabel
            // 
            this.creatureXpLabel.AutoSize = true;
            this.creatureXpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureXpLabel.Location = new System.Drawing.Point(380, 33);
            this.creatureXpLabel.Name = "creatureXpLabel";
            this.creatureXpLabel.Size = new System.Drawing.Size(41, 24);
            this.creatureXpLabel.TabIndex = 48;
            this.creatureXpLabel.Text = "XP:";
            // 
            // creatureHeightLabel
            // 
            this.creatureHeightLabel.AutoSize = true;
            this.creatureHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureHeightLabel.Location = new System.Drawing.Point(246, 227);
            this.creatureHeightLabel.Name = "creatureHeightLabel";
            this.creatureHeightLabel.Size = new System.Drawing.Size(63, 24);
            this.creatureHeightLabel.TabIndex = 47;
            this.creatureHeightLabel.Text = "Altura:";
            // 
            // creatureWeightLabel
            // 
            this.creatureWeightLabel.AutoSize = true;
            this.creatureWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureWeightLabel.Location = new System.Drawing.Point(246, 177);
            this.creatureWeightLabel.Name = "creatureWeightLabel";
            this.creatureWeightLabel.Size = new System.Drawing.Size(58, 24);
            this.creatureWeightLabel.TabIndex = 46;
            this.creatureWeightLabel.Text = "Peso:";
            // 
            // creatureManaLabel
            // 
            this.creatureManaLabel.AutoSize = true;
            this.creatureManaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureManaLabel.Location = new System.Drawing.Point(246, 127);
            this.creatureManaLabel.Name = "creatureManaLabel";
            this.creatureManaLabel.Size = new System.Drawing.Size(62, 24);
            this.creatureManaLabel.TabIndex = 45;
            this.creatureManaLabel.Text = "Mana:";
            // 
            // creatureLifeLabel
            // 
            this.creatureLifeLabel.AutoSize = true;
            this.creatureLifeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureLifeLabel.Location = new System.Drawing.Point(246, 82);
            this.creatureLifeLabel.Name = "creatureLifeLabel";
            this.creatureLifeLabel.Size = new System.Drawing.Size(53, 24);
            this.creatureLifeLabel.TabIndex = 44;
            this.creatureLifeLabel.Text = "Vida:";
            // 
            // creatureNameLabel
            // 
            this.creatureNameLabel.AutoSize = true;
            this.creatureNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureNameLabel.Location = new System.Drawing.Point(13, 29);
            this.creatureNameLabel.Name = "creatureNameLabel";
            this.creatureNameLabel.Size = new System.Drawing.Size(67, 24);
            this.creatureNameLabel.TabIndex = 43;
            this.creatureNameLabel.Text = "Nome:";
            // 
            // creatureImagePictureBox
            // 
            this.creatureImagePictureBox.Location = new System.Drawing.Point(17, 86);
            this.creatureImagePictureBox.Name = "creatureImagePictureBox";
            this.creatureImagePictureBox.Size = new System.Drawing.Size(210, 328);
            this.creatureImagePictureBox.TabIndex = 42;
            this.creatureImagePictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(744, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 81;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Bestiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.creatureUpdateButton);
            this.Controls.Add(this.creatureCreateButton);
            this.Controls.Add(this.creatureSearchLabel);
            this.Controls.Add(this.creatureSearchButton);
            this.Controls.Add(this.c);
            this.Controls.Add(this.creatureBackgroundLabel);
            this.Controls.Add(this.creatureXpTextBox);
            this.Controls.Add(this.creatureLvlTextBox);
            this.Controls.Add(this.creatureLvlLabel);
            this.Controls.Add(this.creatureNameTextBox);
            this.Controls.Add(this.creatureHeightTextBox);
            this.Controls.Add(this.creatureWeightTextBox);
            this.Controls.Add(this.creatureInfoLabel);
            this.Controls.Add(this.creatureManaTextBox);
            this.Controls.Add(this.creatureLifeTextBox);
            this.Controls.Add(this.creatureIdTextBox);
            this.Controls.Add(this.creatureDeleteButton);
            this.Controls.Add(this.creatureBackgroundRichTextBox);
            this.Controls.Add(this.creatureIdLabel);
            this.Controls.Add(this.creatureXpLabel);
            this.Controls.Add(this.creatureHeightLabel);
            this.Controls.Add(this.creatureWeightLabel);
            this.Controls.Add(this.creatureManaLabel);
            this.Controls.Add(this.creatureLifeLabel);
            this.Controls.Add(this.creatureNameLabel);
            this.Controls.Add(this.creatureImagePictureBox);
            this.Name = "Bestiario";
            this.Text = "Bestiario";
            this.Load += new System.EventHandler(this.Bestiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.creatureImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button creatureUpdateButton;
        private System.Windows.Forms.Button creatureCreateButton;
        private System.Windows.Forms.Label creatureSearchLabel;
        private System.Windows.Forms.Button creatureSearchButton;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.Label creatureBackgroundLabel;
        private System.Windows.Forms.TextBox creatureXpTextBox;
        private System.Windows.Forms.TextBox creatureLvlTextBox;
        private System.Windows.Forms.Label creatureLvlLabel;
        private System.Windows.Forms.TextBox creatureNameTextBox;
        private System.Windows.Forms.TextBox creatureHeightTextBox;
        private System.Windows.Forms.TextBox creatureWeightTextBox;
        private System.Windows.Forms.Label creatureInfoLabel;
        private System.Windows.Forms.TextBox creatureManaTextBox;
        private System.Windows.Forms.TextBox creatureLifeTextBox;
        private System.Windows.Forms.TextBox creatureIdTextBox;
        private System.Windows.Forms.Button creatureDeleteButton;
        private System.Windows.Forms.RichTextBox creatureBackgroundRichTextBox;
        private System.Windows.Forms.Label creatureIdLabel;
        private System.Windows.Forms.Label creatureXpLabel;
        private System.Windows.Forms.Label creatureHeightLabel;
        private System.Windows.Forms.Label creatureWeightLabel;
        private System.Windows.Forms.Label creatureManaLabel;
        private System.Windows.Forms.Label creatureLifeLabel;
        private System.Windows.Forms.Label creatureNameLabel;
        private System.Windows.Forms.PictureBox creatureImagePictureBox;
        private System.Windows.Forms.Button button1;
    }
}