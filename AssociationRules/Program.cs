using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationRules
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"test.csv";
            string sup = "2";
            if (args.Length > 0)
            {
                file = args[0];

            }
            if (args.Length == 2)
            {
                sup = args[1];

            }


            double support = double.Parse(sup);

            CSVReader cr = new CSVReader();
            ItemSet data = cr.Read(file);
            ItemSet a = Apriori.GenerateRules(data, support);
            for (int i = 0; i < a.Count; i++)
            {
                ItemSet cur = (ItemSet)a[i];
                for (int j = 0; j < cur.Count; j++)
                {
                    ItemSet now = (ItemSet)cur[j];
                    foreach (DataItem item in now)
                    {
                        Console.Write("ID" + item.Id + ":" + item.ItemName + "  ");
                    }
                    Console.WriteLine("  Support:" + now.ICount);
                }

            }
            Console.Read();
        }
    }
}
