using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudCliente.Models
{
    public class VitalConnectContext : DbContext
    {
        protected VitalConnectContext() 
        {

        }

        public VitalConnectContext(DbContextOptions<VitalConnectContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }

}
