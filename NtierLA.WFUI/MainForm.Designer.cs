namespace NtierLA.WFUI
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_list = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_newcontact = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_website = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_telephone3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_telephone2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_telephone1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_definition = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_jsongive = new System.Windows.Forms.Button();
            this.button_csvgive = new System.Windows.Forms.Button();
            this.button_xmlgive = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_list);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 556);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contacts List";
            // 
            // lst_list
            // 
            this.lst_list.FormattingEnabled = true;
            this.lst_list.Location = new System.Drawing.Point(7, 20);
            this.lst_list.Name = "lst_list";
            this.lst_list.Size = new System.Drawing.Size(212, 524);
            this.lst_list.TabIndex = 0;
            this.lst_list.DoubleClick += new System.EventHandler(this.lst_list_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_update);
            this.groupBox2.Controls.Add(this.button_newcontact);
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(257, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 407);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Contact";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(10, 371);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(643, 23);
            this.button_update.TabIndex = 1;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_updatecontact_Click);
            // 
            // button_newcontact
            // 
            this.button_newcontact.Location = new System.Drawing.Point(10, 342);
            this.button_newcontact.Name = "button_newcontact";
            this.button_newcontact.Size = new System.Drawing.Size(643, 23);
            this.button_newcontact.TabIndex = 1;
            this.button_newcontact.Text = "New Contact";
            this.button_newcontact.UseVisualStyleBackColor = true;
            this.button_newcontact.Click += new System.EventHandler(this.button_newcontact_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 316);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_website);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_email);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_telephone3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_telephone2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_telephone1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_surname);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_address);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(643, 290);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Infos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_website
            // 
            this.txt_website.Location = new System.Drawing.Point(162, 246);
            this.txt_website.Name = "txt_website";
            this.txt_website.Size = new System.Drawing.Size(187, 20);
            this.txt_website.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Web Site";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(162, 208);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(187, 20);
            this.txt_email.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // txt_telephone3
            // 
            this.txt_telephone3.Location = new System.Drawing.Point(162, 171);
            this.txt_telephone3.Name = "txt_telephone3";
            this.txt_telephone3.Size = new System.Drawing.Size(187, 20);
            this.txt_telephone3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telephone 3";
            // 
            // txt_telephone2
            // 
            this.txt_telephone2.Location = new System.Drawing.Point(162, 135);
            this.txt_telephone2.Name = "txt_telephone2";
            this.txt_telephone2.Size = new System.Drawing.Size(187, 20);
            this.txt_telephone2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telephone 2";
            // 
            // txt_telephone1
            // 
            this.txt_telephone1.Location = new System.Drawing.Point(162, 98);
            this.txt_telephone1.Name = "txt_telephone1";
            this.txt_telephone1.Size = new System.Drawing.Size(187, 20);
            this.txt_telephone1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telephone 1 ";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(162, 62);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(187, 20);
            this.txt_surname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(385, 62);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(187, 129);
            this.txt_address.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Address";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(162, 23);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(187, 20);
            this.txt_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_definition);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(643, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Definition";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_definition
            // 
            this.txt_definition.Location = new System.Drawing.Point(22, 20);
            this.txt_definition.Multiline = true;
            this.txt_definition.Name = "txt_definition";
            this.txt_definition.Size = new System.Drawing.Size(598, 247);
            this.txt_definition.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_status);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button_jsongive);
            this.groupBox3.Controls.Add(this.button_csvgive);
            this.groupBox3.Controls.Add(this.button_xmlgive);
            this.groupBox3.Location = new System.Drawing.Point(257, 427);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(672, 142);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Give or Take";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_status.Location = new System.Drawing.Point(540, 64);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(117, 20);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "Status: Waiting";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "XML Take";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_jsongive
            // 
            this.button_jsongive.Location = new System.Drawing.Point(218, 43);
            this.button_jsongive.Name = "button_jsongive";
            this.button_jsongive.Size = new System.Drawing.Size(98, 64);
            this.button_jsongive.TabIndex = 0;
            this.button_jsongive.Text = "JSON Give";
            this.button_jsongive.UseVisualStyleBackColor = true;
            // 
            // button_csvgive
            // 
            this.button_csvgive.Location = new System.Drawing.Point(114, 43);
            this.button_csvgive.Name = "button_csvgive";
            this.button_csvgive.Size = new System.Drawing.Size(98, 64);
            this.button_csvgive.TabIndex = 0;
            this.button_csvgive.Text = "CSV Give";
            this.button_csvgive.UseVisualStyleBackColor = true;
            // 
            // button_xmlgive
            // 
            this.button_xmlgive.Location = new System.Drawing.Point(10, 43);
            this.button_xmlgive.Name = "button_xmlgive";
            this.button_xmlgive.Size = new System.Drawing.Size(98, 64);
            this.button_xmlgive.TabIndex = 0;
            this.button_xmlgive.Text = "XML Give";
            this.button_xmlgive.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 581);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_website;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_telephone3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_telephone2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_telephone1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_newcontact;
        private System.Windows.Forms.TextBox txt_definition;
        private System.Windows.Forms.ListBox lst_list;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_jsongive;
        private System.Windows.Forms.Button button_csvgive;
        private System.Windows.Forms.Button button_xmlgive;
    }
}