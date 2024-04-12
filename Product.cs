using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64632_Vladyslav_Babiak_task_3
{
    internal class Product
    {
        private string id;
        public string name;
        public string brand;
        public float price;

        public Product (string name, string brand, float price) {
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.id = GenerateId();
        }

        public Product (string productData)
        {
            string[] productArray = productData.Split('$');

            this.id = productArray[0];
            this.name = productArray[1];
            this.brand = productArray[2];
            this.price = Convert.ToSingle(productArray[3]);
        }

        private string GenerateId ( )
        {
            Random rand = new Random();

            string char1 = Convert.ToString(name[rand.Next(0, name.Length)]);
            string char2 = Convert.ToString(name[rand.Next(0, name.Length)]);

            int randNum = rand.Next(1, 9999);

            string id = $"{char1}{char2}-{randNum}";

            return id;
        }

        public string GenerateData ()
        {
            return $"{id}${name}${brand}${Convert.ToString(price)}";
        }


        public string GetId() { return this.id; }
    }
}
