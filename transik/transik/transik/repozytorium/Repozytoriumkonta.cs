using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace transik.repozytorium
{
    using encje;
    static class Repozytoriumkonta
    {
        #region ZAPYTANIA
        private const string WSZYSTKIE_konta = "SELECT id_user,login,haslo,id_klubu,nazwa,budzet FROM zaloguj,klub WHERE zaloguj.id_klubu=klub.id";
        private const string DODAJ_konto = "INSERT INTO `zaloguj`(`login`, `haslo`, `id_klubu`) VALUES ";
        #endregion

        #region metody CRUD 
        /// <summary>
        /// CRUD - create, read, update, delete
        /// </summary>
        /// <returns></returns>
        public static List<konto> PobierzWszystkiekonta()
        {
            List<konto> osoby = new List<konto>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(WSZYSTKIE_konta, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    osoby.Add(new konto(reader));
                connection.Close();
            }
            return osoby;
        }

        public static bool DodajkontoDoBazy(konto Konto)
        {
            bool stan = false;
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand($"{DODAJ_konto} {Konto.ToInsert()}", connection);
                connection.Open();
                var id = command.ExecuteNonQuery();
                stan = true;
                Konto.Id = (sbyte)command.LastInsertedId;
                connection.Close();
            }
            return stan;
        }
        #endregion
    }
}
