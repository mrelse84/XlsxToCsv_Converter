namespace XlsxToCsv_Converter
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSrcDir = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChooseSrcDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChooseDstDir = new System.Windows.Forms.Button();
            this.txtDstDir = new System.Windows.Forms.TextBox();
            this.richTxtResults = new System.Windows.Forms.RichTextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabMode = new System.Windows.Forms.TabControl();
            this.tabPageFile = new System.Windows.Forms.TabPage();
            this.txtDstFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChooseSrcFile = new System.Windows.Forms.Button();
            this.txtSrcFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TabPageDir = new System.Windows.Forms.TabPage();
            this.tabMode.SuspendLayout();
            this.tabPageFile.SuspendLayout();
            this.TabPageDir.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSrcDir
            // 
            this.txtSrcDir.Location = new System.Drawing.Point(87, 13);
            this.txtSrcDir.Name = "txtSrcDir";
            this.txtSrcDir.Size = new System.Drawing.Size(520, 21);
            this.txtSrcDir.TabIndex = 0;
            // 
            // btnChooseSrcDir
            // 
            this.btnChooseSrcDir.Location = new System.Drawing.Point(627, 12);
            this.btnChooseSrcDir.Name = "btnChooseSrcDir";
            this.btnChooseSrcDir.Size = new System.Drawing.Size(75, 23);
            this.btnChooseSrcDir.TabIndex = 1;
            this.btnChooseSrcDir.Text = "Choose";
            this.btnChooseSrcDir.UseVisualStyleBackColor = true;
            this.btnChooseSrcDir.Click += new System.EventHandler(this.btnChooseSrcDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Src Dir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dst Dir:";
            // 
            // btnChooseDstDir
            // 
            this.btnChooseDstDir.Enabled = false;
            this.btnChooseDstDir.Location = new System.Drawing.Point(627, 49);
            this.btnChooseDstDir.Name = "btnChooseDstDir";
            this.btnChooseDstDir.Size = new System.Drawing.Size(75, 23);
            this.btnChooseDstDir.TabIndex = 4;
            this.btnChooseDstDir.Text = "Choose";
            this.btnChooseDstDir.UseVisualStyleBackColor = true;
            this.btnChooseDstDir.Click += new System.EventHandler(this.btnChooseDstDir_Click);
            // 
            // txtDstDir
            // 
            this.txtDstDir.Enabled = false;
            this.txtDstDir.Location = new System.Drawing.Point(87, 50);
            this.txtDstDir.Name = "txtDstDir";
            this.txtDstDir.Size = new System.Drawing.Size(520, 21);
            this.txtDstDir.TabIndex = 3;
            // 
            // richTxtResults
            // 
            this.richTxtResults.Location = new System.Drawing.Point(23, 165);
            this.richTxtResults.Name = "richTxtResults";
            this.richTxtResults.Size = new System.Drawing.Size(612, 273);
            this.richTxtResults.TabIndex = 6;
            this.richTxtResults.Text = "";
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(655, 165);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 7;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Results:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(655, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(655, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Xlsx File|*.xlsx;";
            // 
            // tabMode
            // 
            this.tabMode.Controls.Add(this.tabPageFile);
            this.tabMode.Controls.Add(this.TabPageDir);
            this.tabMode.Location = new System.Drawing.Point(24, 12);
            this.tabMode.Name = "tabMode";
            this.tabMode.SelectedIndex = 0;
            this.tabMode.Size = new System.Drawing.Size(727, 122);
            this.tabMode.TabIndex = 11;
            // 
            // tabPageFile
            // 
            this.tabPageFile.Controls.Add(this.txtDstFile);
            this.tabPageFile.Controls.Add(this.label5);
            this.tabPageFile.Controls.Add(this.btnChooseSrcFile);
            this.tabPageFile.Controls.Add(this.txtSrcFile);
            this.tabPageFile.Controls.Add(this.label4);
            this.tabPageFile.Location = new System.Drawing.Point(4, 22);
            this.tabPageFile.Name = "tabPageFile";
            this.tabPageFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFile.Size = new System.Drawing.Size(719, 96);
            this.tabPageFile.TabIndex = 0;
            this.tabPageFile.Text = "File";
            this.tabPageFile.UseVisualStyleBackColor = true;
            // 
            // txtDstFile
            // 
            this.txtDstFile.Location = new System.Drawing.Point(87, 50);
            this.txtDstFile.Name = "txtDstFile";
            this.txtDstFile.Size = new System.Drawing.Size(520, 21);
            this.txtDstFile.TabIndex = 14;
            this.txtDstFile.TextChanged += new System.EventHandler(this.txtDstFile_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dst File:";
            // 
            // btnChooseSrcFile
            // 
            this.btnChooseSrcFile.Location = new System.Drawing.Point(627, 12);
            this.btnChooseSrcFile.Name = "btnChooseSrcFile";
            this.btnChooseSrcFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseSrcFile.TabIndex = 12;
            this.btnChooseSrcFile.Text = "Choose";
            this.btnChooseSrcFile.UseVisualStyleBackColor = true;
            this.btnChooseSrcFile.Click += new System.EventHandler(this.btnChooseSrcFile_Click);
            // 
            // txtSrcFile
            // 
            this.txtSrcFile.Location = new System.Drawing.Point(87, 13);
            this.txtSrcFile.Name = "txtSrcFile";
            this.txtSrcFile.Size = new System.Drawing.Size(520, 21);
            this.txtSrcFile.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Src File:";
            // 
            // TabPageDir
            // 
            this.TabPageDir.Controls.Add(this.label2);
            this.TabPageDir.Controls.Add(this.label1);
            this.TabPageDir.Controls.Add(this.txtSrcDir);
            this.TabPageDir.Controls.Add(this.btnChooseSrcDir);
            this.TabPageDir.Controls.Add(this.txtDstDir);
            this.TabPageDir.Controls.Add(this.btnChooseDstDir);
            this.TabPageDir.Location = new System.Drawing.Point(4, 22);
            this.TabPageDir.Name = "TabPageDir";
            this.TabPageDir.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageDir.Size = new System.Drawing.Size(719, 96);
            this.TabPageDir.TabIndex = 1;
            this.TabPageDir.Text = "Directory";
            this.TabPageDir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.tabMode);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.richTxtResults);
            this.Name = "Form1";
            this.Text = "XlsxToCsv Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMode.ResumeLayout(false);
            this.tabPageFile.ResumeLayout(false);
            this.tabPageFile.PerformLayout();
            this.TabPageDir.ResumeLayout(false);
            this.TabPageDir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSrcDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnChooseSrcDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChooseDstDir;
        private System.Windows.Forms.TextBox txtDstDir;
        private System.Windows.Forms.RichTextBox richTxtResults;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabMode;
        private System.Windows.Forms.TabPage tabPageFile;
        private System.Windows.Forms.TextBox txtDstFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChooseSrcFile;
        private System.Windows.Forms.TextBox txtSrcFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage TabPageDir;
    }
}

