﻿namespace AdminApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rtB = new System.Windows.Forms.RichTextBox();
            this.rtD = new System.Windows.Forms.RichTextBox();
            this.rtC = new System.Windows.Forms.RichTextBox();
            this.rtA = new System.Windows.Forms.RichTextBox();
            this.rtContent = new System.Windows.Forms.RichTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.rdD = new System.Windows.Forms.RadioButton();
            this.rdC = new System.Windows.Forms.RadioButton();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 498);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.rtB);
            this.tabPage1.Controls.Add(this.rtD);
            this.tabPage1.Controls.Add(this.rtC);
            this.tabPage1.Controls.Add(this.rtA);
            this.tabPage1.Controls.Add(this.rtContent);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.rdD);
            this.tabPage1.Controls.Add(this.rdC);
            this.tabPage1.Controls.Add(this.rdB);
            this.tabPage1.Controls.Add(this.rdA);
            this.tabPage1.Controls.Add(this.cbSubject);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(943, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "manager questions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(943, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "manager exam";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(427, 424);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 37);
            this.btnAdd.TabIndex = 94;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rtB
            // 
            this.rtB.Location = new System.Drawing.Point(229, 364);
            this.rtB.Name = "rtB";
            this.rtB.Size = new System.Drawing.Size(594, 37);
            this.rtB.TabIndex = 93;
            this.rtB.Text = "";
            this.rtB.TextChanged += new System.EventHandler(this.rtB_TextChanged);
            // 
            // rtD
            // 
            this.rtD.Location = new System.Drawing.Point(229, 312);
            this.rtD.Name = "rtD";
            this.rtD.Size = new System.Drawing.Size(594, 43);
            this.rtD.TabIndex = 92;
            this.rtD.Text = "";
            this.rtD.TextChanged += new System.EventHandler(this.rtD_TextChanged);
            // 
            // rtC
            // 
            this.rtC.Location = new System.Drawing.Point(229, 268);
            this.rtC.Name = "rtC";
            this.rtC.Size = new System.Drawing.Size(594, 38);
            this.rtC.TabIndex = 91;
            this.rtC.Text = "";
            this.rtC.TextChanged += new System.EventHandler(this.rtC_TextChanged);
            // 
            // rtA
            // 
            this.rtA.Location = new System.Drawing.Point(229, 230);
            this.rtA.Name = "rtA";
            this.rtA.Size = new System.Drawing.Size(594, 32);
            this.rtA.TabIndex = 90;
            this.rtA.Text = "";
            this.rtA.TextChanged += new System.EventHandler(this.rtA_TextChanged);
            // 
            // rtContent
            // 
            this.rtContent.Location = new System.Drawing.Point(229, 90);
            this.rtContent.Name = "rtContent";
            this.rtContent.Size = new System.Drawing.Size(594, 116);
            this.rtContent.TabIndex = 85;
            this.rtContent.Text = "";
            this.rtContent.TextChanged += new System.EventHandler(this.rtContent_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(229, 11);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 80;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // rdD
            // 
            this.rdD.AutoSize = true;
            this.rdD.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdD.Location = new System.Drawing.Point(131, 374);
            this.rdD.Name = "rdD";
            this.rdD.Size = new System.Drawing.Size(37, 22);
            this.rdD.TabIndex = 89;
            this.rdD.TabStop = true;
            this.rdD.Text = "D";
            this.rdD.UseVisualStyleBackColor = true;
            this.rdD.CheckedChanged += new System.EventHandler(this.rdD_CheckedChanged);
            // 
            // rdC
            // 
            this.rdC.AutoSize = true;
            this.rdC.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdC.Location = new System.Drawing.Point(130, 327);
            this.rdC.Name = "rdC";
            this.rdC.Size = new System.Drawing.Size(35, 22);
            this.rdC.TabIndex = 88;
            this.rdC.TabStop = true;
            this.rdC.Text = "C";
            this.rdC.UseVisualStyleBackColor = true;
            this.rdC.CheckedChanged += new System.EventHandler(this.rdC_CheckedChanged);
            // 
            // rdB
            // 
            this.rdB.AutoSize = true;
            this.rdB.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdB.Location = new System.Drawing.Point(131, 274);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(36, 22);
            this.rdB.TabIndex = 87;
            this.rdB.TabStop = true;
            this.rdB.Text = "B";
            this.rdB.UseVisualStyleBackColor = true;
            this.rdB.CheckedChanged += new System.EventHandler(this.rdB_CheckedChanged);
            // 
            // rdA
            // 
            this.rdA.AutoSize = true;
            this.rdA.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdA.Location = new System.Drawing.Point(130, 230);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(35, 22);
            this.rdA.TabIndex = 86;
            this.rdA.TabStop = true;
            this.rdA.Text = "A";
            this.rdA.UseVisualStyleBackColor = true;
            this.rdA.CheckedChanged += new System.EventHandler(this.rdA_CheckedChanged);
            // 
            // cbSubject
            // 
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Items.AddRange(new object[] {
            "Topnotch1",
            "Topnotch2",
            "Topnoch3",
            "Summit1"});
            this.cbSubject.Location = new System.Drawing.Point(229, 40);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(144, 21);
            this.cbSubject.TabIndex = 84;
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(120, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 83;
            this.label7.Text = "Subject";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 82;
            this.label2.Text = "ID Question";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 81;
            this.label1.Text = "Content";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 498);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox rtB;
        private System.Windows.Forms.RichTextBox rtD;
        private System.Windows.Forms.RichTextBox rtC;
        private System.Windows.Forms.RichTextBox rtA;
        private System.Windows.Forms.RichTextBox rtContent;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.RadioButton rdD;
        private System.Windows.Forms.RadioButton rdC;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

