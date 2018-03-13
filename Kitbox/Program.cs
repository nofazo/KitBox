using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Kitbox
{
    public class CupBoard
    {
        public double width;
        public double depth;
        //public int lockerNumber;
        public List<Locker> lockerList;
        public Extrusion extrusion;
        //liste cornière après, pas besoin de liste comme mêmes cornières (prix *4)

        public CupBoard (double width, double depth, List<Locker> lockerList, Extrusion extrusion )
        {
            this.width = width;
            this.depth = depth;
            this.lockerList = lockerList;
            this.extrusion = extrusion;
        }

        public double GetPrice()
        {
            double lockerPrice = 0;
            foreach (Locker locker in lockerList)
            {
                lockerPrice += locker.GetPrice();
            }

            double extrusionPrice = extrusion.GetPrice();

            return lockerPrice + 4*extrusionPrice ;
        }
    }

    public class Extrusion
    {
        public string color;
        public double height;
        public double price;

        public Extrusion (string color, double height)
        {
            this.color = color;
            this.height = height;           
        }

        public double GetPrice()
        {
            return price;
        }

    }

    public class CutExtrusion : Extrusion
    {
        public CutExtrusion (string color, double height) : base (color, height)
        {

        }
    }


    public class Locker
    {
        public double lockerHeight;
        public string color;
        public List<Accessory> accessoryList;

        public Locker (List<Accessory> accessoryList, double lockerHeight, string color)
        {
            this.accessoryList = accessoryList;
            this.lockerHeight = lockerHeight;
            this.color = color;
        }


        public double GetPrice()
        {
            double result = 0;

            foreach (Accessory elem in accessoryList)
            {
                result += elem.GetPrice();
            }

            return result;
        }

        public void AddAccessory(Accessory accessory)
        {
            accessoryList.Add(accessory);
        }

        public void RemoveAccessory(Accessory accessory)
        {
            //supprimer accessoire dans la liste
        }

        public void UpdateAccessory(Accessory accessory)
        {
            //+ de paramètre pour les variables spécifiques à changer?
        }
    }

    public class Order 
    {
        public CupBoard cubBoard;
        public int id;
        public string NameClient;

        public void GetRecapitulatif()
        {
            foreach (Locker locker in cubBoard.lockerList)
            {              
                int i = 1;
                Console.WriteLine("Casier n°" + i);               // afficher casier n°i :
                Console.WriteLine(); // afficher cornière + id + x4 + prix unitaire + prix tot
                i += 1;

                foreach (Accessory accessory in locker.accessoryList)
                {
                    //afficher accessory.name + accessory.GetPrice();
                    // nom + id + quantité + prix unitaire + prix totale 
                    //nom + id + prix unitaire de l'accessoire à prendre de la bdd? 
                    // ajouter une variable "quantité?"
                    // attention responsabilité unique
                }
            }

            Console.WriteLine("Total : " + cubBoard.GetPrice() );
        }

        public double GetTotalPrice(int quantity, double price)
        {
            return quantity * price;
        }


    }
   
    public class Bill  //facture
    {
        public string date;
        public CupBoard cubBoard;

        public void GetDetailPart()
        {
            string path = @"/Users/User/source/DetailPart.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (Locker locker in cubBoard.lockerList)
                {
                    int i = 1;
                    sw.WriteLine("Casier n°" + i);               // afficher casier n°i :
                    sw.WriteLine(); // afficher cornière + id + x4 + prix unitaire + prix tot
                    i += 1;

                    foreach (Accessory accessory in locker.accessoryList)
                    {
                        //afficher accessory.name + accessory.GetPrice();
                        // nom + id + quantité + prix unitaire + prix totale 
                        //nom + id + prix unitaire de l'accessoire à prendre de la bdd? 
                        // ajouter une variable "quantité?"
                        // attention responsabilité unique
                    }
                }

                sw.WriteLine("Total : " + cubBoard.GetPrice());
            }
        }  
        

        public void GetBill()
        {
            string path = @"/Users/User/source/Bill.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (Locker locker in cubBoard.lockerList)
                {
                    sw.WriteLine(locker.color + locker.GetPrice() );   // sprint 3:faire distinction entre casier avec porte et casier sans porte
                }

                sw.WriteLine("Total" + cubBoard.GetPrice());
            }
        }

    }

    public abstract class Accessory
    {
       // public double price;
       // public bool isMajor;

        public abstract double GetPrice();
        public abstract bool IsMajor();
    }

    public class Door : Accessory
    {
        public double height;
        public double width;
        public string material;
        public double price;
        public bool isMajor = false;

        public Door (double height, double width, string material)
        {
            this.height = height;
            this.width = width;
            this.material = material;
        }

        public override double GetPrice()
        {
            return price;
        }

        public override bool IsMajor()
        {
            return isMajor;
        }
    }

    public class GlassDoor : Door
    {
       new  public double price;

        public GlassDoor (double height, double width, string material) : base (height, width, material)
        {

        }

        public override double GetPrice()
        {
            return price;
        }
    }

    public class NormalDoor : Door
    {
        public double cabinetHandlePrice;
        new public double price;
        public string color;

        public NormalDoor(double height, double width,string material, string color) : base (height, width, material)
        {
            this.color = color;
        }

        public override double GetPrice()
        {
            return price;
        }
    }

    public class Cleat: Accessory
    {
        public double height;
        public double price;
        public bool isMajor = true;

        public Cleat(double height)
        {
            this.height = height;
        }

        public override double GetPrice()
        {
            return price;
        }

        public override bool IsMajor()
        {
            return isMajor;
        }
    }

    public class Rail : Accessory
    {
        public double price;
        public bool isMajor = true;

        public Rail()
        {

        }

        public override double GetPrice()
        {
            return price;
        }

        public override bool IsMajor()
        {
            return isMajor;
        }
    }

    public class ARAVrail : Rail
    {
        public double width;

        public ARAVrail(double width)
        {
            this.width = width;
        }
    }

    public class GDrail : Rail
    {
        public double depth;

        public GDrail(double depth)
        {
            this.depth = depth;
        }
    }


    public class Panel : Accessory
    {
        public string color;
        public double price;
        public bool isMajor = true;

        public Panel(string color)
        {
            this.color = color;
        }

        public override double GetPrice()
        {
            return price;
        }

        public override bool IsMajor()
        {
            return isMajor;
        }

    }

    public class ARpanel : Panel
    {
        public double width;
        public double height;

        public ARpanel(string color, double width, double height) : base (color)
        {
            this.width = width;
            this.height = height;
        }
    }

    public class GDpanel : Panel
    {
        public double depth;
        public double height;

        public GDpanel(string color, double depth, double height) : base(color)
        {
            this.depth = depth;
            this.height = height;
        }
    }

    public class HBpanel : Panel
    {
        public double depth;
        public double width;

        public HBpanel(string color, double depth, double width) : base(color)
        {
            this.depth = depth;
            this.width = width;
        }
    }


    public class interfacee
    {
        List<Locker> lockerList = new List<Locker>(); // static ou pas? à chaque fois que l'appli se lance la liste est remise à 0

        public void CasierOk( double hauteur, string couleur, double profondeur, double largeur, bool porte, string materiau, string couleur2)
        {
            List<Accessory> list = new List<Accessory>() ;

            double hauteurTasseau = hauteur - 4; // en cm

            HBpanel HBpanell = new HBpanel(couleur, profondeur, largeur);
            list.Add(HBpanell);

            GDpanel GDpanell = new GDpanel(couleur, profondeur, hauteurTasseau);
            list.Add(GDpanell);

            ARpanel ARpanell = new ARpanel(couleur, largeur, hauteurTasseau);
            list.Add(ARpanell);

            ARAVrail ARAVraill = new ARAVrail(largeur);   //x2
            list.Add(ARAVraill);

            GDrail GDraill = new GDrail(profondeur);     //x2
            list.Add(GDraill);

            Cleat cleatt = new Cleat(hauteurTasseau);           //x4
            list.Add(cleatt);


            if (largeur < 62)
            {
                // présenter le champ "door" dans l'interface 
                // penser à afficher un message dans la fenêtre 1 pour avertir des limitations des largeurs pour les portes

                if (materiau == "Verre")
                {
                    GlassDoor glassDoor = new GlassDoor(hauteur, largeur, materiau); // materiau sert à rien?
                    list.Add(glassDoor);
                }

                else
                {
                    NormalDoor normalDoor = new NormalDoor(hauteur, largeur, materiau = "bois", couleur2);
                    list.Add(normalDoor);

                }
            }

            Locker Casier = new Locker(list, hauteur, couleur);         // ouu Casier.AddAccessory(cleatt);
            lockerList.Add(Casier);                                             // attention problème tous les casiers même nom à résoudre 
                                                                                //pas besoin? les ajouter dans une liste directlyy
                                                                                //hauteur = hauteur casier entré dans l'interface
                                                                                //meilleur manière de rassembler les casier dans une liste
                                                                                // choisir éléments bdd (décrémenter)                                                                              
                                                                                //boucle avec interface
                                                                                //BDD
                                                                                //gérer les erreures
                                                                                //cornière découpée
        }

        public double GetTotalHeight()  // où placer cette methode? besoin d'une liste de casiers. Laisser dans le main?
        {
            double height = 0;
            foreach (Locker locker in lockerList)
            {
                height += locker.lockerHeight;  // mettre la variable en pv et ajouter une methode GetLockerHeight
            }
            return height;
        }

        public void ValiderArmoire(string couleur, double largeur, double profondeur) // largeur et profondeur à récupérer des pages précédentes
        {
            double totalHeight = GetTotalHeight();
            Extrusion cornière = new Extrusion(couleur, totalHeight);  // informer l'utilisateur s'il s'agit d'une cornière découpée
            CupBoard armoire = new CupBoard(largeur, profondeur, lockerList,cornière);
        }
    }
}
