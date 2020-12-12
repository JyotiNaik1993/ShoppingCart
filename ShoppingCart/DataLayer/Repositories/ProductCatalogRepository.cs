using DataLayer.Models;
using System.Collections.Generic;

namespace DataLayer.Repositories
{
    public class ProductCatalogRepository : IProductCatalogRepository
    {
        public ProductCatalog GetProduct()
        {
            return new ProductCatalog
            {

                MensFashion = new List<MensFashion>()
                {
                     new MensFashion()
                    {
                        Id = 1,
                        ItemName = "Jacket",
                        ItemPrice = 1000,
                        ViewCount = 10
                    },
                     new MensFashion()
                    {
                        Id = 2,
                        ItemName = "Jeans",
                        ItemPrice = 2000,
                         ViewCount = 9
                    },
                      new MensFashion()
                    {
                        Id = 3,
                        ItemName = "T-Shirt",
                        ItemPrice = 500,
                         ViewCount = 20
                    },
                      new MensFashion()
                    {
                        Id = 4,
                        ItemName = "Shirts",
                        ItemPrice = 3000,
                         ViewCount = 4
                    },
                     new MensFashion()
                    {
                        Id = 5,
                        ItemName = "Shoes",
                        ItemPrice = 5000,
                         ViewCount = 1
                    }

                  },

                Mobiles = new List<Mobiles>()
                {
                     new Mobiles()
                    {
                        Id = 1,
                        ItemName = "IPhone5",
                        ItemPrice = 30000,
                         ViewCount = 15
                    },
                     new Mobiles()
                    {
                        Id = 2,
                        ItemName = "IPhone5",
                        ItemPrice = 40000,
                         ViewCount = 6
                    },
                      new Mobiles()
                    {
                        Id = 3,
                        ItemName = "IPhone5",
                        ItemPrice = 50000,
                         ViewCount = 20
                    },
                      new Mobiles()
                    {
                        Id = 4,
                        ItemName = "IPhone5",
                        ItemPrice = 60000,
                         ViewCount = 12
                    },
                     new Mobiles()
                    {
                        Id = 5,
                        ItemName = "IPhone5",
                        ItemPrice = 70000,
                         ViewCount = 14
                    }

                  }
            };
            
        }

    }
}
