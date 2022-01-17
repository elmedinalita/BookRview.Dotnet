using BookReviewAPI.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace BookReviewAPI.Data
{
    public class AppDbInitialer
    {
        public static void seed(IApplicationBuilder applicationBuider)
        {
            using (var serviceScope = applicationBuider.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContex>();

                if(context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        BookTittle = "Njeriu i Padukshem",
                        Description = "Nje liber i kendshem per tu lexuar",
                        Rate = 5
                    },

                     new Book()
                     {
                         BookTittle = "Njeriu i Padukshem",
                         Description = "Nje liber i kendshem per tu lexuar",
                         Rate = 5
                     });
                    context.SaveChanges();
                }
            }
        }
    }
}
