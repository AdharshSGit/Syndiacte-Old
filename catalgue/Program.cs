using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace catalgue
{
    class Program
    {
        public void Addlaptop()
        {
            XDocument xdoc = new XDocument();
            xdoc.Element("ID").Add(new XElement("ID", "66"));
            var result = xdoc.Element("ID").Descendants();

            foreach (XElement item in result)
            {
                Console.WriteLine("ID - " + item.Value);

            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
        public static void Main()
        {
            Laptop[] laptops = new Laptop[10];

            laptops[0] = new Laptop(11, "Dell", "Inspiron3481", 27990);
            laptops[1] = new Laptop(22, "Asus", "ROG Strix G", 74990);
            laptops[2] = new Laptop(33, "Acer", "Nitro 5", 57990);
            laptops[3] = new Laptop(44, "Lenovo", "Ideapad", 27990);
            laptops[4] = new Laptop(55, "Apple", "MacBook Air", 67990);
            laptops[5] = new Laptop;
            using (XmlWriter writer = XmlWriter.Create("Laptop.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Laptops");

                foreach (Laptop lap in laptops)
                {
                    writer.WriteStartElement("Laptop");

                    writer.WriteElementString("ID", lap.Id.ToString());
                    writer.WriteElementString("brand", lap.Brand);
                    writer.WriteElementString("model", lap.Model);
                    writer.WriteElementString("price", lap.Price.ToString());
                    
                    writer.WriteEndElement();
                }
                Addlaptop();
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
          

            Pendrive[] pendrive = new Pendrive[5];
              pendrive[0] = new Pendrive(121, "Sandisk", "Ultra Dual -64 GB", 899);
              pendrive[1] = new Pendrive(122, "HP", "V215 B -32 GB", 360);
              pendrive[2] = new Pendrive(133, "Toshiba", "TransMemory -32 GB", 415);
              pendrive[3] = new Pendrive(144, "Kingston", "DTIG4 USB 3.0 -16 GB", 475);
              pendrive[4] = new Pendrive(155, "Sony", "Ultra 3.1 -32 GB", 785);

              using (XmlWriter writer1 = XmlWriter.Create("Pendrive.xml"))
              {
                  writer1.WriteStartDocument();
                  writer1.WriteStartElement("Pendrives");

                  foreach (Pendrive pd in pendrive)
                  {
                      writer1.WriteStartElement("Pendrive");

                      writer1.WriteElementString("ID", pd.Id.ToString());
                      writer1.WriteElementString("brand", pd.Brand);
                      writer1.WriteElementString("model", pd.Model);
                      writer1.WriteElementString("price", pd.Price.ToString());

                      writer1.WriteEndElement();
                  }

                  writer1.WriteEndElement();
                  writer1.WriteEndDocument();
              }

              Mouse[] mousevariant = new Mouse[5];
              mousevariant[0] = new Mouse(221, "Lenovo", "M110 Optical Wired", 269);
              mousevariant[1] = new Mouse(222, "HP", "HP S500", 660);
              mousevariant[2] = new Mouse(233, "Logitech", "M-171", 649);
              mousevariant[3] = new Mouse(244, "Dell", "WM 126", 719);
              mousevariant[4] = new Mouse(255, "Zebronics", "Optical Wired", 285);

              using (XmlWriter writer2 = XmlWriter.Create("Mouse.xml"))
              {
                  writer2.WriteStartDocument();
                  writer2.WriteStartElement("Mouse");

                  foreach (Mouse mv in mousevariant)
                  {
                      writer2.WriteStartElement("Mouse");

                      writer2.WriteElementString("ID", mv.Id.ToString());
                      writer2.WriteElementString("brand", mv.Brand);
                      writer2.WriteElementString("model", mv.Model);
                      writer2.WriteElementString("price", mv.Price.ToString());

                      writer2.WriteEndElement();
                  }

                  writer2.WriteEndElement();
                  writer2.WriteEndDocument();
              }
              
          }
        
    }
    }


