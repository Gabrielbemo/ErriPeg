namespace Erripeg.ObjectModel
{
    partial class SelectSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectSession));
            this.selectSessionLabel = new System.Windows.Forms.Label();
            this.createSessionButton = new System.Windows.Forms.Button();
            this.SessionDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SessionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // selectSessionLabel
            // 
            this.selectSessionLabel.AutoSize = true;
            this.selectSessionLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectSessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSessionLabel.ForeColor = System.Drawing.Color.Black;
            this.selectSessionLabel.Location = new System.Drawing.Point(430, 30);
            this.selectSessionLabel.Name = "selectSessionLabel";
            this.selectSessionLabel.Size = new System.Drawing.Size(169, 24);
            this.selectSessionLabel.TabIndex = 1;
            this.selectSessionLabel.Text = "Selecionar sessão:";
            // 
            // createSessionButton
            // 
            this.createSessionButton.BackColor = System.Drawing.SystemColors.Control;
            this.createSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createSessionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSessionButton.ForeColor = System.Drawing.Color.Black;
            this.createSessionButton.Location = new System.Drawing.Point(430, 505);
            this.createSessionButton.Name = "createSessionButton";
            this.createSessionButton.Size = new System.Drawing.Size(169, 36);
            this.createSessionButton.TabIndex = 3;
            this.createSessionButton.Text = "Criar Sessão";
            this.createSessionButton.UseVisualStyleBackColor = false;
            this.createSessionButton.Click += new System.EventHandler(this.CreateSessionButton_Click);
            // 
            // SessionDataGridView
            // 
            this.SessionDataGridView.AllowUserToAddRows = false;
            this.SessionDataGridView.AllowUserToDeleteRows = false;
            this.SessionDataGridView.AllowUserToOrderColumns = true;
            this.SessionDataGridView.AllowUserToResizeColumns = false;
            this.SessionDataGridView.Location = new System.Drawing.Point(129, 194);
            this.SessionDataGridView.Name = "SessionDataGridView";
            this.SessionDataGridView.Size = new System.Drawing.Size(776, 295);
            this.SessionDataGridView.TabIndex = 0;
            this.SessionDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SessionDataGridView_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(952, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Deslogar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // SelectSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1039, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SessionDataGridView);
            this.Controls.Add(this.createSessionButton);
            this.Controls.Add(this.selectSessionLabel);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectSession";
            this.Load += new System.EventHandler(this.SelectSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SessionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectSessionLabel;
        private System.Windows.Forms.Button createSessionButton;
        private System.Windows.Forms.DataGridView SessionDataGridView;
        private System.Windows.Forms.Button button1;
    }
}