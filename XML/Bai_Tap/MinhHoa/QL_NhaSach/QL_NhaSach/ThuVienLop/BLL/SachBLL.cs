using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_NhaSach.ThuVienLop.DTO;
using QL_NhaSach.ThuVienLop.DAL;

namespace QL_NhaSach.ThuVienLop.BLL
{
    public class SachBLL
    {
        public static List<Sach> selectAll()
        {
            SachDAL sach_dal = new SachDAL();
            return sach_dal.selectAll();  
        }

        public static void Insert(Sach x)
        {
            SachDAL sach_dal = new SachDAL();
            sach_dal.Insert(x);
        }

        public static void Update(Sach x)
        {
            SachDAL sach_dal = new SachDAL();
            sach_dal.Update(x);
        }

        public static void Delete(string id)
        {
            SachDAL sach_dal = new SachDAL();
            sach_dal.Delete(id);
        }
    }
}
