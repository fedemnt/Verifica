using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{
    class Libro
    {
        public string autore;
        public string titolo;
        public DateTime annoPubblicazione;
        public string editore;
        public int numeroPagine;

        public Libro(string autore, string titolo, DateTime annoPubblicazione, string editore, int numeroPagine)
        {
            this.autore = autore;
            this.titolo = titolo;
            this.annoPubblicazione = annoPubblicazione;
            this.editore = editore;
            this.numeroPagine = numeroPagine;
        }

        public string toString()
        {
            return ("L'autore del libro è" + autore + "il titolo è" + titolo + "l'anno di pubblicazione è" + annoPubblicazione + "l'editore è" + editore + "il numero di pagine è" + numeroPagine);
        }
        public int readingTime()
        {
            if (numeroPagine < 100)
            {
                return 60;
            }
            else if (numeroPagine > 100 && numeroPagine < 200)
            {
                return 120;
            }
            else if (numeroPagine > 200)
            {
                return 150;
            }
            return 0;
        }
    }
    class Biblioteca
    {
        public string nome;
        public string indirizzo;
        public DateTime orarioApertura;
        public DateTime orarioChiusura;
        public Biblioteca(string nome, string indirizzo, DateTime orarioApertura, DateTime orarioChiusura)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.orarioApertura = orarioApertura;
            this.orarioChiusura = orarioChiusura;
        }
    }
}
