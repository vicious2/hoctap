using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using QL_NhaSach.ThuVienLop.DTO;

namespace QL_NhaSach.ThuVienLop.DAL
{
    public class SachDAL
    {
        public string filename = "../../Nha_sach.xml";
        // phuong thuc dung de chon tat ca sach trong tai lieu xml
        public List<Sach> selectAll()
        {
            XmlDocument tai_lieu = new XmlDocument();
            tai_lieu.Load(filename);
            XmlNodeList books =  tai_lieu.SelectNodes("/PN/book");
            List<Sach> lstKq = new List<Sach>();
            foreach (XmlNode book in books)
            {
                Sach x = new Sach();
                x.Id = book.Attributes["ID"].Value;
                x.Title = book.ChildNodes[0].InnerText;
                x.Author = book.ChildNodes[1].InnerText;
                x.Price = int.Parse(book.ChildNodes[2].InnerText);
                lstKq.Add(x);
            }
            return lstKq;
        }
        //phuong thuc them 1 sach vao tai lieu xml
        public void Insert(Sach x)
        {
            XmlDocument tai_lieu = new XmlDocument();
            tai_lieu.Load(filename);

            XmlElement book = tai_lieu.CreateElement("book");
            book.SetAttribute("ID", x.Id);
            XmlElement title = tai_lieu.CreateElement("title");
            title.InnerText = x.Title;
            XmlElement author = tai_lieu.CreateElement("author");
            author.InnerText = x.Author;
            XmlElement price = tai_lieu.CreateElement("price");
            price.InnerText = x.Price.ToString();
            book.AppendChild(title);
            book.AppendChild(author);
            book.AppendChild(price);

            XmlElement goc = tai_lieu.DocumentElement;
            goc.AppendChild(book);
            tai_lieu.Save(filename);
        }

        //phuong thuc sua sach trong tai lieu xml
        public void Update(Sach x)
        {
            XmlDocument tai_lieu = new XmlDocument();
            tai_lieu.Load(filename);
            //truy van sach can update
            XmlNode book = tai_lieu.SelectSingleNode("//book[@ID='" + x.Id + "']");
            //cap nhat lai noi dung 
            if (book != null)
            {
                book.ChildNodes[0].InnerText = x.Title;
                book.ChildNodes[1].InnerText = x.Author;
                book.ChildNodes[2].InnerText = x.Price.ToString();
            }
            tai_lieu.Save(filename);
        }

        //phuong thuc xoa 1 sach trong tai lieu xml
        public void Delete(string id)
        {
            XmlDocument tai_lieu = new XmlDocument();
            tai_lieu.Load(filename);
            //truy van sach can xoa
            XmlNode book = tai_lieu.SelectSingleNode("//book[@ID='" + id + "']");
            if (book != null)
            {
                XmlNode parent = book.ParentNode;
                parent.RemoveChild(book);
            }
            tai_lieu.Save(filename);
        }



    }
}
