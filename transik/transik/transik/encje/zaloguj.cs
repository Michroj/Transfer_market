using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace transik.encje
{
    internal class konto
    {
        public sbyte? Id { get; set; }
        public string login { get; set; }
        public string haslo { get; set; }
        public sbyte? id_klubu { get; set; }

        public string nazwaklubu { get; set; }

        public string budzet { get; set; }
        public konto(MySqlDataReader reader)
        {
            Id = sbyte.Parse(reader["id_user"].ToString());
            login = reader["login"].ToString();
            haslo = reader["haslo"].ToString();
            id_klubu = sbyte.Parse(reader["id_klubu"].ToString());
            nazwaklubu = reader["nazwa"].ToString();
            budzet = reader["budzet"].ToString();
        }
        public konto(string Login, string Haslo, sbyte Id_klubu,string Nazwaklubu,string Budzet)
        {
            Id = null;
            login = Login.Trim();
            haslo = Haslo.Trim();
            id_klubu = Id_klubu;
            nazwaklubu = Nazwaklubu.Trim();
            budzet = Budzet;

        }

        public konto(konto Konto)
        {
            Id = Konto.Id;
            login = Konto.login;
            haslo = Konto.haslo;
            id_klubu = Konto.id_klubu;
            nazwaklubu = Konto.nazwaklubu;
            budzet = Konto.budzet;

        }
        public string ToInsert()
        {
            return $"('{login}', '{haslo}', {id_klubu})";
        }

        public bool check1(string LG, string PSW)
            {
            if(this.login!=LG)
              return false;
            if (this.haslo != PSW)
                return false;
            return true;
        }


    }
}
