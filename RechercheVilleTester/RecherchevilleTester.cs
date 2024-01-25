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
        private RechercheVille? _rVille;

        [SetUp]
        public void Setup()
        {
           
            _rVille = new RechercheVille();
        }

        [Test]
        public void RecherecheVille_textLength_InferiorTo_2()
        {
            // Arrange
            // Setup()



            // Act & Assert

            Assert.Throws<NotFoundException>(() => _rVille.Rechercher("a"));
        }

        [Ignore("A test plus tard")]
        [Test]
        public void RecherecheVille_textLength_SuperiorOrEqualTo_2_Return_Villes()
        {
            // Arrange
            // Setup()

            // Act

            var result = _rVille.Rechercher("Pa");

            // Assert

            Assert.IsTrue(result.Count >= 2);

        }
    }

    /*  Implémenter une fonctionnalité de recherche de ville. La fonction prend une chaîne (texte de recherche) en entrée et renvoie les villes trouvées qui correspondent au texte de recherche.
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
