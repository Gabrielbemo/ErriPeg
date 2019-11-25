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
            this.button1 = new System.Windows.Forms.Button();
            this.SessionPasswordTextBox = new System.Windows.Forms.TextBox();
            this.sessionPasswordLabel = new System.Windows.Forms.Label();
            this.sessionNameTextBox = new System.Windows.Forms.TextBox();
            this.createSessionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create Session";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SessionPasswordTextBox
            // 
            this.SessionPasswordTextBox.Location = new System.Drawing.Point(75, 189);
            this.SessionPasswordTextBox.Name = "SessionPasswordTextBox";
            this.SessionPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.SessionPasswordTextBox.TabIndex = 8;
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
            // CriarSessão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SessionPasswordTextBox);
            this.Controls.Add(this.sessionPasswordLabel);
            this.Controls.Add(this.sessionNameTextBox);
            this.Controls.Add(this.createSessionLabel);
            this.Name = "CriarSessão";
            this.Text = "CriarSessão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SessionPasswordTextBox;
        private System.Windows.Forms.Label sessionPasswordLabel;
        private System.Windows.Forms.TextBox sessionNameTextBox;
        private System.Windows.Forms.Label createSessionLabel;
    }
}