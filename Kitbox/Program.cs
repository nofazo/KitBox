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
        private double width;

        private double depth;

        private List<Locker> lockerList;

        private Extrusion extrusion;

        //liste cornière après, pas besoin de liste comme mêmes cornières (prix *4)


        public CupBoard(int width, int depth, List<Locker> lockerList, Extrusion extrusion)

        {

            this.width = width;

            this.depth = depth;

            this.lockerList = lockerList;

            this.extrusion = extrusion;

        }

        public List<Locker> GetLockerList()
        {
            return this.lockerList;
        }

        public void SetLockerList(List<Locker> newLockerList)
        {
            this.lockerList = newLockerList;
        }


        public Extrusion GetExtrusion()
        {
            return this.extrusion;
        }

        public void SetExtrusion(Extrusion newExtrusion)
        {
            this.extrusion = newExtrusion;
        }


        public double GetWidth()
        {
            return this.width;
        }

        public void SetWidth( double newWidth)
        {
            this.width = newWidth;
        }


        public double GetDepth()
        {
            return this.depth;
        }

        public void SetDepth(double newDepth)
        {
            this.depth = newDepth;
        }


        public double GetPrice()

        {

            double lockerPrice = 0;

            foreach (Locker locker in lockerList)

            {

                lockerPrice += locker.GetPrice();

            }



            double extrusionPrice = extrusion.GetPrice();



            return lockerPrice + 4 * extrusionPrice;

        }

        public double GetTotalHeight()  
        {

            double height = 0;

            foreach (Locker locker in lockerList)

            {

                height += locker.GetLockerHeight();  

            }

            return height;

        }

        public void AddLocker(Locker locker)
        {
            this.lockerList.Add(locker);
        }

        //RemoveLastLocker?
        //Remove un locker en particulier, comment ? parcourir et regarder les caractéristiques qui match ?
    }



    public class Extrusion

    {

        private string color;

        private double height;

        private double price;



        public Extrusion(string color, double height)

        {

            this.color = color;

            this.height = height;

        }


        public string GetColor()
        {
            return this.color;
        }

        public void SetColor(string newColor)
        {
            this.color = newColor;
        }


        public double GetHeight()
        {
            return this.height;
        }

        public void SetHeight(double newHeight)
        {
            this.height = newHeight;
        }


        public double GetPrice()

        {
            return price;
        }

    }



    public class CutExtrusion : Extrusion

    {

        public CutExtrusion(string color, double height) : base(color, height)
        {

        }

    }





    public class Locker

    {

        private double lockerHeight;

        private string color;

        private List<Accessory> accessoryList;



        public Locker(List<Accessory> accessoryList, double lockerHeight, string color)

        {

            this.accessoryList = accessoryList;

            this.lockerHeight = lockerHeight;

            this.color = color;

        }

        public List<Accessory> GetAccessoryList()
        {
            return this.accessoryList;
        }

        public void SetAccessoryList(List<Accessory> newAccessList)
        {
            this.accessoryList = newAccessList;
        }


        public double GetLockerHeight()
        {
            return this.lockerHeight;
        }

        public void SetLockerHeight(double newLockerHeight)
        {
            this.lockerHeight = newLockerHeight;
        }


        public string GetColor()
        {
            return this.color;
        }

        public void SetColor(string newColor)
        {
            this.color = newColor;
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

        private CupBoard cubBoard;

        private int id;

        private string NameClient;



        public void GetRecapitulatif()
        {

            foreach (Locker locker in cubBoard.GetLockerList())
            {

                int i = 1;

                Console.WriteLine("Casier n°" + i);               // afficher casier n°i :

                Console.WriteLine(); // afficher cornière + id + x4 + prix unitaire + prix tot

                i += 1;



                foreach (Accessory accessory in locker.GetAccessoryList())
                {

                    //afficher accessory.name + accessory.GetPrice();

                    // nom + id + quantité + prix unitaire + prix totale 

                    //nom + id + prix unitaire de l'accessoire à prendre de la bdd? 

                    // ajouter une variable "quantité?"

                    // attention responsabilité unique

                }

            }



            Console.WriteLine("Total : " + cubBoard.GetPrice());

        }



        public double GetTotalPrice(int quantity, double price)
        {

            return quantity * price;

        }


        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetidOrder()
        {
            return this.id;
        }

    }



    public class Bill  //facture
    {

        private string date;

        private CupBoard cubBoard;



        public void GetDetailPart()
        {

            string path = @"/Users/User/source/DetailPart.txt";

            using (StreamWriter sw = File.CreateText(path))
            {

                foreach (Locker locker in cubBoard.GetLockerList())
                {

                    int i = 1;

                    sw.WriteLine("Casier n°" + i);               // afficher casier n°i :

                    sw.WriteLine(); // afficher cornière + id + x4 + prix unitaire + prix tot

                    i += 1;



                    foreach (Accessory accessory in locker.GetAccessoryList())
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

                foreach (Locker locker in cubBoard.GetLockerList())

                {

                    sw.WriteLine(locker.GetColor() + locker.GetPrice());   // sprint 3:faire distinction entre casier avec porte et casier sans porte

                }



                sw.WriteLine("Total" + cubBoard.GetPrice());

            }

        }



    }



    public abstract class Accessory
    {

        // public double price;

        // public bool isMajor;

        private string type;

        public abstract double GetPrice();

        public abstract bool IsMajor();

        public string GetAccessType()
        {
            return this.type;          
        }

    }



    public class Door : Accessory
    {

        private double price;

        private bool isMajor = false;


        public Door()
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



    public class GlassDoor : Door
    {

        new private double price;
        new private string type = "glassDoor";


        public GlassDoor()
        {

        }



        public override double GetPrice()
        {

            return price;

        }

    }



    public class NormalDoor : Door
    {

        private double cabinetHandlePrice;

        private double price;

        private string color;

        private string type = "normalDoor";

        public NormalDoor(string color)
        {

            this.color = color;

        }

        public string GetColor()
        {
            return this.color;
        }

        public void SetColor(string newColor)
        {
            this.color = newColor;
        }


        public override double GetPrice()
        {

            return price;

        }

    }



    public class Cleat : Accessory
    {

        private double height;

        private double price;

        private bool isMajor = true;

        private string type = "cleat";

        public Cleat(double height)
        {

            this.height = height;

        }

        public double GetHeight()
        {
            return this.height;
        }

        public void SetHeight(double newHeight)
        {
            this.height = newHeight;
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

        private double price;

        private bool isMajor = true;

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

        private double width;
        private string type = "ARAVrail";


        public ARAVrail(double width)

        {

            this.width = width;

        }

        public double GetWidtht()
        {
            return this.width;
        }

    }



    public class GDrail : Rail

    {

        private double depth;
        private string type = "GDrail";


        public GDrail(double depth)

        {

            this.depth = depth;

        }

        public double GetDepth()
        {
            return this.depth;
        }

    }





    public class Panel : Accessory

    {

        private string color;

        private double price;

        private bool isMajor = true;


        public Panel(string color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return this.color;
        }

        public void SetColor(string newColor)
        {
            this.color = newColor;
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

        private double width;

        private double height;

        private string type = "ARpanel";

        public ARpanel(string color, double width, double height) : base(color)

        {

            this.width = width;

            this.height = height;

        }

        public double GetHeight()
        {
            return this.height;
        }

        public double GetWidth()
        {
            return this.width;
        }
    }



    public class GDpanel : Panel

    {

        private double depth;

        private double height;

        private string type = "GDpanel";

        public GDpanel(string color, double depth, double height) : base(color)

        {

            this.depth = depth;

            this.height = height;

        }

        public double GetDepth()
        {
            return this.depth;
        }

        public double GetHeight()
        {
            return this.height;
        }

    }



    public class HBpanel : Panel

    {

        private double depth;

        private double width;

        private string type = "HBpanel";

        public HBpanel(string color, double depth, double width) : base(color)

        {

            this.depth = depth;

            this.width = width;

        }

        public double GetDepth()
        {
            return this.depth;
        }

        public double GetWidth()
        {
            return this.width;
        }

    }





    public class interfacee

    {

        List<Locker> lockerList = new List<Locker>(); // static ou pas? à chaque fois que l'appli se lance la liste est remise à 0



        public void CasierOk(double hauteur, string couleur, double profondeur, double largeur, bool porte, string materiau, string couleur2)

        {

            List<Accessory> list = new List<Accessory>();



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

                    GlassDoor glassDoor = new GlassDoor(); 

                    list.Add(glassDoor);

                }



                else

                {

                    NormalDoor normalDoor = new NormalDoor( couleur2);

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

    }
}