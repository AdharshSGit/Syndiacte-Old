using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Catalogue
{
    class Update
    {
      
        public string newlap;
        public int lapupdate;
        
        Lapupdate u1 = new Lapupdate();

        public void updatedetails(List<Lapupdate> lapobj)
        {
           
            Console.WriteLine("Enter the ID for which type has to be updated");
            newlap = Console.ReadLine();

            while (!int.TryParse(newlap, out lapupdate))
            {
                Console.WriteLine("Not Valid");
                newlap = Console.ReadLine();
            }
            if((lapupdate > 0)&&(lapupdate<1000))
            {
                Console.Clear();
                foreach (Lapupdate u in lapobj)
                {
                    if(lapupdate==u.Id)
                    {
                        u.modeltype = u1.updateitem();
                    }
                }
                Console.WriteLine(u1.modeltype);
               
            }
            

        }
    }
}


























































































































































































