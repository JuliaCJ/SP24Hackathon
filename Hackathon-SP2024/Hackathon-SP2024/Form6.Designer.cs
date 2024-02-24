namespace Hackathon_SP2024
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PersonButton = new System.Windows.Forms.Button();
            this.HelperButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome! ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please create the account the best applies to you!";
            // 
            // PersonButton
            // 
            this.PersonButton.Location = new System.Drawing.Point(326, 188);
            this.PersonButton.Name = "PersonButton";
            this.PersonButton.Size = new System.Drawing.Size(132, 23);
            this.PersonButton.TabIndex = 2;
            this.PersonButton.Text = "Person in Need";
            this.PersonButton.UseVisualStyleBackColor = true;
            this.PersonButton.Click += new System.EventHandler(this.PersonButton_Click);
            // 
            // HelperButton
            // 
            this.HelperButton.Location = new System.Drawing.Point(326, 230);
            this.HelperButton.Name = "HelperButton";
            this.HelperButton.Size = new System.Drawing.Size(122, 23);
            this.HelperButton.TabIndex = 3;
            this.HelperButton.Text = "Help Provider";
            this.HelperButton.UseVisualStyleBackColor = true;
            this.HelperButton.Click += new System.EventHandler(this.HelperButton_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 468);
            this.Controls.Add(this.HelperButton);
            this.Controls.Add(this.PersonButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PersonButton;
        private System.Windows.Forms.Button HelperButton;
    }
}