using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WndApp.Model;

namespace WndApp.DAL
{
    internal class KitapDB
    {
        //1.Yontem
        //string strConn = "";

        //2.Yontem
        //dişarıdan alma...
        //ctor...

        //3.Yontem
        //dişarıdan config dosyasından alma...
        public string ConnectionString { get; set; }
        public KitapDB()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        }

        public void KitapEkle(Kitap kitap)
        { 
          
        }

    }
}
