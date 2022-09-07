using FA22.P03.Web.Features.Products;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace FA22.P03.Web.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<DataContext>();
            context?.Database.Migrate();

            AddProducts(context);
        }

        private static void AddProducts(ModelBuilder builder)
        {
            builder.Entity<Product>()
                .HasData(
                new Product
                {
                    Id = 1,
                    Name = "Xbox Series X",
                    Description = "Brand new XBox Series X",
                },
                new Product
                {
                    Id = 2,
                    Name = "PlayStation 5",
                    Description = "Used PS5",
                },
                new Product
                {
                    Id = 3,
                    Name = "Nintendo Switch",
                    Description = "Brand new Nintendo Switch",
                });
        }
    }
}
*/