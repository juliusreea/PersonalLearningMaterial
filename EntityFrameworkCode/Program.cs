using System;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkCode.Contexts;
using EntityFrameworkCode.Models;
using System.Linq;

namespace EntityFrameworkCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var dbContext = new BookContext();


            //var book = dbContext.Books.Where(book => book.Id == new Guid("E1AADE1F-136D-4958-8223-FA35499F2677")).Include(x=>x.Pages).First();

            //dbContext.Books.Remove(book);

            //dbContext.SaveChanges();

        }
    }
}
