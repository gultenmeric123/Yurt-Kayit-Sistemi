﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 

namespace YurtKayitSistemi
{
    public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-CHVDTKO4\\SQLEXPRESS;Initial Catalog=YurtKayıt;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}

