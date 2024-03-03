using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    class Hat
    {
        public string Color { get; set; }
        public int Counter { get; set; }
    }
    class Props
    {
        public string HatColor { get; set; }
        public int Physic { get; set; }
        public Props(string hatColor, int physic)
        {
            this.HatColor = hatColor;
            this.Physic = physic;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<Props>> dwarfs = new SortedDictionary<string, List<Props>>();
            List<Hat> hats = new List<Hat>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] inputAsArray = input.Split(" <:> ").ToArray();
                string name = inputAsArray[0];
                string hatColor = inputAsArray[1];
                int physics = int.Parse(inputAsArray[2]);
                Props newDwarf = new Props(hatColor, physics);
                if (dwarfs.ContainsKey(name))
                {
                    int OGDwarfPhysic = 0;
                    bool contains = false;
                    int index = 0;
                    foreach (var item in dwarfs[name])
                    {
                        if (item.HatColor == hatColor)
                        {
                            OGDwarfPhysic = item.Physic;
                            contains = true;
                        }
                        index++;
                    }
                    if (!contains)
                    {
                        dwarfs[name].Add(newDwarf);
                    }
                    else if (contains)
                    {
                        foreach (var item in hats)
                        {
                            if (item.Color == hatColor)
                            {
                                item.Counter++;
                            }
                        }
                        if (OGDwarfPhysic < physics)
                        {
                            foreach (var item in dwarfs[name])
                            {
                                if (item.HatColor == newDwarf.HatColor)
                                {
                                    item.Physic = newDwarf.Physic;
                                }
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    List<Props> newList = new List<Props>
                        {
                            newDwarf
                        };
                    dwarfs.Add(name, newList);
                    Hat newHat = new Hat
                    {
                        Color = hatColor,
                        Counter = 1
                    };
                    hats.Add(newHat);
                }
            }
            foreach (var item in dwarfs.OrderByDescending(x => x.Value.Sum(x => x.Physic)).ThenByDescending(x => x.Value.Count()))
            {
                foreach (var itemInside in item.Value)
                {
                    Console.WriteLine($"({itemInside.HatColor}) {item.Key} <-> {itemInside.Physic}");
                }
            }
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;
 
//namespace Snowwhite
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            List<Dwarf> dwarf = new List<Dwarf>();

//            while (input != "Once upon a time")
//            {
//                string[] splitedInput = input.Split(new string[] { " <:> " }, StringSplitOptions.None);


//                string dwarfName = splitedInput[0];
//                string dwarfColor = splitedInput[1];
//                BigInteger dwarfPhysics = BigInteger.Parse(splitedInput[2]);

//                Dwarf dd = new Dwarf();

//                dd.Color = dwarfColor;
//                dd.Name = dwarfName;
//                dd.Physics = dwarfPhysics;

//                bool contains = false;
//                for (int i = 0; i < dwarf.Count; i++)
//                {
//                    if (dwarf[i].Name == dd.Name && dwarf[i].Color == dd.Color)
//                    {
//                        if (dwarf[i].Physics < dd.Physics) dwarf[i].Physics = dd.Physics;
//                        contains = true;
//                    }
//                }


//                if (!contains)
//                {
//                    int count = dwarf.Where(x => x.Color == dwarfColor).Count() + 1;
//                    dd.ColorCount = count;
//                    dwarf.Add(dd);
//                    foreach (var item in dwarf.Where(x => x.Color == dwarfColor))
//                    {
//                        item.ColorCount = count;
//                    }
//                }

//                input = Console.ReadLine();
//            }

//            var tmpDwarf = dwarf;

//            foreach (var item in dwarf.OrderByDescending(z => z.Physics).ThenByDescending(z => z.ColorCount))
//            {
//                Console.WriteLine($"({item.Color}) {item.Name} <-> {item.Physics}");
//            }
//        }

//        class Dwarf
//        {
//            public string Color { get; set; }
//            public string Name { get; set; }
//            public BigInteger Physics { get; set; }
//            public int ColorCount { get; set; }
//        }
//    }
//}
