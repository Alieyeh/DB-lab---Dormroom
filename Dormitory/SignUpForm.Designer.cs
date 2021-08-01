using System;

namespace Dormitory
{
    partial class SignUpForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FemaleradioButton = new System.Windows.Forms.RadioButton();
            this.MaleradioButton = new System.Windows.Forms.RadioButton();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CodeMelliTtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BirthdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Night = new System.Windows.Forms.RadioButton();
            this.Day = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.LevelComboBox = new System.Windows.Forms.ComboBox();
            this.MajorComboBox = new System.Windows.Forms.ComboBox();
            this.enteryear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(42, 46);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(69, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Full name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(166, 46);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(172, 22);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(42, 74);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(43, 17);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Major";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FemaleradioButton
            // 
            this.FemaleradioButton.AutoSize = true;
            this.FemaleradioButton.Location = new System.Drawing.Point(166, 345);
            this.FemaleradioButton.Name = "FemaleradioButton";
            this.FemaleradioButton.Size = new System.Drawing.Size(75, 21);
            this.FemaleradioButton.TabIndex = 11;
            this.FemaleradioButton.TabStop = true;
            this.FemaleradioButton.Text = "Female";
            this.FemaleradioButton.UseVisualStyleBackColor = true;
            // 
            // MaleradioButton
            // 
            this.MaleradioButton.AutoSize = true;
            this.MaleradioButton.Location = new System.Drawing.Point(279, 345);
            this.MaleradioButton.Name = "MaleradioButton";
            this.MaleradioButton.Size = new System.Drawing.Size(59, 21);
            this.MaleradioButton.TabIndex = 12;
            this.MaleradioButton.TabStop = true;
            this.MaleradioButton.Text = "Male";
            this.MaleradioButton.UseVisualStyleBackColor = true;
            this.MaleradioButton.CheckedChanged += new System.EventHandler(this.MaleradioButton_CheckedChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(166, 135);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(172, 22);
            this.PasswordTextBox.TabIndex = 16;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Password";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(166, 250);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(351, 22);
            this.AddressTextBox.TabIndex = 20;
            this.AddressTextBox.UseSystemPasswordChar = true;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Address";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CodeMelliTtextBox
            // 
            this.CodeMelliTtextBox.Location = new System.Drawing.Point(166, 163);
            this.CodeMelliTtextBox.Name = "CodeMelliTtextBox";
            this.CodeMelliTtextBox.Size = new System.Drawing.Size(172, 22);
            this.CodeMelliTtextBox.TabIndex = 18;
            this.CodeMelliTtextBox.TextChanged += new System.EventHandler(this.CodeMelliTtextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "CodeMelli";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(166, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 55);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "select gender";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BirthdateTimePicker
            // 
            this.BirthdateTimePicker.Location = new System.Drawing.Point(166, 497);
            this.BirthdateTimePicker.Name = "BirthdateTimePicker";
            this.BirthdateTimePicker.Size = new System.Drawing.Size(263, 22);
            this.BirthdateTimePicker.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "BirthDate";
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.SignUpButton.Location = new System.Drawing.Point(466, 511);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(75, 33);
            this.SignUpButton.TabIndex = 26;
            this.SignUpButton.Text = "sign up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 304);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 22);
            this.textBox1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Email";
            // 
            // StudentNumber
            // 
            this.StudentNumber.Location = new System.Drawing.Point(166, 191);
            this.StudentNumber.Name = "StudentNumber";
            this.StudentNumber.Size = new System.Drawing.Size(172, 22);
            this.StudentNumber.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Student Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Enterance year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Level";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 464);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 22);
            this.textBox3.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 467);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Phone Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 17);
            this.label12.TabIndex = 39;
            this.label12.Text = "Type";
            // 
            // Night
            // 
            this.Night.AutoSize = true;
            this.Night.Location = new System.Drawing.Point(279, 433);
            this.Night.Name = "Night";
            this.Night.Size = new System.Drawing.Size(62, 21);
            this.Night.TabIndex = 40;
            this.Night.TabStop = true;
            this.Night.Text = "Night";
            this.Night.UseVisualStyleBackColor = true;
            this.Night.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Location = new System.Drawing.Point(166, 435);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(54, 21);
            this.Day.TabIndex = 41;
            this.Day.TabStop = true;
            this.Day.Text = "Day";
            this.Day.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 17);
            this.label13.TabIndex = 43;
            this.label13.Text = "City";
            // 
            // CityComboBox
            // 
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(166, 278);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(121, 24);
            this.CityComboBox.TabIndex = 48;
            // 
            // LevelComboBox
            // 
            this.LevelComboBox.FormattingEnabled = true;
            this.LevelComboBox.Location = new System.Drawing.Point(166, 107);
            this.LevelComboBox.Name = "LevelComboBox";
            this.LevelComboBox.Size = new System.Drawing.Size(121, 24);
            this.LevelComboBox.TabIndex = 52;
            // 
            // MajorComboBox
            // 
            this.MajorComboBox.FormattingEnabled = true;
            this.MajorComboBox.Location = new System.Drawing.Point(166, 77);
            this.MajorComboBox.Name = "MajorComboBox";
            this.MajorComboBox.Size = new System.Drawing.Size(121, 24);
            this.MajorComboBox.TabIndex = 51;
            // 
            // enteryear
            // 
            this.enteryear.Location = new System.Drawing.Point(166, 222);
            this.enteryear.Name = "enteryear";
            this.enteryear.Size = new System.Drawing.Size(172, 22);
            this.enteryear.TabIndex = 53;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 556);
            this.Controls.Add(this.enteryear);
            this.Controls.Add(this.LevelComboBox);
            this.Controls.Add(this.MajorComboBox);
            this.Controls.Add(this.CityComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Night);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StudentNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaleradioButton);
            this.Controls.Add(this.FemaleradioButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BirthdateTimePicker);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CodeMelliTtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton FemaleradioButton;
        private System.Windows.Forms.RadioButton MaleradioButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CodeMelliTtextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker BirthdateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StudentNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton Night;
        private System.Windows.Forms.RadioButton Day;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.ComboBox LevelComboBox;
        private System.Windows.Forms.ComboBox MajorComboBox;
        private System.Windows.Forms.TextBox enteryear;

        public EventHandler SignUpForm_load { get; private set; }
    }
}