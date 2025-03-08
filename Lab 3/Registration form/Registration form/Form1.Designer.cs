namespace Registration_form
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
            this.f_name_input = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.Button();
            this.lname = new System.Windows.Forms.Button();
            this.l_name_input = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Button();
            this.email_input = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Button();
            this.password_input = new System.Windows.Forms.TextBox();
            this.cpassword = new System.Windows.Forms.Button();
            this.c_password_input = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.other = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.countries = new System.Windows.Forms.ComboBox();
            this.terms = new System.Windows.Forms.CheckBox();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // f_name_input
            // 
            this.f_name_input.Location = new System.Drawing.Point(126, 47);
            this.f_name_input.Name = "f_name_input";
            this.f_name_input.Size = new System.Drawing.Size(146, 20);
            this.f_name_input.TabIndex = 0;
            this.f_name_input.TextChanged += new System.EventHandler(this.f_name_input_TextChanged);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(45, 45);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(75, 23);
            this.fname.TabIndex = 1;
            this.fname.Text = "First Name";
            this.fname.UseVisualStyleBackColor = true;
            this.fname.Click += new System.EventHandler(this.fname_Click);
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(45, 70);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(75, 23);
            this.lname.TabIndex = 3;
            this.lname.Text = "Last Name";
            this.lname.UseVisualStyleBackColor = true;
            this.lname.Click += new System.EventHandler(this.lname_Click);
            // 
            // l_name_input
            // 
            this.l_name_input.Location = new System.Drawing.Point(126, 73);
            this.l_name_input.Name = "l_name_input";
            this.l_name_input.Size = new System.Drawing.Size(146, 20);
            this.l_name_input.TabIndex = 2;
            this.l_name_input.TextChanged += new System.EventHandler(this.l_name_input_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(45, 99);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(75, 23);
            this.email.TabIndex = 5;
            this.email.Text = "Email";
            this.email.UseVisualStyleBackColor = true;
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(126, 99);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(146, 20);
            this.email_input.TabIndex = 4;
            this.email_input.TextChanged += new System.EventHandler(this.email_input_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(45, 125);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(75, 23);
            this.password.TabIndex = 7;
            this.password.Text = "Password";
            this.password.UseVisualStyleBackColor = true;
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(126, 125);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(146, 20);
            this.password_input.TabIndex = 6;
            this.password_input.TextChanged += new System.EventHandler(this.password_input_TextChanged);
            // 
            // cpassword
            // 
            this.cpassword.Location = new System.Drawing.Point(45, 151);
            this.cpassword.Name = "cpassword";
            this.cpassword.Size = new System.Drawing.Size(119, 23);
            this.cpassword.TabIndex = 9;
            this.cpassword.Text = "Confirm Password";
            this.cpassword.UseVisualStyleBackColor = true;
            this.cpassword.Click += new System.EventHandler(this.cpassword_Click);
            // 
            // c_password_input
            // 
            this.c_password_input.Location = new System.Drawing.Point(170, 151);
            this.c_password_input.Name = "c_password_input";
            this.c_password_input.Size = new System.Drawing.Size(102, 20);
            this.c_password_input.TabIndex = 8;
            this.c_password_input.TextChanged += new System.EventHandler(this.c_password_input_TextChanged);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(67, 180);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(48, 17);
            this.male.TabIndex = 10;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.Location = new System.Drawing.Point(205, 180);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(51, 17);
            this.other.TabIndex = 12;
            this.other.TabStop = true;
            this.other.Text = "Other";
            this.other.UseVisualStyleBackColor = true;
            this.other.CheckedChanged += new System.EventHandler(this.other_CheckedChanged);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(131, 180);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 13;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // countries
            // 
            this.countries.FormattingEnabled = true;
            this.countries.Location = new System.Drawing.Point(45, 203);
            this.countries.Name = "countries";
            this.countries.Size = new System.Drawing.Size(227, 21);
            this.countries.TabIndex = 14;
            this.countries.SelectedIndexChanged += new System.EventHandler(this.countries_SelectedIndexChanged);
            // 
            // terms
            // 
            this.terms.AutoSize = true;
            this.terms.Location = new System.Drawing.Point(45, 231);
            this.terms.Name = "terms";
            this.terms.Size = new System.Drawing.Size(208, 17);
            this.terms.TabIndex = 15;
            this.terms.Text = "check to accept the Terms & conditions";
            this.terms.UseVisualStyleBackColor = true;
            this.terms.CheckedChanged += new System.EventHandler(this.terms_CheckedChanged);
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(115, 254);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 16;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 285);
            this.Controls.Add(this.register);
            this.Controls.Add(this.terms);
            this.Controls.Add(this.countries);
            this.Controls.Add(this.female);
            this.Controls.Add(this.other);
            this.Controls.Add(this.male);
            this.Controls.Add(this.cpassword);
            this.Controls.Add(this.c_password_input);
            this.Controls.Add(this.password);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.email);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.l_name_input);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.f_name_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox f_name_input;
        private System.Windows.Forms.Button fname;
        private System.Windows.Forms.Button lname;
        private System.Windows.Forms.TextBox l_name_input;
        private System.Windows.Forms.Button email;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.Button password;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Button cpassword;
        private System.Windows.Forms.TextBox c_password_input;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton other;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.ComboBox countries;
        private System.Windows.Forms.CheckBox terms;
        private System.Windows.Forms.Button register;
    }
}

