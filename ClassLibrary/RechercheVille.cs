using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class RechercheVille
    {
        private List<string> _villes;
        public List<string> Villes { get => _villes; set => _villes = value; }
        public RechercheVille(List<string> ville)
        {
            Villes = ville;
        }


        public List<string> Rechercher(string texte)
        {
            List<string> liste = new();

            if (texte.Length < 2)
                throw new NotFoundException("Veuillez entrer un text d'au moins deux caractères");

            //string[] arr = texte.Split(' ');
            if (texte.Length >= 2)
            {
                foreach (string ville in Villes)
                {

                    if (ville.ToLower().StartsWith(texte.ToLower()) || ville.ToLower().Contains(texte.ToLower()))
                        
                        liste.Add(ville);
                }

            }
                return liste;
            //throw new NotImplementedException();



        }
    }
}
