using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denwme
{
    public  class AdalaContext:DbContext
        
    {
        public AdalaContext():base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Adala;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }
        public DbSet<Word> Word { get; set; }
        public DbSet<Synonmys> Synonmys { get; set; }
        public DbSet<Sentence> Sentence { get; set; }
    }
}
