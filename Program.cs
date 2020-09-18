using System;
using System.Collections.Generic;

namespace Calisma31_List_T_Collection
{

    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //        List<int> listem1 = new List<int>();

    //        List<string> listem2 = new List<string>();

    //        Dictionary<int,string> personeller = new Dictionary<int, string>();
    //        personeller.Add(35,"Ali"); 
    //        personeller.Add(36,"Osman"); 
    //        personeller.Add(35,"Ahmet"); 
    //        personeller.Add(35,"Yusuf");

    // }
    public class Part : IEquatable<Part>
    {
        public string PartName { get; set; }

        public int PartId { get; set; }

        public override string ToString()
        {
            return "ID: " + PartId + "   Name: " + PartName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Part objAsPart = obj as Part;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return PartId;
        }
        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.PartId.Equals(other.PartId));
        }
        // Should also override == and != operators.
    }
    public class Part1 //: IEquatable<Part1>
    {
        public string PartName { get; set; }

        public int PartId { get; set; }

        public override string ToString()
        {
            return "ID: " + PartId + "   Name: " + PartName;
        }
        // public override bool Equals(object obj)
        // {
        //     if (obj == null) return false;
        //     Part1 objAsPart = obj as Part1;
        //     if (objAsPart == null) return false;
        //     else return Equals(objAsPart);
        // }
        public override int GetHashCode()
        {
            return PartId;
        }
        public bool Equals(Part1 other)
        {
            if (other == null) return false;
            return (this.PartId.Equals(other.PartId));
        }
        // Should also override == and != operators.
    }

    public class Example
    {
        public static void Main()
        {
            // Create a list of parts.
            List<Part> parts = new List<Part>();
            List<Part1> parts1 = new List<Part1>();

            // Add parts to the list.
            parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
            parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
            parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
            parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
            parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
            parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });
            parts.Add(new Part() { PartName = "vites arm", PartId = 1664 });

            parts1.Add(new Part1() { PartName = "wheel", PartId = 3225 });
            parts1.Add(new Part1() { PartName = "vites arm", PartId = 1664 });

             Console.WriteLine();
            foreach (Part1 aPart in parts1)
            {
                Console.WriteLine(aPart);
            }


            // Write out the parts in the list. This will call the overridden ToString method
            // in the Part class.
            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            // Check the list for part #1734. This calls the IEquatable.Equals method
            // of the Part class, which checks the PartId for equality.
            Console.WriteLine("\nContains(\"1734\"): {0}",
            parts.Contains(new Part { PartId = 1734, PartName = "" }));

            // Insert a new item at position 2.
            Console.WriteLine("\nInsert(2, \"1834\")");
            parts.Insert(2, new Part() { PartName = "brake lever", PartId = 1834 });

            //Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            Console.WriteLine("\nParts[3]: {0}", parts[3]);

            Console.WriteLine("\nRemove(\"1534\")");

            // This will remove part 1534 even though the PartName is different,
            // because the Equals method only checks PartId for equality.
            parts.Remove(new Part() { PartId = 1534, PartName = "cogs" });

            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }
            Console.WriteLine("\nRemoveAt(3)");
            // This will remove the part at index 3.
            parts.RemoveAt(3);

            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }
        }
    }
}
