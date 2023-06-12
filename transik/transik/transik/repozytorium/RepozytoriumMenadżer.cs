using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace transik.repozytorium
{
    using encje;
    public class RepozytoriumMenadżer
    {


        #region ZAPYTANIA

        static string stri = "";
        public RepozytoriumMenadżer(string sro)
        {
            stri = sro;
        }


        public RepozytoriumMenadżer()
        {

        }
        // private const string WSZYSTKIE_konta = "SELECT * FROM pilkarz";
        static string str = Program.idkl;

        #endregion
        private string WSZYSTKIE_konta = $" select menadzer.id,imie, nazwisko, wiek,  narodowosc,dlugosc,zarobki,nazwa from menadzer, kontraktm,klub where menadzer.id=kontraktm.id_menadzera AND kontraktm.id_klubu=klub.id AND kontraktm.id_klubu={str} ;";

        private string WSZYSTKIE_transfery = $"select menadzer.id,imie, nazwisko, wiek,  narodowosc,zarobki,nazwa,dlugosc from menadzer, kontraktm,klub where menadzer.id=kontraktm.id_menadzera AND kontraktm.id_klubu=klub.id AND kontraktm.id_klubu!={str } ";
    
        #region metody CRUD 
        /// <summary>
        /// CRUD - create, read, update, delete
        /// </summary>
        /// <returns></returns>


     


        public static List<Menadżer> PobierzWszystkiekonta1(RepozytoriumMenadżer rp)
        {
            List<Menadżer> osoby = new List<Menadżer>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(rp.WSZYSTKIE_konta, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    osoby.Add(new Menadżer(reader));
                connection.Close();
            }
            return osoby;
        }

        public static List<Menadżer> PobierzWszystkiekontatrans(RepozytoriumMenadżer rp, string sor)
        {
            rp.WSZYSTKIE_transfery += sor + ";";
            List<Menadżer> osobyt = new List<Menadżer>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(rp.WSZYSTKIE_transfery, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    osobyt.Add(new Menadżer(reader));
                connection.Close();
            }
            return osobyt;
        }



        public static List<Menadżer> PobierzWszystkiekontatrans(RepozytoriumMenadżer rp)
        {
            rp.WSZYSTKIE_transfery += ";";
            List<Menadżer> osobyt = new List<Menadżer>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(rp.WSZYSTKIE_transfery, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    osobyt.Add(new  Menadżer(reader));
                connection.Close();
            }
            return osobyt;
        }
        #endregion
    }
}
