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
    public partial class MutilSqlExecTest : Form
    {
        public MutilSqlExecTest()
        {
            InitializeComponent();
        }

        private void btn_Excute_Click(object sender, EventArgs e)
        {
            var dbType = comb_dbType.SelectedIndex;
            var connetionStr = txt_connectionStr.Text;
            var sqlText = txt_sqlStr.Text;
            if(String.IsNullOrWhiteSpace(sqlText))
            {
                MessageBox.Show("sql为空！");
                return;
            }

            Task.Factory.StartNew<Int32>(new Func<Int32>(() =>
            {
                Execute db = null;
                if (dbType == 0) db = new SqlServerExecute(connetionStr);
                else db = new OracleExecute(connetionStr);
                return db.ExecString(sqlText);
            })).ContinueWith(new Action<Task<Int32>>((tsk) =>
            {
                var result = tsk.Result;
                this.Invoke(new Action(() =>
                {
                    txt_msg.Text += $"结果：{result}";
                }));
            }));
        }
    }
}
