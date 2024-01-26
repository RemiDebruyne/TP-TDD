using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RechercheVilleTester
{
    [TestFixture]
    public class RechercheVilleTester
    {
        private RechercheVille? _rechercheVille;

        [SetUp]
        public void Setup()
        {
            List<string> liste = new()
            {
                 "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul"
            };
            _rechercheVille = new RechercheVille(liste);
        }

        [Test]
        public void WhenRecherecheVille_textLength_InferiorTo_2_Then_NotFoundException()
        {

            // Act & Assert

            Assert.Throws<NotFoundException>(() => _rechercheVille.Rechercher("a"));
        }

        [Test]
        [TestCase("Va")]
        [TestCase("va")]
        public void WhenRecherecheVille_textLength_SuperiorOrEqualTo_2_Then_Return_Villes(string texte)
        {

            // Act

            var result = _rechercheVille.Rechercher(texte);

            // Liste de teste arbitraire
            List<string> liste = new()
            {
                "Valence",
                "Vancouver",
            };

            var testList = _rechercheVille.Villes.ToList();


            // Assert
            CollectionAssert.AreEquivalent(result, liste);

            // La fonction Rechercher fonctionne correctement mais le teste fonctionne car une string vide est un subset de ma liste. Je dois changer le teste pour qu'une string vide ne fonctionne pas
            //Assert.That(result, Is.SubsetOf(testList));


        }

        [Test]
        [TestCase("va")]

        public void WhenRechercheVille_Not_CaseSensitive(string texte)
        {
            var result = _rechercheVille.Rechercher(texte);

            List<string> liste = new()
            {
                "Valence",
                "Vancouver",
            };

            CollectionAssert.AreEquivalent(liste, result);

        }
    }   /*  Implémenter une fonctionnalité de recherche de ville. La fonction prend une chaîne (texte de recherche) en entrée et renvoie les villes trouvées qui correspondent au texte de recherche.
 Exemple de villes : Paris, Budapest, Skopje, Rotterdam, Valence, Vancouver, Amsterdam, Vienne, Sydney, New York, Londres, Bangkok, Hong Kong, Dubaï, Rome, Istanbul

        Etapes du projet:
        1. Si le texte de la recherche contient moins de 2 caractères, *** Une exception est levée de type NotFoundException***.
        2. Si le texte de recherche est égal ou supérieur à 2 caractères, il doit renvoyer tous les noms de ville commençant par le texte de recherche exact.
           Par exemple, pour le texte de recherche "Va", la fonction doit renvoyer Valence et Vancouver 
        3. La fonctionnalité de recherche doit être insensible à la casse
        4. La fonctionnalité de recherche devrait également fonctionner lorsque le texte de recherche n'est qu'une partie d'un nom de ville
           Par exemple "ape" devrait renvoyer la ville "Budapest"
        5. Si le texte de recherche est un « * » (astérisque), il doit renvoyer tous les noms de ville. */
}
