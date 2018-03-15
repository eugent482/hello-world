using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class EFcontext: DbContext
    {
        public EFcontext():base ("TreeCon")
        {
            Database.SetInitializer<DbContext>(null);
        }
        public DbSet<Category> Categories { get; set; }
    }
}
