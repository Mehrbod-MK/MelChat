using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelChatServerCLI.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace MelChatServerCLI.DB
{
    public class MelChatServerDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MEHRBOD-PC;Initial Catalog=MelChat;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
