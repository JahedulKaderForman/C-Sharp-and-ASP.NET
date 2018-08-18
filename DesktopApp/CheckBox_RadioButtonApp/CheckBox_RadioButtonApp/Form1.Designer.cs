namespace CheckBox_RadioButtonApp
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
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.panelColor = new System.Windows.Forms.Panel();
            this.ColorButton = new System.Windows.Forms.Button();
            this.cityList = new System.Windows.Forms.ListBox();
            this.checkBoxCoxBazar = new System.Windows.Forms.CheckBox();
            this.checkBoxDhakha = new System.Windows.Forms.CheckBox();
            this.checkBoxChittagong = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(60, 204);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(54, 17);
            this.radioButtonGreen.TabIndex = 1;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(60, 181);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(45, 17);
            this.radioButtonRed.TabIndex = 1;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(188, 84);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(146, 100);
            this.panelColor.TabIndex = 3;
            // 
            // ColorButton
            // 
            this.ColorButton.BackColor = System.Drawing.Color.PapayaWhip;
            this.ColorButton.Location = new System.Drawing.Point(226, 204);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(75, 36);
            this.ColorButton.TabIndex = 4;
            this.ColorButton.Text = "Color submit";
            this.ColorButton.UseVisualStyleBackColor = false;
            this.ColorButton.Click += new System.EventHandler(this.colorSubmit);
            // 
            // cityList
            // 
            this.cityList.BackColor = System.Drawing.SystemColors.Info;
            this.cityList.FormattingEnabled = true;
            this.cityList.HorizontalScrollbar = true;
            this.cityList.Location = new System.Drawing.Point(440, 84);
            this.cityList.Name = "cityList";
            this.cityList.Size = new System.Drawing.Size(201, 147);
            this.cityList.TabIndex = 5;
            // 
            // checkBoxCoxBazar
            // 
            this.checkBoxCoxBazar.AutoSize = true;
            this.checkBoxCoxBazar.Location = new System.Drawing.Point(60, 129);
            this.checkBoxCoxBazar.Name = "checkBoxCoxBazar";
            this.checkBoxCoxBazar.Size = new System.Drawing.Size(71, 17);
            this.checkBoxCoxBazar.TabIndex = 0;
            this.checkBoxCoxBazar.Text = "CoxBazar";
            this.checkBoxCoxBazar.UseVisualStyleBackColor = true;
            this.checkBoxCoxBazar.CheckedChanged += new System.EventHandler(this.updateLabelCoxbazar);
            // 
            // checkBoxDhakha
            // 
            this.checkBoxDhakha.AutoSize = true;
            this.checkBoxDhakha.Location = new System.Drawing.Point(60, 83);
            this.checkBoxDhakha.Name = "checkBoxDhakha";
            this.checkBoxDhakha.Size = new System.Drawing.Size(58, 17);
            this.checkBoxDhakha.TabIndex = 0;
            this.checkBoxDhakha.Text = "Dhaka";
            this.checkBoxDhakha.UseVisualStyleBackColor = true;
            this.checkBoxDhakha.CheckedChanged += new System.EventHandler(this.updateLabelDhaka);
            // 
            // checkBoxChittagong
            // 
            this.checkBoxChittagong.AutoSize = true;
            this.checkBoxChittagong.Location = new System.Drawing.Point(60, 106);
            this.checkBoxChittagong.Name = "checkBoxChittagong";
            this.checkBoxChittagong.Size = new System.Drawing.Size(77, 17);
            this.checkBoxChittagong.TabIndex = 0;
            this.checkBoxChittagong.Text = "Chittagong";
            this.checkBoxChittagong.UseVisualStyleBackColor = true;
            this.checkBoxChittagong.CheckedChanged += new System.EventHandler(this.updatelabelChittagong);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selected City";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityList);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.radioButtonRed);
            this.Controls.Add(this.radioButtonGreen);
            this.Controls.Add(this.checkBoxDhakha);
            this.Controls.Add(this.checkBoxChittagong);
            this.Controls.Add(this.checkBoxCoxBazar);
            this.Name = "Form1";
            this.Text = "CheckBox And RadioButton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.ListBox cityList;
        private System.Windows.Forms.CheckBox checkBoxCoxBazar;
        private System.Windows.Forms.CheckBox checkBoxDhakha;
        private System.Windows.Forms.CheckBox checkBoxChittagong;
        private System.Windows.Forms.Label label1;
    }
}

