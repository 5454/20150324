namespace LibrayUnitTest {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.testBtn = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.minValueIpt = new System.Windows.Forms.TextBox();
            this.maxValueIpt = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listSubTestBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(6, 61);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 0;
            this.testBtn.Text = "TestBtn";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // logBox
            // 
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logBox.Location = new System.Drawing.Point(12, 309);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(694, 269);
            this.logBox.TabIndex = 1;
            this.logBox.Text = "";
            // 
            // minValueIpt
            // 
            this.minValueIpt.Location = new System.Drawing.Point(6, 6);
            this.minValueIpt.Name = "minValueIpt";
            this.minValueIpt.Size = new System.Drawing.Size(100, 21);
            this.minValueIpt.TabIndex = 2;
            // 
            // maxValueIpt
            // 
            this.maxValueIpt.Location = new System.Drawing.Point(6, 34);
            this.maxValueIpt.Name = "maxValueIpt";
            this.maxValueIpt.Size = new System.Drawing.Size(100, 21);
            this.maxValueIpt.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(693, 291);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listSubTestBtn);
            this.tabPage1.Controls.Add(this.minValueIpt);
            this.tabPage1.Controls.Add(this.maxValueIpt);
            this.tabPage1.Controls.Add(this.testBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(685, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(685, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listSubTestBtn
            // 
            this.listSubTestBtn.Location = new System.Drawing.Point(7, 91);
            this.listSubTestBtn.Name = "listSubTestBtn";
            this.listSubTestBtn.Size = new System.Drawing.Size(75, 23);
            this.listSubTestBtn.TabIndex = 4;
            this.listSubTestBtn.Text = "listSubTest";
            this.listSubTestBtn.UseVisualStyleBackColor = true;
            this.listSubTestBtn.Click += new System.EventHandler(this.listSubTestBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 590);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.logBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.TextBox minValueIpt;
        private System.Windows.Forms.TextBox maxValueIpt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button listSubTestBtn;
    }
}

