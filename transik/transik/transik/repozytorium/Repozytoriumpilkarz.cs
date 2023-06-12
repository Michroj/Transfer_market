using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace transik.repozytorium
{
    using encje;
    public class RepozytoriumPiłkarz
    {


        #region ZAPYTANIA

        static string stri = "";
        public RepozytoriumPiłkarz(string sro)
        {
           stri = sro; 
        }


        public RepozytoriumPiłkarz()
        {
            
        }
        // private const string WSZYSTKIE_konta = "SELECT * FROM pilkarz";
        static string str = Program.idkl;
        private string DODAJ_konto = "INSERT INTO `pilkarz`(`imie`, `nazwisko`, `wiek`,`wzrost`,`narodowosc`,`pozycja`) VALUES ";
        private string DODAJ_kontrakt = "INSERT INTO `kontraktp`(`id`, `wartosc`, `dlugosc`,`zarobki`,`id_pilkarza`,`id_klubu`) VALUES ";
        #endregion
        private string WSZYSTKIE_konta = $" select pilkarz.id,imie, nazwisko, wiek, wzrost, narodowosc, pozycja, wartosc,zarobki,nazwa from pilkarz, kontraktp,klub where pilkarz.id=kontraktp.id_pilkarza AND kontraktp.id_klubu=klub.id AND kontraktp.id_klubu={str} ;";

        private string WSZYSTKIE_transfery = $" select pilkarz.id,imie, nazwisko, wiek, wzrost, narodowosc, pozycja, wartosc,zarobki,nazwa from pilkarz, kontraktp,klub where pilkarz.id=kontraktp.id_pilkarza AND kontraktp.id_klubu=klub.id AND id_klubu!={str} ";
        #region metody CRUD 
        /// <summary>
        /// CRUD - create, read, update, delete
        /// </summary>
        /// <returns></returns>

        


        public static bool DodajkontoDoBazy1(Piłkarz Konto,RepozytoriumPiłkarz rp)
        {
            bool stan = false;
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand($"{rp.DODAJ_konto} {Konto.ToInsert()}", connection);
                connection.Open();
                var id = command.ExecuteNonQuery();
                stan = true;
                Konto.Id = (sbyte)command.LastInsertedId;
                connection.Close();
            }
            return stan;
        }



        public static List<Piłkarz> PobierzWszystkiekonta1(RepozytoriumPiłkarz rp)
        {
            List<Piłkarz> osoby = new List<Piłkarz>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(rp.WSZYSTKIE_konta, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    osoby.Add(new Piłkarz(reader));
                connection.Close();
            }
            return osoby;
        }

        public static List<Piłkarz> PobierzWszystkiekontatrans(RepozytoriumPiłkarz rp,string sor)
        {
            rp.WSZYSTKIE_transfery += sor+";";
            List<Piłkarz> osobyt = new List<Piłkarz>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(rp.WSZYSTKIE_transfery, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    osobyt.Add(new Piłkarz(reader));
                connection.Close();
            }
            return osobyt;
        }



        public static List<Piłkarz> PobierzWszystkiekontatrans(RepozytoriumPiłkarz rp)
        {
            rp.WSZYSTKIE_transfery +=  ";";
            List<Piłkarz> osobyt = new List<Piłkarz>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(rp.WSZYSTKIE_transfery, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    osobyt.Add(new Piłkarz(reader));
                connection.Close();
            }
            return osobyt;
        }
        #endregion
    }
}