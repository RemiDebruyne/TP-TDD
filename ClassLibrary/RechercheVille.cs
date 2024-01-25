using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class RechercheVille
    {
        private List<string> _villes = new() { "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul" };

        public List<string> Rechercher(string texte)
        {
            //List<string> liste = new();

            if (texte.Length > 2)
                throw new NotImplementedException();
            return null;

            //string[] arr = texte.Split(' ');
            //foreach (var mot in arr)
            //{
            //    if (_villes.Contains(mot))
            //        liste.Add(mot);
            //}
            //return liste;


        }
    }
}
