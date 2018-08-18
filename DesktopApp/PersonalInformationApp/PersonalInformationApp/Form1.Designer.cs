namespace PersonalInformationApp
{
    partial class Form1
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.FatherNamelabel = new System.Windows.Forms.Label();
            this.MotherNameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFather = new System.Windows.Forms.TextBox();
            this.textBoxMotherName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Information";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(59, 67);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(58, 114);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name";
            // 
            // FatherNamelabel
            // 
            this.FatherNamelabel.AutoSize = true;
            this.FatherNamelabel.Location = new System.Drawing.Point(58, 149);
            this.FatherNamelabel.Name = "FatherNamelabel";
            this.FatherNamelabel.Size = new System.Drawing.Size(75, 13);
            this.FatherNamelabel.TabIndex = 0;
            this.FatherNamelabel.Text = "Father\'s Name";
            // 
            // MotherNameLabel
            // 
            this.MotherNameLabel.AutoSize = true;
            this.MotherNameLabel.Location = new System.Drawing.Point(59, 197);
            this.MotherNameLabel.Name = "MotherNameLabel";
            this.MotherNameLabel.Size = new System.Drawing.Size(78, 13);
            this.MotherNameLabel.TabIndex = 0;
            this.MotherNameLabel.Text = "Mother\'s Name";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(58, 246);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 0;
            this.AddressLabel.Text = "Address";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(155, 64);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(415, 33);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(155, 103);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(415, 33);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxFather
            // 
            this.textBoxFather.Location = new System.Drawing.Point(155, 146);
            this.textBoxFather.Multiline = true;
            this.textBoxFather.Name = "textBoxFather";
            this.textBoxFather.Size = new System.Drawing.Size(415, 33);
            this.textBoxFather.TabIndex = 1;
            // 
            // textBoxMotherName
            // 
            this.textBoxMotherName.Location = new System.Drawing.Point(155, 194);
            this.textBoxMotherName.Multiline = true;
            this.textBoxMotherName.Name = "textBoxMotherName";
            this.textBoxMotherName.Size = new System.Drawing.Size(415, 33);
            this.textBoxMotherName.TabIndex = 1;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(155, 243);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(415, 109);
            this.textBoxAddress.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Parent\'s Name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.parentNameClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show All Information";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.showInfoClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(155, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(155, 372);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SaveClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(155, 401);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Name";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.nameButtonClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(460, 401);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Address";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.addressClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxMotherName);
            this.Controls.Add(this.textBoxFather);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.MotherNameLabel);
            this.Controls.Add(this.FatherNamelabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label FatherNamelabel;
        private System.Windows.Forms.Label MotherNameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFather;
        private System.Windows.Forms.TextBox textBoxMotherName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

