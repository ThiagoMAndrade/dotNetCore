using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudCliente.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudCliente.Configuracoes
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public override void Map(EntityTypeBuilder<Cliente> modelBuilder)
        {
            modelBuilder.HasKey(p => p.ClienteId);
            modelBuilder.Property(p => p.Nome).IsRequired().HasMaxLength(120);



            modelBuilder.ToTable("cliente");
        }
    }
}
