using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAuthServer.Data
{

    
        public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
        {
            public AppDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

                // 🔥 DİKKAT: Burası gerçek connection string olacak
                // \ karakteri C# içinde kaçış karakteridir, bu yüzden @"" ya da \\ kullanman gerekiyor
                optionsBuilder.UseSqlServer(
                    @"Data Source=DESKTOP-BDEVM4N\SQLEXPRESS;Initial Catalog=TokenDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False",
                    sqlOptions =>
                    {
                        sqlOptions.MigrationsAssembly("UdemyAuthServer.Data");
                    });

                return new AppDbContext(optionsBuilder.Options);
            }
        }
    }

