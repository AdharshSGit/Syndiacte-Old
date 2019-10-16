using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Threading.Tasks;
using System.IO;

namespace Catalogue
{
    class Laptop
    {
        int _id;
        string _brand;
        string _model;
        int _price;
        
        public Laptop(int id, string brand, string model, int price)
        {
            this._id = id;
            this._brand = brand;
            this._model = model;
            this._price = price;
        }

        public int Id { get { return _id; } }
        public string Brand { get { return _brand; } }
        public string Model { get { return _model; } }
        public int Price { get { return _price; } }
    }
    class Laptopread
    {
        public void lapdisplay()
        {
            XElement xelement = XElement.Load(@"C:\Users\adharsh.s\Documents\GitHub\C-\Catalogue\Laptop.xml");
            IEnumerable<XElement> Laptops = xelement.Elements();
            Console.WriteLine("-----------------------Available Laptop Variants----------------------");
            foreach (var lap in Laptops)
            {
                String id = lap.Element("ID").Value;
                String brandname = lap.Element("brand").Value;
                String price_detail = lap.Element("price").Value;
                String model_detail = lap.Element("model").Value;

                Console.WriteLine("Id: {0}", id);
                Console.WriteLine("Brand: {0}", brandname);
                Console.WriteLine("Model: {0}", model_detail);
                Console.WriteLine("Price: Rs. {0}", price_detail);
                Console.WriteLine("-----------------------------------------------------------------------");
            }
            Console.WriteLine();
            Console.WriteLine("----Please Enter the Item Id you wish to buy---");
            lapdisplay1();
        }
        public void lapdisplay1()
        {
            int price = 0;
            int qty = 0;
            String user_id = Console.ReadLine();
            Console.Clear();
            XElement xelement = XElement.Load("Laptop.xml");
            IEnumerable<XElement> Laptops = xelement.Elements();
            var x = from Laptop in xelement.Elements("Laptop")
                    where (string)Laptop.Element("ID") == user_id
                    select Laptop;
            Console.WriteLine("---------------------------Your Selection-----------------------------");
            Console.WriteLine();
            foreach (XElement lap in x)
            {
                String id = lap.Element("ID").Value;
                String brandname = lap.Element("brand").Value;
                String price_detail = lap.Element("price").Value;
                String model_detail = lap.Element("model").Value;

                price = Convert.ToInt32(price_detail);

                Console.WriteLine("Id: {0}", id);
                Console.WriteLine("Brand: {0}", brandname);
                Console.WriteLine("Model: {0}", model_detail);
                Console.WriteLine("Price: Rs. {0}", price_detail);
                Console.WriteLine("----------------------------------------------------------------------");
            }
            String user_choice;
            do
            {
                Console.WriteLine("Enter the Quantity Required");
                qty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Total Price: Rs. {0}", qty * price);

                Console.WriteLine();
                Console.WriteLine("Do you want to Change quantity? (y/n)");
                user_choice = Console.ReadLine();
                Console.WriteLine();

                if (user_choice == "n")

                    Console.WriteLine("Thank you for visiting us...");

                while ((user_choice != "y") && (user_choice != "n"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Option. Please Choose 'y' or 'n'");
                    user_choice = Console.ReadLine();
                }
            } while (user_choice == "y");
        }
    }
        class Lapupdate
        {

        public string modeltype;
        public int Id { get; set;}
            public String Brand { get; set; }
            public String Model { get; set; }
            public int Price { get; set; }
        public string updateitem()
        {
            Console.WriteLine("Enter the model..");
            modeltype = Console.ReadLine();
            return modeltype;
        }

    }

    class Lapadd
        {
        public void updation()
        {
            Console.WriteLine("Enter the operation to be done..(1/2/3)");
            Console.WriteLine();
            Console.WriteLine("-----> 1.) ADD  2.) DELETE  3.) EDIT <------");

            int choice = Convert.ToInt32(Console.ReadLine());
    
            switch(choice)
            {
                case 1:
                    add();
                    Console.ReadKey();
                    break;
                case 2:
                    delete();
                    Console.ReadKey();
                    break;
                case 3:
                    edit();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Invalid choice - Please enter 1/2/3");
                    Console.ReadKey();
                    break;
            }
        }
        public void add()
            {
            Console.WriteLine("Enter the details of laptop to be added");
            Console.ReadKey();
            Console.WriteLine("Enter the ID");
            String x = Console.ReadLine();

            Console.WriteLine("Enter the Brand");
            String y = Console.ReadLine();

            Console.WriteLine("Enter the Model");
            String z = Console.ReadLine();

            Console.WriteLine("Enter the Price");
            String w = Console.ReadLine();
          
            XDocument xDocument = XDocument.Load("Laptop.xml");
            XElement root= xDocument.Element("Laptops");
            IEnumerable<XElement> rows = root.Descendants("Laptop");
            XElement firstRow= rows.First();
            firstRow.AddBeforeSelf(
            new XElement("Laptop",
            new XElement("ID", x),
            new XElement("brand", y),
            new XElement("model",z),
            new XElement("price",w)));
            xDocument.Save("Laptop.xml");
           
            Console.WriteLine("Laptop Added and Saved");
       
            } 
        public void delete()
        {
            Console.WriteLine("Enter the LAPTOP_ID to be deleted");
            String user_id = Console.ReadLine();
            
            XElement xelement = XElement.Load("Laptop.xml");
            IEnumerable<XElement> Laptops = xelement.Elements();
            var x = from Laptop in xelement.Elements("Laptop")
                    where (string)Laptop.Element("ID") == user_id
                    select Laptop;
            x.Remove();
            xelement.Save("Laptop.xml");
            Console.WriteLine("The Laptop_ID"+ user_id +"is deleted Successfully");
            
        }
        public void edit()
        {
            Console.WriteLine("Enter the Id to be edited");
            String user_id = Console.ReadLine();
          //  Console.WriteLine("Enter the price of the"+user_id+"which has to be edited");
           // String price_edit = Console.ReadLine();
            Console.WriteLine("Enter the new updated price of the  "+user_id);
            String pricenew = Console.ReadLine();

             XElement xelement = XElement.Load("Laptop.xml");
            IEnumerable<XElement> Laptops = xelement.Elements();
            var x = from Laptop in xelement.Elements("Laptop")
                    where (string)Laptop.Element("ID") == user_id
                    select Laptop;
  
        foreach (XElement id in x)  
        {            
            String price_detail = id.Element("price").Value;
           // int price = Convert.ToInt32(price_detail);

            id.SetElementValue("price", pricenew);  
        }  
            xelement.Save("Laptop.xml");
            Console.WriteLine("Editing done");
        }
        }

}
     


 