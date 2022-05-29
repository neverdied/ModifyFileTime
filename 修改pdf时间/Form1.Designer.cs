namespace 修改pdf时间
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.createTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastAccessTime = new System.Windows.Forms.DateTimePicker();
            this.lastModifyTime = new System.Windows.Forms.DateTimePicker();
            this.buttonModifyPDFTime = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSelectPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTime
            // 
            this.createTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.createTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.createTime.Location = new System.Drawing.Point(165, 61);
            this.createTime.Name = "createTime";
            this.createTime.Size = new System.Drawing.Size(200, 21);
            this.createTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "创建时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "最后修改时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "最后打开时间：";
            // 
            // lastAccessTime
            // 
            this.lastAccessTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.lastAccessTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lastAccessTime.Location = new System.Drawing.Point(165, 140);
            this.lastAccessTime.Name = "lastAccessTime";
            this.lastAccessTime.Size = new System.Drawing.Size(200, 21);
            this.lastAccessTime.TabIndex = 4;
            // 
            // lastModifyTime
            // 
            this.lastModifyTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.lastModifyTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lastModifyTime.Location = new System.Drawing.Point(165, 97);
            this.lastModifyTime.Name = "lastModifyTime";
            this.lastModifyTime.Size = new System.Drawing.Size(200, 21);
            this.lastModifyTime.TabIndex = 5;
            // 
            // buttonModifyPDFTime
            // 
            this.buttonModifyPDFTime.Location = new System.Drawing.Point(154, 184);
            this.buttonModifyPDFTime.Name = "buttonModifyPDFTime";
            this.buttonModifyPDFTime.Size = new System.Drawing.Size(152, 23);
            this.buttonModifyPDFTime.TabIndex = 6;
            this.buttonModifyPDFTime.Text = "修改文件时间";
            this.buttonModifyPDFTime.UseVisualStyleBackColor = true;
            this.buttonModifyPDFTime.Click += new System.EventHandler(this.buttonModifyPDFTime_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "选择文件：";
            // 
            // buttonSelectPDF
            // 
            this.buttonSelectPDF.Location = new System.Drawing.Point(170, 32);
            this.buttonSelectPDF.Name = "buttonSelectPDF";
            this.buttonSelectPDF.Size = new System.Drawing.Size(136, 23);
            this.buttonSelectPDF.TabIndex = 8;
            this.buttonSelectPDF.Text = "选择要修改的文件";
            this.buttonSelectPDF.UseVisualStyleBackColor = true;
            this.buttonSelectPDF.Click += new System.EventHandler(this.buttonSelectPDF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(490, 274);
            this.Controls.Add(this.buttonSelectPDF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonModifyPDFTime);
            this.Controls.Add(this.lastModifyTime);
            this.Controls.Add(this.lastAccessTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createTime);
            this.Name = "Form1";
            this.Text = "修改文件时间";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker createTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker lastAccessTime;
        private System.Windows.Forms.DateTimePicker lastModifyTime;
        private System.Windows.Forms.Button buttonModifyPDFTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSelectPDF;


    }
}

