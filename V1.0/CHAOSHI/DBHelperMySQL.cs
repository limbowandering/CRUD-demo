using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CHAOSHI
{
    class DBHelperMySQL
    {
        public MySqlConnection cnt = null;
        public MySqlCommand cmd = null;
        public MySqlDataAdapter adap = null;
        public MySqlTransaction tran = null;

        public DBHelperMySQL(string db, string user, string pwd, string host)
        {
            string s = $"Host={host};Database={db};Username={user};Password={pwd}";
            cnt = new MySqlConnection(s);
        }

        public DataSet Select(string sql)
        {
            DataSet ds = new DataSet();
            cmd = cnt.CreateCommand();
            cmd.CommandText = sql;
            adap = new MySqlDataAdapter(cmd);
            adap.Fill(ds);
            return ds;
        }

        public void Open()
        {
            cnt.Open();
        }

        public void Close()
        {
            cnt.Close();
        }

        public int Execute(String sql)
        {
            cmd = new MySqlCommand(sql, cnt);
            return cmd.ExecuteNonQuery();
        }

        public void Begin()
        {
            tran = cnt.BeginTransaction();
            cmd = cnt.CreateCommand();
            cmd.Transaction = tran;
        }

        public void Commit()
        {
            tran.Commit();
        }

        public void Rollback()
        {
            tran.Rollback();
        }
    }
}
