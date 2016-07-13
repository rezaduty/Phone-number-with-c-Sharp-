namespace printdata
{
    partial class PrintOptions
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
            this.chklst = new System.Windows.Forms.CheckedListBox();
            this.printtitle = new System.Windows.Forms.TextBox();
            this.rdoallrow = new System.Windows.Forms.RadioButton();
            this.rdoselectedrow = new System.Windows.Forms.RadioButton();
            this.btnok = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chklst
            // 
            this.chklst.FormattingEnabled = true;
            this.chklst.Location = new System.Drawing.Point(280, 31);
            this.chklst.Name = "chklst";
            this.chklst.Size = new System.Drawing.Size(180, 199);
            this.chklst.TabIndex = 0;
            // 
            // printtitle
            // 
            this.printtitle.Location = new System.Drawing.Point(31, 132);
            this.printtitle.Multiline = true;
            this.printtitle.Name = "printtitle";
            this.printtitle.Size = new System.Drawing.Size(220, 98);
            this.printtitle.TabIndex = 1;
            // 
            // rdoallrow
            // 
            this.rdoallrow.AutoSize = true;
            this.rdoallrow.Location = new System.Drawing.Point(31, 31);
            this.rdoallrow.Name = "rdoallrow";
            this.rdoallrow.Size = new System.Drawing.Size(85, 17);
            this.rdoallrow.TabIndex = 2;
            this.rdoallrow.TabStop = true;
            this.rdoallrow.Text = "radioButton1";
            this.rdoallrow.UseVisualStyleBackColor = true;
            // 
            // rdoselectedrow
            // 
            this.rdoselectedrow.AutoSize = true;
            this.rdoselectedrow.Location = new System.Drawing.Point(133, 31);
            this.rdoselectedrow.Name = "rdoselectedrow";
            this.rdoselectedrow.Size = new System.Drawing.Size(85, 17);
            this.rdoselectedrow.TabIndex = 3;
            this.rdoselectedrow.TabStop = true;
            this.rdoselectedrow.Text = "radioButton2";
            this.rdoselectedrow.UseVisualStyleBackColor = true;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(290, 282);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(117, 34);
            this.btnok.TabIndex = 4;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(31, 91);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PrintOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 359);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.rdoselectedrow);
            this.Controls.Add(this.rdoallrow);
            this.Controls.Add(this.printtitle);
            this.Controls.Add(this.chklst);
            this.Name = "PrintOptions";
            this.Text = "PrintOptions";
            this.Load += new System.EventHandler(this.PrintOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklst;
        private System.Windows.Forms.TextBox printtitle;
        private System.Windows.Forms.RadioButton rdoallrow;
        private System.Windows.Forms.RadioButton rdoselectedrow;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}