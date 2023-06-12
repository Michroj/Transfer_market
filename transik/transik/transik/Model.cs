using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transik
{
    using encje;
    using repozytorium;
    using static Form3;
   internal class Model
    {
        public string stro = "";
       public   List<Piłkarz> Piłkarze { get; set; } = new List<Piłkarz>();
      
       public  List<konto> Konta { get; set; } = new List<konto>();

        public List<Piłkarz> Piłkarzet { get; set; } = new List<Piłkarz>();

        public List<Menadżer> Menadżert { get; set; } = new List<Menadżer>();
        public List<Menadżer> Menadżer { get; set; } = new List<Menadżer>();
        public void kon(string STRO)
        {
            this.stro = STRO;
        }
        public Model(string sro)
        {
           
           
        }
      

        public void STP0()
        {

            var konta = Repozytoriumkonta.PobierzWszystkiekonta();
            foreach (var o in konta)
                Konta.Add(o);


        }
        public void STP1()
        {
            RepozytoriumMenadżer rm = new RepozytoriumMenadżer();
            var kontap3 = RepozytoriumMenadżer.PobierzWszystkiekonta1(rm);
            foreach (var p in kontap3)
                    Menadżer.Add(p);


        }
        public void STP(string sro)
        {
            RepozytoriumMenadżer rm = new RepozytoriumMenadżer(sro);
            var kontap3 = RepozytoriumMenadżer.PobierzWszystkiekontatrans(rm, sro);
            foreach (var p in kontap3)
                Menadżert.Add(p);
           

        }
        public void STP5()
        {

            RepozytoriumPiłkarz rp = new RepozytoriumPiłkarz();


            var kontap = RepozytoriumPiłkarz.PobierzWszystkiekonta1(rp);
            foreach (var o in kontap)
                Piłkarze.Add(o);


        }
        public void STP6(string sro)
        {
            RepozytoriumPiłkarz rp = new RepozytoriumPiłkarz(sro);
            var kontap2 = RepozytoriumPiłkarz.PobierzWszystkiekontatrans(rp, sro);

            foreach (var o in kontap2)
                Piłkarzet.Add(o);


        }
        public Model()
        {
           
    

        }
        public bool zalog(string login, string haslo)
        {
            foreach (var k in Konta)
            {
                if (k.check1(login, haslo)) 
                {

                    Program.idkl = k.id_klubu.ToString();
                    Program.nazwaklubu = k.nazwaklubu.ToString();
                    Program.budzet = k.budzet.ToString();
                    MessageBox.Show("zalogowano pomyślnie");
                    return true;
                
                }


            }
            MessageBox.Show("błąd logowania");
            return false;
        }
    }
}
