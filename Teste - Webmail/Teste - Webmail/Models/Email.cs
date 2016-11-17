namespace Teste___Webmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Email")]
    public partial class Email
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Remetente { get; set; }

        [StringLength(50)]
        public string Destinatario { get; set; }

        [StringLength(150)]
        public string Assunto { get; set; }

        [StringLength(250)]
        public string Mensagem { get; set; }
    }
}
