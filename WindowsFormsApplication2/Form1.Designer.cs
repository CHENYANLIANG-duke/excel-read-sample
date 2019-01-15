namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenXls = new System.Windows.Forms.Button();
            this.txtExcelName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExportDb = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenXls
            // 
            this.btnOpenXls.Location = new System.Drawing.Point(12, 39);
            this.btnOpenXls.Name = "btnOpenXls";
            this.btnOpenXls.Size = new System.Drawing.Size(75, 50);
            this.btnOpenXls.TabIndex = 0;
            this.btnOpenXls.Text = "選擇Excel";
            this.btnOpenXls.UseVisualStyleBackColor = true;
            this.btnOpenXls.Click += new System.EventHandler(this.btnOpenXls_Click);
            // 
            // txtExcelName
            // 
            this.txtExcelName.Location = new System.Drawing.Point(93, 55);
            this.txtExcelName.Multiline = true;
            this.txtExcelName.Name = "txtExcelName";
            this.txtExcelName.Size = new System.Drawing.Size(445, 26);
            this.txtExcelName.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(398, 232);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnExportDb
            // 
            this.btnExportDb.Location = new System.Drawing.Point(481, 295);
            this.btnExportDb.Name = "btnExportDb";
            this.btnExportDb.Size = new System.Drawing.Size(75, 50);
            this.btnExportDb.TabIndex = 3;
            this.btnExportDb.Text = "匯出DB";
            this.btnExportDb.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(416, 113);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(140, 176);
            this.richTextBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 357);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnExportDb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtExcelName);
            this.Controls.Add(this.btnOpenXls);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenXls;
        private System.Windows.Forms.TextBox txtExcelName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExportDb;
        private System.Windows.Forms.TextBox richTextBox1;
    }
}

