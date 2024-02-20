using ED_double2.Data.Context;
using ED_double2.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace EF_double2
{
    internal class Program
    {
        static void SaveProductChanges(Product? product)
        {
            using ProductDbContext context = new ProductDbContext();
            context?.Update(product!);

            context?.SaveChanges();
        }

        static void Main(string[] args)
        {
            using ProductDbContext context = new ProductDbContext();

            Product? product = context.Products
                .FirstOrDefault(p => p.Id == 1);


            if (product != null)
                product.Name += "- expensive";

            SaveProductChanges(product);
        }
    }
}