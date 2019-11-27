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
            this.sessionPasswordTextBox = new System.Windows.Forms.TextBox();
            this.sessionPasswordLabel = new System.Windows.Forms.Label();
            this.sessionNameTextBox = new System.Windows.Forms.TextBox();
            this.createSessionLabel = new System.Windows.Forms.Label();
            this.sessionStoryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sessionStoryLabel = new System.Windows.Forms.Label();
            this.selectSessionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createSessionButton
            // 
            this.createSessionButton.Location = new System.Drawing.Point(75, 306);
            this.createSessionButton.Name = "createSessionButton";
            this.createSessionButton.Size = new System.Drawing.Size(100, 23);
            this.createSessionButton.TabIndex = 9;
            this.createSessionButton.Text = "Create Session";
            this.createSessionButton.UseVisualStyleBackColor = true;
            this.createSessionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // sessionPasswordTextBox
            // 
            this.sessionPasswordTextBox.Location = new System.Drawing.Point(75, 189);
            this.sessionPasswordTextBox.Name = "sessionPasswordTextBox";
            this.sessionPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.sessionPasswordTextBox.TabIndex = 8;
            // 
            // sessionPasswordLabel
            // 
            this.sessionPasswordLabel.AutoSize = true;
            this.sessionPasswordLabel.Location = new System.Drawing.Point(72, 173);
            this.sessionPasswordLabel.Name = "sessionPasswordLabel";
            this.sessionPasswordLabel.Size = new System.Drawing.Size(95, 13);
            this.sessionPasswordLabel.TabIndex = 7;
            this.sessionPasswordLabel.Text = "Session password:";
            // 
            // sessionNameTextBox
            // 
            this.sessionNameTextBox.Location = new System.Drawing.Point(75, 89);
            this.sessionNameTextBox.Name = "sessionNameTextBox";
            this.sessionNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.sessionNameTextBox.TabIndex = 6;
            // 
            // createSessionLabel
            // 
            this.createSessionLabel.AutoSize = true;
            this.createSessionLabel.Location = new System.Drawing.Point(72, 73);
            this.createSessionLabel.Name = "createSessionLabel";
            this.createSessionLabel.Size = new System.Drawing.Size(76, 13);
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
            this.sessionStoryLabel.Location = new System.Drawing.Point(196, 70);
            this.sessionStoryLabel.Name = "sessionStoryLabel";
            this.sessionStoryLabel.Size = new System.Drawing.Size(74, 13);
            this.sessionStoryLabel.TabIndex = 11;
            this.sessionStoryLabel.Text = "Session Story:";
            // 
            // selectSessionButton
            // 
            this.selectSessionButton.Location = new System.Drawing.Point(75, 277);
            this.selectSessionButton.Name = "selectSessionButton";
            this.selectSessionButton.Size = new System.Drawing.Size(100, 23);
            this.selectSessionButton.TabIndex = 12;
            this.selectSessionButton.Text = "Select Session";
            this.selectSessionButton.UseVisualStyleBackColor = true;
            this.selectSessionButton.Click += new System.EventHandler(this.selectSessionButton_Click);
            // 
            // CriarSessão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 412);
            this.Controls.Add(this.selectSessionButton);
            this.Controls.Add(this.sessionStoryLabel);
            this.Controls.Add(this.sessionStoryRichTextBox);
            this.Controls.Add(this.createSessionButton);
            this.Controls.Add(this.sessionPasswordTextBox);
            this.Controls.Add(this.sessionPasswordLabel);
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
        private System.Windows.Forms.TextBox sessionPasswordTextBox;
        private System.Windows.Forms.Label sessionPasswordLabel;
        private System.Windows.Forms.TextBox sessionNameTextBox;
        private System.Windows.Forms.Label createSessionLabel;
        private System.Windows.Forms.RichTextBox sessionStoryRichTextBox;
        private System.Windows.Forms.Label sessionStoryLabel;
        private System.Windows.Forms.Button selectSessionButton;
    }
}