using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 修改pdf时间
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void modifyTime(string path,DateTime createTime,DateTime lastModifyTime,DateTime lastAccessTime) {
            File.SetCreationTime(path, createTime);
            File.SetLastWriteTime(path, lastModifyTime);
            File.SetLastAccessTime(path, lastAccessTime);
        }



        string path = "";
        private void buttonSelectPDF_Click(object sender, EventArgs e)
        {
            path = SelectPath();
            string filename = Path.GetFileNameWithoutExtension(path);   //截取文件
            buttonSelectPDF.Text = filename;
        }

        private string SelectPath()
        {
            string path = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Files (*.pdf)|*.pdf"//如果需要筛选txt文件（"Files (*.txt)|*.txt"）
            };

            //var result = openFileDialog.ShowDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }
            
            return path;
        }

        private void buttonModifyPDFTime_Click(object sender, EventArgs e)
        {
            modifyTime(path, createTime.Value, lastModifyTime.Value,lastAccessTime.Value);
            MessageBox.Show("修改" + path + "成功");
        }

    }
}
