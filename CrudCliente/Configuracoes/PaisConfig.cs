using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudCliente.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudCliente.Configuracoes
{
    public class PaisConfig : EntityTypeConfiguration<Pais>
    {
        public override void Map(EntityTypeBuilder<Pais> modelBuilder)
        {
            modelBuilder.HasKey(p => p.PaisId);
            modelBuilder.Property(p => p.Nome).IsRequired().HasMaxLength(120);



            modelBuilder.ToTable("pais");
        }
    }
}
