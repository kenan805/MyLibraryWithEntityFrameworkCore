// See https://aka.ms/new-console-template for more information
using MyLibraryWithEntityFrameworkCore.Context;
using MyLibraryWithEntityFrameworkCore.Models;


using (var context = new MyDbContext())
{
    context.Authors?.Add(new Author { FirstName = "Robert Cecil", LastName = "Martin" });
    context.SaveChanges();
}
Console.WriteLine("Success!");