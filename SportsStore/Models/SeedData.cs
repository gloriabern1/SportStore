using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A boat for one person",
                        Category = "Watersports",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "LifeJacket",
                        Description = "Protective and fashionable",
                        Category = "Watersports",
                        Price = 48.84m
                    },
                    new Product
                    {
                        Name = "soccer ball",
                        Description = "Fifa approved size and weight",
                        Category = "Soccer",
                        Price = 34.5m
                    },
                    new Product
                    {
                        Name = "Corner flags",
                        Description = "filed professional touch",
                        Category = "Soccer",
                        Price = 56.3m
                    },
                    new Product
                    {
                        Name = "Stadium",
                        Description = "flat packed with people",
                        Category = "Soccer",
                        Price = 79500
                    },
                     new Product
                     {
                         Name = "Thinking cap",
                         Description = "improve brain efficiency by 35%",
                         Category = "Chess",
                         Price = 27
                     },
                      new Product
                      {
                          Name = "Usteady Chair",
                          Description = "give oppotent a disadvantag",
                          Category = "Chess",
                          Price = 27.5m
                      }

                    );
                context.SaveChanges();
            }
        }
    }
}
