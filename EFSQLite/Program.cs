using System;
using EFSQLite.Database;
using EFSQLite.Models;

namespace EFSQLite
{
    class Program
    {
        static void Main(string[] args)
        {

            using(var ctx = new EFSQLiteDBContext())
            {
                Console.WriteLine($"Using: {ctx.DbPath}");

                ctx.Database.EnsureCreated();

                var u = new User { Name = "c1" };
                ctx.Add(u);
                u = new User { Name = "123456789012345678901234567890" };
                ctx.Add(u);
                ctx.SaveChanges();

                Console.WriteLine("Done.");
            }
        }
    }
}
