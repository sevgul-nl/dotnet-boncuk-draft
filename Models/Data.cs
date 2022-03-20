using System.Collections.Generic;

namespace eBoncuk.Models
{
    public class Data
    {
        public static List<Boncuk> GetBoncuks()
        {
            List<Boncuk> boncuks = new List<Boncuk>
            {
                new Boncuk
                {
                    BoncukID = 1,
                    Name = "Boncuk-1",
                    Price = (decimal)6.00
                },
                new Boncuk
                {
                    BoncukID = 2,
                    Name = "Boncuk-2",
                    Price = (decimal)19.00
                },
                new Boncuk
                {
                    BoncukID = 3,
                    Name = "Boncuk-3",
                    Price = (decimal)5.00
                },
                new Boncuk
                {
                    BoncukID = 4,
                    Name = "Boncuk-4",
                    Price = (decimal)8.99
                },
                new Boncuk
                {
                    BoncukID = 5,
                    Name = "Boncuk-5",
                    Price = (decimal)9.00
                },
                new Boncuk
                {
                    BoncukID = 6,
                    Name = "Boncuk-6",
                    Price = (decimal)15.00
                },
                new Boncuk
                {
                    BoncukID = 7,
                    Name = "Boncuk-7",
                    Price = (decimal)7.99
                },
                new Boncuk
                {
                    BoncukID = 8,
                    Name = "Boncuk-",
                    Price = (decimal)4.99
                },
                new Boncuk
                {
                    BoncukID = 9,
                    Name = "Boncuk-9",
                    Price = (decimal)9.99
                },
                new Boncuk
                {
                    BoncukID = 10,
                    Name = "Boncuk-10",
                    Price = (decimal)79.99
                }
            };
            return boncuks;
        }

        public static Boncuk GetBoncuk(string slug)
        {
            List<Boncuk> boncuks = Data.GetBoncuks();
            foreach (Boncuk p in boncuks)
            {
                if (p.Slug == slug)
                {
                    return p;
                }
            }
            return null;
        }
    }
}