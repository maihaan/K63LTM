using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QLSinhVien.DataAccess;
using QLSinhVien.Models;
using System.Data;

namespace QLSinhVien.Controllers
{
    public class CLop
    {
        DataAccess.DataAccess da = new DataAccess.DataAccess();
        String table = "tbLop";

        public DataTable Select(String condition)
        {
            String query = "Select * From " + table;
            if (!String.IsNullOrEmpty(condition))
                query += " Where " + condition;
            return da.Doc(query);
        }

        public List<MLop> SelectList(String condition)
        {
            DataTable tb = Select(condition);
            if (tb != null && tb.Rows.Count > 0)
            {
                List<MLop> ds = new List<MLop>();
                foreach (DataRow r in tb.Rows)
                {
                    MLop m = new MLop();
                    m.ID = r["ID"].ToString();
                    m.Ma = r["Ma"].ToString();
                    m.Ten = r["Ten"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }

        public MLop GetByID(String id)
        {
            List<MLop> ds = SelectList("ID=" + id);
            if (ds != null && ds.Count > 0)
                return ds[0];
            else
                return null;
        }

        public Boolean Exist(String ma)
        {
            DataTable tb = Select("Ma=N'" + ma.ToUpper() + "'");
            if (tb == null || tb.Rows.Count == 0)
                return false;
            else
                return true;
        }

        public int Insert(String ma, String ten)
        {
            String query = "Insert Into " + table + "(Ma, Ten) Values(N'"
                + ma.ToUpper() + "',N'"
                + ten + "')";
            return da.Ghi(query);
        }

        public int Update(String id, String ma, String ten)
        {
            String query = "Update " + table + " Set Ma=N'"
                + ma + "', Ten=N'"
                + ten + "' Where ID=" + id;
            return da.Ghi(query);
        }

        public int Delete(String id)
        {
            String query = "Delete " + table + " Where ID=" + id;
            return da.Ghi(query);
        }
    }
}
