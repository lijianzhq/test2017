namespace TestDBAccess
{
    partial class MutilSqlExecTest
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
            this.txt_sqlStr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comb_dbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Excute = new System.Windows.Forms.Button();
            this.txt_connectionStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_sqlStr
            // 
            this.txt_sqlStr.Location = new System.Drawing.Point(95, 115);
            this.txt_sqlStr.Multiline = true;
            this.txt_sqlStr.Name = "txt_sqlStr";
            this.txt_sqlStr.Size = new System.Drawing.Size(492, 88);
            this.txt_sqlStr.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "数据库脚本：";
            // 
            // comb_dbType
            // 
            this.comb_dbType.FormattingEnabled = true;
            this.comb_dbType.Items.AddRange(new object[] {
            "SqlServer",
            "Oracle"});
            this.comb_dbType.Location = new System.Drawing.Point(95, 8);
            this.comb_dbType.Name = "comb_dbType";
            this.comb_dbType.Size = new System.Drawing.Size(121, 20);
            this.comb_dbType.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "数据库类型：";
            // 
            // btn_Excute
            // 
            this.btn_Excute.Location = new System.Drawing.Point(264, 224);
            this.btn_Excute.Name = "btn_Excute";
            this.btn_Excute.Size = new System.Drawing.Size(75, 23);
            this.btn_Excute.TabIndex = 9;
            this.btn_Excute.Text = "执行";
            this.btn_Excute.UseVisualStyleBackColor = true;
            this.btn_Excute.Click += new System.EventHandler(this.btn_Excute_Click);
            // 
            // txt_connectionStr
            // 
            this.txt_connectionStr.Location = new System.Drawing.Point(95, 43);
            this.txt_connectionStr.Multiline = true;
            this.txt_connectionStr.Name = "txt_connectionStr";
            this.txt_connectionStr.Size = new System.Drawing.Size(492, 54);
            this.txt_connectionStr.TabIndex = 15;
            this.txt_connectionStr.Text = "Server=LIJIAN42889\\SQLSERVER2017;Database=TestDB;Uid=sa;pwd=sa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "连接字符串：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "执行结果：";
            // 
            // txt_msg
            // 
            this.txt_msg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_msg.Location = new System.Drawing.Point(0, 260);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(610, 129);
            this.txt_msg.TabIndex = 16;
            // 
            // MutilSqlExecTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 389);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.txt_connectionStr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sqlStr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comb_dbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Excute);
            this.MaximizeBox = false;
            this.Name = "MutilSqlExecTest";
            this.Text = "多条SQL执行的测试";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sqlStr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comb_dbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Excute;
        private System.Windows.Forms.TextBox txt_connectionStr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_msg;
    }
}