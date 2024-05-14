using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Banque
    {
        public string Nom { get; set; }

        private Dictionary<string,Courant> _comptes = new Dictionary<string, Courant>();

        public Courant this[string numero]
        {
            get {
                /*_comptes.TryGetValue(numero, out Courant c);
                return c;*/
                if (!_comptes.ContainsKey(numero)) return null;
                return _comptes[numero];
            }
            //Pas besoin de set dans ce context car juste de la récupération
            private set
            {
                if (value is null) return;
                if (value.Numero != numero) return;
                if (_comptes.ContainsKey(numero)) _comptes[numero] = value;
                else Ajouter(value);
            }
        }

        public void Ajouter(Courant compte)
        {
            if (compte is null) return;
            if (_comptes.ContainsKey(compte.Numero)) return; 
            _comptes.Add(compte.Numero, compte);
        }

        public void Supprimer(string numero)
        {
            if (numero is null) return;
            if (!_comptes.ContainsKey(numero)) return;
            _comptes.Remove(numero);
        }
    }
}
