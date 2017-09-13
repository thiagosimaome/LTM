using System.Data.Entity.ModelConfiguration;
using LTM.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTM.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(p => p.clienteId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.SobreNome)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Idade)
                .IsRequired();

            Property(p => p.Ativo)
                .IsRequired();
        }
    }
}
