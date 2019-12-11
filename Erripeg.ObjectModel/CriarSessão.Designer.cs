namespace Erripeg.ObjectModel
{
    partial class CriarSessão
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
            this.createSessionButton = new System.Windows.Forms.Button();
            this.sessionNameTextBox = new System.Windows.Forms.TextBox();
            this.createSessionLabel = new System.Windows.Forms.Label();
            this.sessionStoryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sessionStoryLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createSessionButton
            // 
            this.createSessionButton.Location = new System.Drawing.Point(75, 291);
            this.createSessionButton.Name = "createSessionButton";
            this.createSessionButton.Size = new System.Drawing.Size(100, 23);
            this.createSessionButton.TabIndex = 9;
            this.createSessionButton.Text = "Create Session";
            this.createSessionButton.UseVisualStyleBackColor = true;
            this.createSessionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // sessionNameTextBox
            // 
            this.sessionNameTextBox.Location = new System.Drawing.Point(58, 86);
            this.sessionNameTextBox.Name = "sessionNameTextBox";
            this.sessionNameTextBox.Size = new System.Drawing.Size(131, 20);
            this.sessionNameTextBox.TabIndex = 6;
            // 
            // createSessionLabel
            // 
            this.createSessionLabel.AutoSize = true;
            this.createSessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSessionLabel.Location = new System.Drawing.Point(54, 59);
            this.createSessionLabel.Name = "createSessionLabel";
            this.createSessionLabel.Size = new System.Drawing.Size(135, 24);
            this.createSessionLabel.TabIndex = 5;
            this.createSessionLabel.Text = "Session name:";
            // 
            // sessionStoryRichTextBox
            // 
            this.sessionStoryRichTextBox.Location = new System.Drawing.Point(199, 86);
            this.sessionStoryRichTextBox.Name = "sessionStoryRichTextBox";
            this.sessionStoryRichTextBox.Size = new System.Drawing.Size(206, 243);
            this.sessionStoryRichTextBox.TabIndex = 10;
            this.sessionStoryRichTextBox.Text = "";
            // 
            // sessionStoryLabel
            // 
            this.sessionStoryLabel.AutoSize = true;
            this.sessionStoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionStoryLabel.Location = new System.Drawing.Point(195, 59);
            this.sessionStoryLabel.Name = "sessionStoryLabel";
            this.sessionStoryLabel.Size = new System.Drawing.Size(129, 24);
            this.sessionStoryLabel.TabIndex = 11;
            this.sessionStoryLabel.Text = "Session Story:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(58, 180);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 28);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Sou Mestre?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // CriarSessão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.sessionStoryLabel);
            this.Controls.Add(this.sessionStoryRichTextBox);
            this.Controls.Add(this.createSessionButton);
            this.Controls.Add(this.sessionNameTextBox);
            this.Controls.Add(this.createSessionLabel);
            this.Name = "CriarSessão";
            this.Text = "CriarSessão";
            this.Load += new System.EventHandler(this.CriarSessão_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createSessionButton;
        private System.Windows.Forms.TextBox sessionNameTextBox;
        private System.Windows.Forms.Label createSessionLabel;
        private System.Windows.Forms.RichTextBox sessionStoryRichTextBox;
        private System.Windows.Forms.Label sessionStoryLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}