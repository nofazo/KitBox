using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

using System.Windows.Forms;

using System.IO;
using System.Data;
using MySql.Data.MySqlClient;
using Kitbox;


namespace Kitbox

{
    public class CupBoard
    {
        private double width;

        private double depth;

        private List<Locker> lockerList;

        private Extrusion extrusion;

        //liste cornière après, pas besoin de liste comme mêmes cornières (prix *4)


        public CupBoard(double width, double depth, List<Locker> lockerList, Extrusion extrusion)
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

        public void SetWidth(double newWidth)
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


        public double GetPrice(MySqlConnection connection)
        {
            double lockerPrice = 0;

            foreach (Locker locker in lockerList)
                lockerPrice += locker.GetPrice(connection);

            double extrusionPrice = extrusion.GetPrice(connection);

            return lockerPrice + extrusionPrice;
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
        private bool isCut = false;

        private int[] heightList = new int[] { 36, 46, 50, 56, 72, 75, 92, 100, 108, 112, 125, 138, 144, 150, 168, 175, 180, 184, 200, 216, 224, 225, 230, 250, 252, 275, 276, 280, 300, 325, 350, 375 };


        public Extrusion(string color, double height)

        {

            this.color = color;

            this.height = height;

        }

        public string GetColorDB(string color)
        {
            string dbColor = "";

            if (color == "Brown")
                dbColor = "Brun";

            if (color == "White")
                dbColor = "Blanc";

            if (color == "Green")
                dbColor = "Vert";

            if (color == "Black")
                dbColor = "Noir";

            if (color == "glass")
                dbColor = "Verre";

            return dbColor;
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

        public bool IsCut(double height)
        {
            isCut = true;
            foreach (int elem in heightList)
            {
                if (elem == height)
                    isCut = false;
            }
            return isCut;
        }

        public double GetExistingTopHeight(double height)
        {
            double value = heightList.Max();
            foreach (int elem in heightList)
            {
                if (height < elem)
                {
                    value = elem;
                    break;
                }
            }
            return value;
        }


        public double GetPrice(MySqlConnection connection)
        {
            string dbColor = "";

            if (color == "Brown")
                dbColor = "Brun";

            if (color == "White")
                dbColor = "Blanc";

            if (color == "Galvanised")
                dbColor = "Galvanisé";

            if (color == "Black")
                dbColor = "Noir";


            string reference = "Cornières";
            MySqlDataReader reader;
            MySqlDataReader reader2;
            MySqlCommand command = new MySqlCommand("SELECT Price, PartForLocker FROM `kitboxdb2.0`.`parts` WHERE ref='" + reference + "'AND height='" + Convert.ToString(height) + "'AND color='" + dbColor + "'", connection);

            reader = command.ExecuteReader();

            double price = 0;
            double partForCupboard = 0;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    price = reader.GetDouble(0);
                    partForCupboard = reader.GetDouble(1);
                }
                reader.Close();
            }

            else
            {
                reader.Close();
                isCut = true;

                //on prend une hauteur existante que l'ouvrier coupera manuellement
                double existingHeight = GetExistingTopHeight(height);

                MySqlCommand command2 = new MySqlCommand("SELECT Price, PartForLocker FROM `kitboxdb2.0`.`parts` WHERE ref='" + reference + "'AND height='" + Convert.ToString(existingHeight) + "'AND color='" + dbColor + "'", connection);
                reader2 = command2.ExecuteReader();
                price = 0;
                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        price = reader2.GetDouble(0);
                        partForCupboard = reader2.GetDouble(1);
                    }
                }

                else
                {
                    MessageBox.Show("there is no rows in the datareader !");
                }

                reader2.Close();
            }


            return (price * partForCupboard) + 1;
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

        private int ID;


        public Locker(List<Accessory> accessoryList, double lockerHeight, string color, int ID)

        {

            this.accessoryList = accessoryList;

            this.lockerHeight = lockerHeight;

            this.color = color;

            this.ID = ID;
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

        public double GetAccessHeight()
        {
            return (this.lockerHeight - 4) ;
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


        public double GetPrice(MySqlConnection connection)
        {
            double price = 0;

            foreach (Accessory elem in accessoryList)
            {
                price += elem.GetPrice(connection);
            }
            return price;
        }

        public int GetID()
        {
            return this.ID;
        }

        public void SetID(int newID)
        {
            this.ID = newID;
        }

        public void AddAccessory(Accessory accessory)

        {

            accessoryList.Add(accessory);

        }

        public bool HasDoor()
        {
            foreach (Accessory elem in accessoryList)
            {
                if (elem.GetRefDB() == "Porte")
                    return true;
            }
            return false;
        }

        public Accessory.Door GetDoor()
        {
            foreach (Accessory elem in accessoryList)
            {
                if (elem.GetRefDB() == "Porte")
                    return (Accessory.Door) elem;
            }
            Accessory.Door door = new Accessory.Door(0, 0);
            return door;
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
        private string state;
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



            // Console.WriteLine("Total : " + cubBoard.GetPrice(MySqlConnection connection));

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

        public void SetState(string state)
        {
            this.state = state;
        }
        public string GetState()
        {
            return this.state;
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

                        //afficher accessory.GetAccessType() + accessory.GetPrice();

                        // afficher nom + id + quantité + prix unitaire + prix totale 

                        // ajouter une variable "quantité?" pour la quantitié qu'il faut d'un access pour un casier

                        // attention responsabilité unique

                    }

                }



                // sw.WriteLine("Total : " + cubBoard.GetPrice(MySqlConnection connection));

            }

        }





        public void GetBill()
        {

            string path = @"/Users/User/source/Bill.txt";

            using (StreamWriter sw = File.CreateText(path))

            {

                foreach (Locker locker in cubBoard.GetLockerList())

                {

                    //sw.WriteLine(locker.GetColor() + locker.GetPrice(MySqlConnection connection));   // sprint 3:faire distinction entre casier avec porte et casier sans porte

                }



                //sw.WriteLine("Total" + cubBoard.GetPrice(MySqlConnection connection));

            }

        }



    }



    public abstract class Accessory
    {
        public MySqlConnection connection;
        public abstract bool IsMajor();
        public abstract string GetRefDB();
        public abstract string GetAccessType();
        public abstract string GetColor();
        public abstract double GetHeight();
        public abstract double GetWidth();
        public abstract double GetDepth();
        public abstract double GetPrice(MySqlConnection connection);
        public abstract double GetInstock(MySqlConnection connection);

        public string GetColorDB(string color)
        {
            string dbColor = "";

            if (color == "Brown")
                dbColor = "Brun";

            if (color == "White")
                dbColor = "Blanc";

            if (color == "Green")
                dbColor = "Vert";

            if (color == "Black")
                dbColor = "Noir";

            if (color == "glass")
                dbColor = "Verre";

            return dbColor;
        }

        public double GetInstocks(MySqlConnection connection, string reference, double height, double width, double depth, string color)
        {
            string dbColor = GetColorDB(color);

            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand("SELECT InStock, PartForLocker FROM `kitboxdb2.0`.`parts` WHERE ref='" + reference + "'AND height='" + Convert.ToString(height) + "'AND width='" + Convert.ToString(width) + "'AND depth='" + Convert.ToString(depth) + "'AND color='" + dbColor + "'", connection);

            reader = command.ExecuteReader();

            double inStock = 0;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    inStock = reader.GetDouble(0) - reader.GetDouble(1);
                }
            }
            else
            {
                MessageBox.Show("there is no rows in the datareader");
            }

            reader.Close();

            return inStock;
        }


        public double GetPrices(MySqlConnection connection, string reference, double height, double width, double depth, string color)
        {
            string dbColor = GetColorDB(color);

            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand("SELECT Price, PartForLocker FROM `kitboxdb2.0`.`parts` WHERE ref='" + reference + "'AND height='" + Convert.ToString(height) + "'AND width='" + Convert.ToString(width) + "'AND depth='" + Convert.ToString(depth) + "'AND color='" + dbColor + "'", connection);

            reader = command.ExecuteReader();

            double price = 0;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    price = reader.GetDouble(0) * reader.GetDouble(1);
                }
            }
            else
            {
                MessageBox.Show("there is no rows in the datareader");
            }

            reader.Close();

            return price;
        }





        public class Door : Accessory
        {
            private double inStock;
            private double price;

            private bool isMajor = false;

            protected string type = "Door";
            private double height;
            private double width;
            private string reference = "Porte";

            public Door(double height, double width)
            {
                this.height = height;
                this.width = width;
            }

            public override double GetHeight()
            {
                return this.height;
            }

            public override double GetWidth()
            {
                return this.width;
            }

            public override double GetDepth()
            {
                return 0;
            }


            public override bool IsMajor()
            {
                return isMajor;

            }

            public override string GetColor()
            {
                return "";
            }

            public override string GetRefDB()
            {
                return this.reference;
            }

            public override string GetAccessType()
            {
                return this.type;
            }

            public override double GetPrice(MySqlConnection connection)
            {
                return GetPrices(connection, "Door", height, width, 0, "");
            }
            public override double GetInstock(MySqlConnection connection)
            {
                return GetInstocks(connection,"Door",height,width,0,"");
            }

        }



        public class GlassDoor : Door
        {

            private double price;
            private double inStock;
            new private string type = "glassDoor";
            private string reference = "Porte";

            public GlassDoor(double height, double width, string color = "Verre") : base(height, width)
            {

            }

            public override string GetRefDB()
            {
                return this.reference;
            }

            public override string GetAccessType()
            {
                return this.type;
            }

            public override string GetColor()
            {
                return "glass";
            }

            public override double GetPrice(MySqlConnection connection)
            {
                price = GetPrices(connection, "Porte", GetHeight(), GetWidth(), 0, "glass");   // va-t-il retourner le bon height et width?
                return price;

            }
            public override double GetInstock(MySqlConnection connection)
            {
                inStock = GetPrices(connection, "Porte", GetHeight(), GetWidth(), 0, "glass");   // va-t-il retourner le bon height et width?
                return inStock;

            }

        }



        public class NormalDoor : Door
        {

            private double cabinetHandlePrice;
            private double cabinetHandleInStock;
            private double price;
            private double inStock;

            private string color;

            new protected string type = "normalDoor";
            private string reference = "Porte";

            public NormalDoor(double height, double width, string color) : base(height, width)
            {

                this.color = color;

            }

            public override string GetColor()
            {
                return this.color;
            }

            public void SetColor(string newColor)
            {
                this.color = newColor;
            }

            public override string GetRefDB()
            {
                return this.reference;
            }

            public override string GetAccessType()
            {
                return this.type;
            }

            public override double GetPrice(MySqlConnection connection)
            {
                price = GetPrices(connection, "Porte", GetHeight(), GetWidth(), 0, color);
                cabinetHandlePrice = GetPrices(connection, "Coupelles", 0, 0, 0, "");
                return price + cabinetHandlePrice;
            }
            public override double GetInstock(MySqlConnection connection)
            {
                inStock = GetInstocks(connection, "Porte", GetHeight(), GetWidth(), 0, color);
                
                return inStock;
            }
        }



        public class Cleat : Accessory
        {

            private double height;

            private double price;
            private double inStock;

            private bool isMajor = true;

            private string type = "cleat";
            private string reference = "Tasseau";

            public Cleat(double height)
            {

                this.height = height;

            }

            public override double GetHeight()
            {
                return this.height;
            }

            public override double GetWidth()
            {
                return 0;
            }

            public override double GetDepth()
            {
                return 0;
            }

            public void SetHeight(double newHeight)
            {
                this.height = newHeight;
            }

            public override string GetColor()
            {
                return "";
            }

            public override bool IsMajor()
            {

                return isMajor;

            }

            public override string GetRefDB()
            {
                return this.reference;
            }

            public override string GetAccessType()
            {
                return this.type;
            }

            public override double GetPrice(MySqlConnection connection)
            {
                price = GetPrices(connection, "Tasseau", height, 0, 0, "");
                return price;
            }
            public override double GetInstock(MySqlConnection connection)
            {
                inStock = GetInstocks(connection, "Tasseau", height, 0, 0, "");
                return inStock;
            }

        }



        public class Rail : Accessory
        {

            private double price;
            private double inStock;

            private bool isMajor = true;

            private string type = "Rail";
            private string reference = "Traverse";

            public Rail()
            {


            }

            public override string GetColor()
            {
                return "";
            }

            public override bool IsMajor()

            {

                return isMajor;

            }

            public override string GetRefDB()
            {
                return this.reference;
            }

            public override string GetAccessType()
            {
                return this.type;
            }

            public override double GetHeight()
            {
                return 0 ;
            }

            public override double GetWidth()
            {
                return 0;
            }

            public override double GetDepth()
            {
                return 0;
            }

            public override double GetPrice(MySqlConnection connection)
            {
                price = GetPrices(connection, "Traverse", 0, 0, 0, "");
                return price;
            }
            public override double GetInstock(MySqlConnection connection)
            {
                inStock = GetInstocks(connection, "Traverse", 0, 0, 0, "");
                return inStock;
            }

        }



        public class ARrail : Rail
        {
            private double price;
            private double inStock;
            private double width;
            private string type = "ARrail";
            private string reference = "Traverse Ar";

            public ARrail(double width)
            {

                this.width = width;

            }

            public override double GetWidth()
            {
                return this.width;
            }

            public override string GetRefDB()
            {
                return this.reference;
            }

            public override string GetAccessType()
            {
                return this.type;
            }

            public override double GetPrice(MySqlConnection connection)
            {
                price = GetPrices(connection, "Traverse Ar", 0, width, 0, "");
                return price;
            }
            public override double GetInstock(MySqlConnection connection)
            {
                inStock= GetInstocks(connection, "Traverse Ar", 0, width, 0, "");
                return inStock;
            }
        }

        public class AVrail : Rail
        {
            private double price;
            private double inStock;
            private double width;
            private string type = "AVrail";
            private string reference = "Traverse Av";

            public AVrail(double width)

            {

                this.width = width;

            }

            public override double GetWidth()
            {
                return this.width;
            }

            public override string GetRefDB()
            {
                return this.reference;
            }

            public override string GetAccessType()
            {
                return this.type;
            }

            public override double GetPrice(MySqlConnection connection)
            {
                price = GetPrices(connection, "Traverse Av", 0, width, 0, "");
                return price;
            }
            public override double GetInstock(MySqlConnection connection)
            {
                inStock = GetInstocks(connection, "Traverse Av", 0, width, 0, "");
                return inStock;
            }
        }



        public class GDrail : Rail
        {
            private double price;
            private double instock;
            private double depth;
            private string type = "GDrail";
            private string reference = "Traverse GD";

            public GDrail(double depth)

            {

                this.depth = depth;

            }

            public override double GetDepth()
            {
                return this.depth;
            }

            public override string GetRefDB()
            {
                return this.reference;
            }

            public override string GetAccessType()
            {
                return this.type;
            }

            public override double GetPrice(MySqlConnection connection)
            {
                price = GetPrices(connection, "Traverse GD", 0, 0, depth, "");
                return price;
            }
            public override double GetInstock(MySqlConnection connection)
            {
                price = GetInstocks(connection, "Traverse GD", 0, 0, depth, "");
                return price;
            }
        }





        public class Panel : Accessory

        {

            private string color;

            private double price;
           
            private double inStock;

            private bool isMajor = true;

            private string type = "Panel";

            private string reference = "Panneau";


            public Panel(string color)
            {
                this.color = color;
            }

            public override string GetColor()
            {
                return this.color;
            }

            public void SetColor(string newColor)
            {
                this.color = newColor;
            }


            public override bool IsMajor()

            {

                return isMajor;

            }

            public override double GetHeight()
            {
                return 0;
            }

            public override double GetWidth()
            {
                return 0;
            }

            public override double GetDepth()
            {
                return 0;
            }

            public override string GetRefDB()
            {
                return this.reference;
            }

            public override string GetAccessType()
            {
                return this.type;
            }

            public override double GetPrice(MySqlConnection connection)
            {
                price = GetPrices(connection, "Panneau", 0, 0, 0, color);
                return price;
            }
            public override double GetInstock(MySqlConnection connection)
            {
                inStock = GetInstocks(connection, "Panneau", 0, 0, 0, color);
                return inStock;
            }
        }



        public class ARpanel : Panel

        {
            private double price;
            private double inStock;

            private double width;

            private double height;

            private string type = "ARpanel";
            private string reference = "Panneau Ar";

            public ARpanel(string color, double width, double height) : base(color)

            {

                this.width = width;

                this.height = height;

            }

            public override double GetHeight()
            {
                return this.height;
            }

            public override double GetWidth()
            {
                return this.width;
            }

            public override string GetRefDB()
            {
                return this.reference;
            }

            public override string GetAccessType()
            {
                return this.type;
            }

            public override double GetPrice(MySqlConnection connection)
            {
                price = GetPrices(connection, "Panneau Ar", height, width, 0, GetColor());
                return price;
            }
            public override double GetInstock(MySqlConnection connection)
            {
                inStock = GetInstocks(connection, "Panneau Ar", height, width, 0, GetColor());
                return inStock;
            }
        }



        public class GDpanel : Panel
        {
            private double price;
            private double inStock;

            private double depth;

            private double height;

            private string type = "GDpanel";

            private string reference = "Panneau GD";

            public GDpanel(string color, double depth, double height) : base(color)

            {

                this.depth = depth;

                this.height = height;

            }

            public override double GetDepth()
            {
                return this.depth;
            }

            public override double GetHeight()
            {
                return this.height;
            }

            public override string GetRefDB()
            {
                return this.reference;
            }

            public override string GetAccessType()
            {
                return this.type;
            }

            public override double GetPrice(MySqlConnection connection)
            {
                price = GetPrices(connection, "Panneau GD", height, 0, depth, GetColor());
                return price;
            }
            public override double GetInstock(MySqlConnection connection)
            {
                inStock = GetInstocks(connection, "Panneau GD", height, 0, depth, GetColor());
                return inStock;
          
            }
        }



        public class HBpanel : Panel
        {
            private double price;
            private double inStock;

            private double depth;

            private double width;

            private string type = "HBpanel";
            private string reference = "Panneau HB";

            public HBpanel(string color, double depth, double width) : base(color)

            {

                this.depth = depth;

                this.width = width;

            }

            public override double GetDepth()
            {
                return this.depth;
            }

            public override double GetWidth()
            {
                return this.width;
            }

            public override string GetRefDB()
            {
                return this.reference;
            }

            public override string GetAccessType()
            {
                return this.type;
            }

            public override double GetPrice(MySqlConnection connection)
            {
                price = GetPrices(connection, "Panneau HB", 0, width, depth, GetColor());
                return price;
            }
            public override double GetInstock(MySqlConnection connection)
            {
                inStock = GetInstocks(connection, "Panneau HB", 0, width, depth, GetColor());
                return inStock;
            }
        }





        public class tg

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



                //ARAVrail ARAVraill = new ARAVrail(largeur);   //x2

                //list.Add(ARAVraill);



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

                        //GlassDoor glassDoor = new GlassDoor(); 

                        //list.Add(glassDoor);

                    }



                    else

                    {

                        //NormalDoor normalDoor = new NormalDoor( couleur2);

                        //list.Add(normalDoor);



                    }

                }



                //Locker Casier = new Locker(list, hauteur, couleur);         // ouu Casier.AddAccessory(cleatt);

                //lockerList.Add(Casier);                                             // attention problème tous les casiers même nom à résoudre 

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
}