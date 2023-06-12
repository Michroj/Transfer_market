using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace transik.encje
{
    public class Piłkarz
    {
        public sbyte? Id { get; set; }
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        
        public int Wiek { get;set; }
        public int Wzrost { get;set; }

        public string Narodowość { get; set; }

        public string Pozycja { get; set; }

        public string Wartosc { get; set; }
        public string Zarobki { get; set; }
        public string Nazwaklubu { get; set; }
        public Piłkarz(MySqlDataReader reader)
        {
            Id = sbyte.Parse(reader["id"].ToString());
            Imię= reader["imie"].ToString();
            Nazwisko= reader["nazwisko"].ToString();
            Wiek = int.Parse(reader["wiek"].ToString());
            Wzrost = int.Parse(reader["wzrost"].ToString());

            Narodowość = reader["narodowosc"].ToString();
            Pozycja = reader["pozycja"].ToString();
            Wartosc = reader["wartosc"].ToString();
            Zarobki = reader["zarobki"].ToString();
            Nazwaklubu = reader["nazwa"].ToString();
        }
        public Piłkarz(string imie, string nazwisko, int wiek,int wzrost,string narodowosc,string pozycja,string wartosc,string zarobki)
        {
            Id = null;
            Imię = imie.Trim();
            Nazwisko = nazwisko.Trim();
            Wiek = wiek;
            Wzrost = wzrost;
            Narodowość = narodowosc;
            Pozycja = pozycja;
            Wartosc = wartosc;
            Zarobki = zarobki;
        }

        public Piłkarz(Piłkarz pilkarz)
        {
            Id = pilkarz.Id;
            Imię = pilkarz.Imię;
            Nazwisko = pilkarz.Nazwisko;
            Wiek = pilkarz.Wiek;
            Wzrost = pilkarz.Wzrost;
            Narodowość = pilkarz.Narodowość;
            Pozycja = pilkarz.Pozycja;
            Wartosc=pilkarz.Wartosc;
            Zarobki = pilkarz.Zarobki;
            Nazwaklubu = pilkarz.Nazwaklubu;
        }
        public string ToInsert()
        {
            return $"('{Id}', '{Imię}', {Nazwisko}'{Wiek}', '{Wzrost}', {Narodowość}','{Pozycja})";
        }

        public string Tocontact(string Idk,string dlugosc,string id_klubu)
        {
            return $"('{Idk}','{Wartosc}','{dlugosc}','{Zarobki}','{Id}','{id_klubu}')";
        }

    }
}
