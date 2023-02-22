using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_NhaSach.ThuVienLop.DTO
{
   public class Sach
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        private string _author;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }



    }
}
