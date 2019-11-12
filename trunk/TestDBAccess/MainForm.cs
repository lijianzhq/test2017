using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDBAccess
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 执行代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Excute_Click(object sender, EventArgs e)
        {
            var dbType = comb_dbType.SelectedIndex;
            var connetionStr = txt_connectionStr.Text;
            var recordCount = Int32.Parse(txt_recordCount.Text);

            Task.Factory.StartNew<Execute>(new Func<Execute>(() =>
            {
                Execute db = null;
                if (dbType == 0) db = new SqlServerExecute(connetionStr, recordCount);
                else db = new OracleExecute(connetionStr, recordCount);
                db.Start();
                return db;
            })).ContinueWith(new Action<Task<Execute>>((tsk) =>
            {
                var db = tsk.Result;
                this.Invoke(new Action(() =>
                {
                    txt_msg.Text = $"总耗时：{db.TotalSeconds()}";
                }));
            }));
        }

        private void txt_connectionStr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comb_dbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
