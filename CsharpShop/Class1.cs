using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop
{
    internal class Prodotto
    {

        private int Codice { get; }
        private string nome;
        private string descrizione;
        private double prezzo;
        private double iva;

        public Prodotto(int Codice, string nome, string descrizione, double prezzo, double iva)
        {
            this.Codice = Codice;
            this.nome = nome;   
            this.descrizione = descrizione; 
            this.prezzo = prezzo;   
            this.iva = iva; 
        }

        public void CreaProdotto()
        {
            Random Codice = new Random();
            int CodiceProdotto = Codice.Next(99999999);
        }

        public double PrezzoBase()
        {
            Random prezzo = new Random();
          double PrezzoB = prezzo.Next(100);

            return PrezzoB;
         }
            
        public double PrezzoIva()
        {
           
            double PrezzoI = PrezzoBase() * 22 / 100;        
                return PrezzoI;
        }



        







    }
}
