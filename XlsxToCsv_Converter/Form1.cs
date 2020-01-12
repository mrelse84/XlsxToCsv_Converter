using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace XlsxToCsv_Converter
{
    public partial class Form1 : Form
    {
        static ExcelConverter excelConverter = new ExcelConverter();

        string srcFile = "";
        string dstFile = "";
        string srcDir = "";
        string dstDir = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            srcDir = System.IO.Directory.GetCurrentDirectory();
            dstDir = srcDir;
            txtSrcDir.Text = srcDir;
            txtDstDir.Text = dstDir;
        }

        private void btnChooseSrcFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSrcFile.Text = openFileDialog1.FileName;
                srcFile = txtSrcFile.Text;

                dstFile = Path.ChangeExtension(srcFile, "csv");
                txtDstFile.Text = dstFile;
            }
        }

        private void btnChooseSrcDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSrcDir.Text = folderBrowserDialog1.SelectedPath;
                srcDir = txtSrcDir.Text;
            }
        }

        private void btnChooseDstDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDstDir.Text = folderBrowserDialog1.SelectedPath;
                dstDir = txtDstDir.Text;
            }
        }

        private void AppendLog(string log)
        {
            richTxtResults.SelectionColor = Color.Blue;
            richTxtResults.AppendText(log);
            richTxtResults.ScrollToCaret();
        }

        private bool fileList()
        {
            bool ret = true;

            var allFiles = System.IO.Directory.GetFiles(srcDir, "*.*", System.IO.SearchOption.AllDirectories).Where(s => s.EndsWith(".xls") || s.EndsWith(".xlsx"));
            if (allFiles.Count() == 0)
            {
                MessageBox.Show("File not found!");
                return false;
            }
            foreach (string srcFile in allFiles)
            {
                // SrcDir이 Multi Level인 경우에 DstDir의 Level은 하나이므로, 한 폴더에 모든 DstFile이 생성됨
                // DstFile이 너무 많아지는 경우가 발생하므로, 당분간 아래와 같이 DstDir를 SrcDir과 같은 위치(Multi Level)로 고정함
                //dstFile = String.Format("{0}\\{1}.csv", dstDir, Path.GetFileNameWithoutExtension(srcFile));
                dstFile = Path.ChangeExtension(srcFile, "csv");

                string log = String.Format("{0} ..... ", srcFile);
                AppendLog(log);
                ret = excelConverter.Converter(srcFile, dstFile);
                if (ret)
                {
                    log = String.Format("{0}\r\n", "Done");
                    AppendLog(log);
                    Thread.Sleep(10);
                }
                else
                {
                    log = String.Format("{0}\r\n", "Failed");
                    AppendLog(log);
                    ret = false;
                    break;
                }
            }
            return ret;
        }


        private void btnConverter_Click(object sender, EventArgs e)
        {
            btnConverter.Enabled = false;
            if (tabMode.SelectedIndex == 0)
            {
                string log = String.Format("{0} ..... ", srcFile);
                AppendLog(log);
                bool ret = excelConverter.Converter(srcFile, dstFile);
                if (ret)
                    log = String.Format("{0}\r\n", "Done");
                else
                    log = String.Format("{0}\r\n", "Failed");
                AppendLog(log);
            }
            else
            {
                fileList();
            }
            btnConverter.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTxtResults.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDstFile_TextChanged(object sender, EventArgs e)
        {
            dstFile = txtDstFile.Text;
        }
    }
}
