using System;
using EFSQLite.Models;
using Microsoft.EntityFrameworkCore;

namespace EFSQLite.Database
{
    public class EFSQLiteDBContext : DbContext
    {

        public string DbPath { get; private set; }

        public DbSet<User> Users { get; set; }

        public EFSQLiteDBContext()
        {

            var path = System.IO.Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), AppDomain.CurrentDomain.FriendlyName);
            System.IO.Directory.CreateDirectory(path);
            DbPath = System.IO.Path.Join(path, "db.sqlite");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
