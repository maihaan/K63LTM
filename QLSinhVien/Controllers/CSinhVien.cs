using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QLSinhVien.DataAccess;
using QLSinhVien.Models;
using System.Data;

namespace QLSinhVien.Controllers
{
    public class CSinhVien
    {
        DataAccess.DataAccess da = new DataAccess.DataAccess();
        String table = "tbSinhVien";

        public DataTable Select(String condition)
        {
            String query = "Select * From " + table;
            if (!String.IsNullOrEmpty(condition))
                query += " Where " + condition;
            return da.Doc(query);
        }

        public List<MSinhVien> SelectList(String condition)
        {
            DataTable tb = Select(condition);
            if (tb != null && tb.Rows.Count > 0)
            {
                List<MSinhVien> ds = new List<MSinhVien>();
                foreach (DataRow r in tb.Rows)
                {
                    MSinhVien m = new MSinhVien();
                    m.ID = r["ID"].ToString();
                    m.Ma = r["Ma"].ToString();
                    m.Ten = r["Ten"].ToString();
                    m.NgaySinh = DateTime.Parse(r["NgaySinh"].ToString()).ToString("dd/MM/yyyy");
                    m.DienThoai = r["DienThoai"].ToString();
                    m.Email = r["Email"].ToString();
                    m.MaLop = r["MaLop"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }

        public MSinhVien GetByID(String id)
        {
            List<MSinhVien> ds = SelectList("ID=" + id);
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

        public int Insert(String ma, String ten, DateTime ngaySinh, 
            String dienThoai, String email, String maLop)
        {
            String query = "Insert Into " + table 
                + "(Ma, Ten, NgaySinh, DienThoai, Email, MaLop) Values(N'"
                + ma.ToUpper() + "',N'"
                + ten + "',N'"
                + ngaySinh.ToString("MM/dd/yyyy") + "',N'"
                + dienThoai + "',N'"
                + email + "',N'"
                + maLop + "')";
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
