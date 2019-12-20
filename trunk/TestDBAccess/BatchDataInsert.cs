using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TestDBAccess
{
    public partial class BatchDataInsert : Form
    {
        public BatchDataInsert()
        {
            InitializeComponent();
        }

        private void btn_exec_Click(object sender, EventArgs e)
        {
            //设置一个数据库的连接串   
            string connectStr = txt_connectionStr.Text;
            OracleConnection conn = new OracleConnection(connectStr);
            OracleCommand command = new OracleCommand();
            command.Connection = conn; 
            //到此为止，还都是我们熟悉的代码，下面就要开始喽 
            var recc = Int32.Parse(txt_recordCount.Text);
             //这个参数需要指定每次批插入的记录数   
            command.ArrayBindCount = recc;
            //在这个命令行中,用到了参数,参数我们很熟悉,但是这个参数在传值的时候   
            //用到的是数组,而不是单个的值,这就是它独特的地方   
            command.CommandText = "insert into Z_TEST(ID,TESTNUMTYPE, VERSION) values(:ID,:TESTNUMTYPE, :VERSION)";
            conn.Open();
            //下面定义几个数组,分别表示三个字段,数组的长度由参数直接给出   
            Object[] ID = new Object[recc];
            Object[] TESTNUMTYPE = new Object[recc];
            Object[] VERSION = new Object[recc];
            // 为了传递参数,不可避免的要使用参数,下面会连续定义三个   
            // 从名称可以直接看出每个参数的含义,不在每个解释了   
            OracleParameter IDParam = new OracleParameter("ID", OracleDbType.Varchar2);
            IDParam.Direction = ParameterDirection.Input;
            IDParam.Value = ID;
            command.Parameters.Add(IDParam);
            OracleParameter deptNoParam = new OracleParameter("TESTNUMTYPE", OracleDbType.Int32);
            deptNoParam.Direction = ParameterDirection.Input;
            deptNoParam.Value = TESTNUMTYPE;
            command.Parameters.Add(deptNoParam);
            OracleParameter deptNameParam = new OracleParameter("VERSION", OracleDbType.Varchar2);
            deptNameParam.Direction = ParameterDirection.Input;
            deptNameParam.Value = VERSION;
            command.Parameters.Add(deptNameParam);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //在下面的循环中,先把数组定义好,而不是像上面那样直接生成SQL   
            for (int i = 0; i < recc; i++)
            {
                ID[i] = Guid.NewGuid().ToString("N");
                TESTNUMTYPE[i] = i;
                VERSION[i] = i.ToString();
            }
            //这个调用将把参数数组传进SQL,同时写入数据库   
            command.ExecuteNonQuery();
            sw.Stop();
            txt_msg.Text = "批量插入:" + recc.ToString() + "所占时间:" + sw.ElapsedMilliseconds.ToString();
        }
    }
}
