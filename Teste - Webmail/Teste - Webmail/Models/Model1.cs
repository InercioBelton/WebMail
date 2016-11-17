namespace Teste___Webmail.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model13")
        {
        }

        public virtual DbSet<Email> Email { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .Property(e => e.Destinatario)
                .IsUnicode(false);

            modelBuilder.Entity<Email>()
              .Property(e => e.Remetente)
              .IsUnicode(false);

            modelBuilder.Entity<Email>()
                .Property(e => e.Assunto)
                .IsUnicode(false);

            modelBuilder.Entity<Email>()
                .Property(e => e.Mensagem)
                .IsUnicode(false);
        }
    }
}
