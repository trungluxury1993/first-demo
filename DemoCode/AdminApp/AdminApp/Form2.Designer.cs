namespace AdminApp
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
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(368, 441);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 37);
            this.btnAdd.TabIndex = 79;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rtB
            // 
            this.rtB.Location = new System.Drawing.Point(170, 381);
            this.rtB.Name = "rtB";
            this.rtB.Size = new System.Drawing.Size(594, 37);
            this.rtB.TabIndex = 78;
            this.rtB.Text = "";
            // 
            // rtD
            // 
            this.rtD.Location = new System.Drawing.Point(170, 329);
            this.rtD.Name = "rtD";
            this.rtD.Size = new System.Drawing.Size(594, 43);
            this.rtD.TabIndex = 77;
            this.rtD.Text = "";
            // 
            // rtC
            // 
            this.rtC.Location = new System.Drawing.Point(170, 285);
            this.rtC.Name = "rtC";
            this.rtC.Size = new System.Drawing.Size(594, 38);
            this.rtC.TabIndex = 76;
            this.rtC.Text = "";
            // 
            // rtA
            // 
            this.rtA.Location = new System.Drawing.Point(170, 247);
            this.rtA.Name = "rtA";
            this.rtA.Size = new System.Drawing.Size(594, 32);
            this.rtA.TabIndex = 75;
            this.rtA.Text = "";
            // 
            // rtContent
            // 
            this.rtContent.Location = new System.Drawing.Point(170, 107);
            this.rtContent.Name = "rtContent";
            this.rtContent.Size = new System.Drawing.Size(594, 116);
            this.rtContent.TabIndex = 70;
            this.rtContent.Text = "";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(170, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 65;
            // 
            // rdD
            // 
            this.rdD.AutoSize = true;
            this.rdD.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdD.Location = new System.Drawing.Point(72, 391);
            this.rdD.Name = "rdD";
            this.rdD.Size = new System.Drawing.Size(37, 22);
            this.rdD.TabIndex = 74;
            this.rdD.TabStop = true;
            this.rdD.Text = "D";
            this.rdD.UseVisualStyleBackColor = true;
            // 
            // rdC
            // 
            this.rdC.AutoSize = true;
            this.rdC.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdC.Location = new System.Drawing.Point(71, 344);
            this.rdC.Name = "rdC";
            this.rdC.Size = new System.Drawing.Size(35, 22);
            this.rdC.TabIndex = 73;
            this.rdC.TabStop = true;
            this.rdC.Text = "C";
            this.rdC.UseVisualStyleBackColor = true;
            // 
            // rdB
            // 
            this.rdB.AutoSize = true;
            this.rdB.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdB.Location = new System.Drawing.Point(72, 291);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(36, 22);
            this.rdB.TabIndex = 72;
            this.rdB.TabStop = true;
            this.rdB.Text = "B";
            this.rdB.UseVisualStyleBackColor = true;
            // 
            // rdA
            // 
            this.rdA.AutoSize = true;
            this.rdA.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdA.Location = new System.Drawing.Point(71, 247);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(35, 22);
            this.rdA.TabIndex = 71;
            this.rdA.TabStop = true;
            this.rdA.Text = "A";
            this.rdA.UseVisualStyleBackColor = true;
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
            this.cbSubject.Location = new System.Drawing.Point(170, 57);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(144, 21);
            this.cbSubject.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 68;
            this.label7.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 67;
            this.label2.Text = "ID Question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 66;
            this.label1.Text = "Content";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 506);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtB);
            this.Controls.Add(this.rtD);
            this.Controls.Add(this.rtC);
            this.Controls.Add(this.rtA);
            this.Controls.Add(this.rtContent);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.rdD);
            this.Controls.Add(this.rdC);
            this.Controls.Add(this.rdB);
            this.Controls.Add(this.rdA);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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