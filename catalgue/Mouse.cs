using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catalgue
{
    class Mouse
    {
        int id;
        string brand;
        string model;
        int cost;

        public Mouse(int id, string brand, string model, int cost)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.cost = cost;
        }
        public int Id { get { return id; } }
        public string Brand { get { return brand; } }
        public string Model { get { return model; } }
        public int Price { get { return cost; } }
    }
}
