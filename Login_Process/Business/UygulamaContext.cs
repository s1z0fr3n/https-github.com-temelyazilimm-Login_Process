using Login_Process.Business;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Process
{
    public class UygulamaContext : DbContext
    {        
        public DbSet<SignIn> SignIn { get; set; }
    }
}
