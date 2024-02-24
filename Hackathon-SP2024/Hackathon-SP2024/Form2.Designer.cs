namespace Hackathon_SP2024
{
    partial class Form2
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
            this.HelloLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Shelter = new System.Windows.Forms.CheckBox();
            this.Haven = new System.Windows.Forms.CheckBox();
            this.Bank = new System.Windows.Forms.CheckBox();
            this.Rehab = new System.Windows.Forms.CheckBox();
            this.Medical = new System.Windows.Forms.CheckBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(352, 11);
            this.HelloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(45, 16);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "Hello, ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "What do you need help finding today?";
            // 
            // Shelter
            // 
            this.Shelter.AutoSize = true;
            this.Shelter.Location = new System.Drawing.Point(309, 164);
            this.Shelter.Margin = new System.Windows.Forms.Padding(4);
            this.Shelter.Name = "Shelter";
            this.Shelter.Size = new System.Drawing.Size(136, 20);
            this.Shelter.TabIndex = 2;
            this.Shelter.Text = "Homeless Shelter";
            this.Shelter.UseVisualStyleBackColor = true;
            // 
            // Haven
            // 
            this.Haven.AutoSize = true;
            this.Haven.Location = new System.Drawing.Point(309, 192);
            this.Haven.Margin = new System.Windows.Forms.Padding(4);
            this.Haven.Name = "Haven";
            this.Haven.Size = new System.Drawing.Size(100, 20);
            this.Haven.TabIndex = 3;
            this.Haven.Text = "Safe Haven";
            this.Haven.UseVisualStyleBackColor = true;
            // 
            // Bank
            // 
            this.Bank.AutoSize = true;
            this.Bank.Location = new System.Drawing.Point(309, 220);
            this.Bank.Margin = new System.Windows.Forms.Padding(4);
            this.Bank.Name = "Bank";
            this.Bank.Size = new System.Drawing.Size(95, 20);
            this.Bank.TabIndex = 4;
            this.Bank.Text = "Food Bank";
            this.Bank.UseVisualStyleBackColor = true;
            // 
            // Rehab
            // 
            this.Rehab.AutoSize = true;
            this.Rehab.Location = new System.Drawing.Point(309, 250);
            this.Rehab.Margin = new System.Windows.Forms.Padding(4);
            this.Rehab.Name = "Rehab";
            this.Rehab.Size = new System.Drawing.Size(125, 20);
            this.Rehab.TabIndex = 5;
            this.Rehab.Text = "Rehab Program";
            this.Rehab.UseVisualStyleBackColor = true;
            // 
            // Medical
            // 
            this.Medical.AutoSize = true;
            this.Medical.Location = new System.Drawing.Point(309, 279);
            this.Medical.Margin = new System.Windows.Forms.Padding(4);
            this.Medical.Name = "Medical";
            this.Medical.Size = new System.Drawing.Size(121, 20);
            this.Medical.TabIndex = 6;
            this.Medical.Text = "Medical Station";
            this.Medical.UseVisualStyleBackColor = true;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(313, 346);
            this.FindButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(100, 28);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Search";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Please enter your current city: ";
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(428, 63);
            this.CityBox.Margin = new System.Windows.Forms.Padding(4);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(132, 22);
            this.CityBox.TabIndex = 9;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(16, 5);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(131, 28);
            this.EditButton.TabIndex = 10;
            this.EditButton.Text = "Edit Account";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(667, 5);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(100, 28);
            this.LogoutButton.TabIndex = 11;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 468);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.Medical);
            this.Controls.Add(this.Rehab);
            this.Controls.Add(this.Bank);
            this.Controls.Add(this.Haven);
            this.Controls.Add(this.Shelter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HelloLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
 
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Shelter;
        private System.Windows.Forms.CheckBox Haven;
        private System.Windows.Forms.CheckBox Bank;
        private System.Windows.Forms.CheckBox Rehab;
        private System.Windows.Forms.CheckBox Medical;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}