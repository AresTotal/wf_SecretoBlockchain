using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace wf_SecretoClient
{
    public class BlockchainContext : DbContext
    {
        public DbSet<Block> Blocks => Set<Block>();
        public BlockchainContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=blockchain.db");
        }
    }
}
