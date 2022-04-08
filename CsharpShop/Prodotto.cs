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


        public Prodotto( string nome, string descrizione, double prezzo) //Costruttore 1
        {
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
        }

        public Prodotto(int Codice, string nome, string descrizione, double prezzo, double iva) //Costruttore Completo
        {
            this.Codice = Codice;
            this.nome = nome;   
            this.descrizione = descrizione; 
            this.prezzo = prezzo;   
            this.iva = iva; 
        }

        public int  CreaCodiceProdotto()
        {
            Random Codice = new Random();
            int CodiceProdotto = Codice.Next(99999999);
            return CodiceProdotto;  
        }

       /* public double PrezzoBase()
        {
            Random prezzo = new Random();
          double PrezzoB = prezzo.Next(100);

            return PrezzoB;
         }
       */
            
        public double CalcolaPrezzoIva( double prezzo)
        { 
           
            double IVA = prezzo * 22 / 100;
            double PrezzoIVA = prezzo + IVA;
                return PrezzoIVA;
        }

         public void StampaProdottoIntero()
        {
            Console.WriteLine("---------- PRODOTTO ----------");
            Console.WriteLine("CODE: " +CreaCodiceProdotto());
            Console.WriteLine("NOME: " +nome);
            Console.WriteLine("Descrizione: " +descrizione) ;
            Console.WriteLine("PREZZO (NO IVA): " + prezzo);
            Console.WriteLine("PREZZO (IVA): " +CalcolaPrezzoIva(prezzo));

            Console.WriteLine("------------------------------");
        }

        







    }
}
