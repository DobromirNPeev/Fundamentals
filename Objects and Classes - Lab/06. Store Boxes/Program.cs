using System;
using System.Collections.Generic;

namespace _06._Store_Boxes
{
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public int SerialNumber { get; set; }
        public Item Item { get ; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string input = string.Empty;
            decimal max = decimal.MinValue;
            while((input=Console.ReadLine())!="end")
            {
                string[] inputAsArray = input.Split(' ');
                int serialNumber = int.Parse(inputAsArray[0]);
                string itemName = inputAsArray[1];
                int itemQuantity = int.Parse(inputAsArray[2]);
                decimal itemPrice = decimal.Parse(inputAsArray[3]);
                Box currBox = new Box
                {
                    SerialNumber = serialNumber,
                    Item = { Name = itemName, Price = itemPrice },
                    ItemQuantity = itemQuantity,
                    PriceForABox = itemQuantity * itemPrice
                };
                boxes.Add(currBox);
            }
            List<Box> sortedBoxes = new List<Box>();
            Box maxBox = new Box();
            int length=boxes.Count;
            while(boxes.Count!=0)
            {
                for (int i = 0; i < boxes.Count; i++)
                {
                    if (boxes[i].PriceForABox > max)
                    {
                        max = boxes[i].PriceForABox;
                        maxBox = boxes[i];
                    }
                }
                sortedBoxes.Add(maxBox);
                max = 0;
                boxes.Remove(maxBox);
            }
            foreach (var item in sortedBoxes)
            {
                Console.WriteLine(item.SerialNumber);
                Console.WriteLine($"-- {item.Item.Name} - ${item.Item.Price:f2}: {item.ItemQuantity}");
                Console.WriteLine($"-- ${item.PriceForABox:f2}");
            }
        }
    }
}
