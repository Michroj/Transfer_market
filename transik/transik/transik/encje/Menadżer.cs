using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace transik.encje
{
    public class Menadżer
    {
        public sbyte? Id { get; set; }
        public string Imię { get; set; }
        public string Nazwisko { get; set; }

        public int Wiek { get; set; }
      

        public string Narodowość { get; set; }


        public string Długośćk { get; set; }

        public string Zarobki { get; set; }
        public string Nazwaklubu { get; set; }
        public Menadżer(MySqlDataReader reader)
        {
            Id = sbyte.Parse(reader["id"].ToString());
            Imię = reader["imie"].ToString();
            Nazwisko = reader["nazwisko"].ToString();
            Wiek = int.Parse(reader["wiek"].ToString());
          

            Narodowość = reader["narodowosc"].ToString();
            Długośćk = reader["dlugosc"].ToString();
           
            Zarobki = reader["zarobki"].ToString();
            Nazwaklubu = reader["nazwa"].ToString();
        }
        public Menadżer(string imie, string nazwisko, int wiek,string narodowosc, string dlugosc, string zarobki,string nazwaklubu)
        {
            Id = null;
            Imię = imie.Trim();
            Nazwisko = nazwisko.Trim();
            Wiek = wiek;
           
            Narodowość = narodowosc;
            Długośćk = dlugosc;
           
            Zarobki = zarobki;
            Nazwaklubu = nazwaklubu;
        }

        public Menadżer(Menadżer menadżer)
        {
            Id = menadżer.Id;
            Imię = menadżer.Imię;
            Nazwisko = menadżer.Nazwisko;
            Wiek = menadżer.Wiek;
          
            Narodowość = menadżer.Narodowość;
            Długośćk = menadżer.Długośćk;
          
            Zarobki = menadżer.Zarobki;
            Nazwaklubu = menadżer.Nazwaklubu;
        }
        public string ToInsert()
        {
            return $"('{Id}', '{Imię}', {Nazwisko}'{Wiek}', , {Narodowość}',')";
        }



    }
}