using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            

        }

        // classe Item
        public class Item
        {
            // Création de 3 propriétés identifiant, nom et nombre
            public string Table { get; set; }
            public int IdItem { get; set; }
            public string Name { get; set; }
            public string Num { get; set; }

            // Constructeur
            public Item()
            {
            }

        }

        public class Bdd
        {

            private MySql.Data.MySqlClient.MySqlConnection connection;

            // Constructeur
            public Bdd()
            {
                this.InitConnexion();
            }

            // Méthode pour initialiser la connexion
            private void InitConnexion()
            {
                // Création de la chaîne de connexion
                string connectionString = "SERVER=localhost; DATABASE=kitbox; UID=root; PASSWORD='' ";
                this.connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            }

            // Méthode pour ajouter un Item existant
            public void AddItem(Item item)
            {
                try
                {
                    // Ouverture de la connexion SQL
                    this.connection.Open();

                    // Création d'une commande SQL en fonction de l'objet connection
                    MySql.Data.MySqlClient.MySqlCommand cmd = this.connection.CreateCommand();

                    // Requête SQL
                    //Je récupère le nombre de pièces éxistantes
                    //j'y additionne le nombre de pièces à ajouter 
                    //Je met à jour la nombre de pièces
                    cmd.CommandText = "INSERT INTO @Table (IdExtrusion, Dimensions, height,color, InStock,StockMin,Price,AvailableParts) VALUES(@IdItem,,6547,Xenon,56,32,5,123); ";

                    // utilisation de l'objet item passé en paramètre
                    //cmd.Parameters.AddWithValue("@id", item.IdItem);
                    //cmd.Parameters.AddWithValue("@Num", item.Num);
                    

                    // Exécution de la commande SQL
                    cmd.ExecuteNonQuery();

                    // Fermeture de la connexion
                    this.connection.Close();
                }
                catch
                {
                    // Gestion des erreurs :
                    // Possibilité de créer un Logger pour les exceptions SQL reçus
                    // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.

                }
            }
        }
    
       

    }
}
