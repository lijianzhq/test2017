namespace TestDBAccess
{
    partial class BatchDataInsert
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_recordCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.btn_exec = new System.Windows.Forms.Button();
            this.comb_dbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_connectionStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "插入行数：";
            // 
            // txt_recordCount
            // 
            this.txt_recordCount.Location = new System.Drawing.Point(130, 128);
            this.txt_recordCount.Name = "txt_recordCount";
            this.txt_recordCount.Size = new System.Drawing.Size(121, 21);
            this.txt_recordCount.TabIndex = 3;
            this.txt_recordCount.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "执行结果：";
            // 
            // txt_msg
            // 
            this.txt_msg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_msg.Location = new System.Drawing.Point(0, 213);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(703, 129);
            this.txt_msg.TabIndex = 18;
            // 
            // btn_exec
            // 
            this.btn_exec.Location = new System.Drawing.Point(307, 180);
            this.btn_exec.Name = "btn_exec";
            this.btn_exec.Size = new System.Drawing.Size(75, 23);
            this.btn_exec.TabIndex = 20;
            this.btn_exec.Text = "执行";
            this.btn_exec.UseVisualStyleBackColor = true;
            this.btn_exec.Click += new System.EventHandler(this.btn_exec_Click);
            // 
            // comb_dbType
            // 
            this.comb_dbType.FormattingEnabled = true;
            this.comb_dbType.Items.AddRange(new object[] {
            "SqlServer",
            "Oracle"});
            this.comb_dbType.Location = new System.Drawing.Point(130, 12);
            this.comb_dbType.Name = "comb_dbType";
            this.comb_dbType.Size = new System.Drawing.Size(121, 20);
            this.comb_dbType.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "数据库类型：";
            // 
            // txt_connectionStr
            // 
            this.txt_connectionStr.Location = new System.Drawing.Point(130, 58);
            this.txt_connectionStr.Multiline = true;
            this.txt_connectionStr.Name = "txt_connectionStr";
            this.txt_connectionStr.Size = new System.Drawing.Size(492, 54);
            this.txt_connectionStr.TabIndex = 24;
            this.txt_connectionStr.Text = "Server=LIJIAN42889\\SQLSERVER2017;Database=TestDB;Uid=sa;pwd=sa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "连接字符串：";
            // 
            // BatchDataInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 342);
            this.Controls.Add(this.txt_connectionStr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comb_dbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_exec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.txt_recordCount);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BatchDataInsert";
            this.Text = "批量数据插入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_recordCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.Button btn_exec;
        private System.Windows.Forms.ComboBox comb_dbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_connectionStr;
        private System.Windows.Forms.Label label1;
    }
}