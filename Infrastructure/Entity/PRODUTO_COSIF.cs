using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entity
{
    public class PRODUTO_COSIF
    {
        [MaxLength(4)]
        public string COD_PRODUTO { get; set; }
        [ForeignKey("COD_PRODUTO")]
        public PRODUTO PRODUTO { get; set; }

        [Key]
        [MaxLength(11)]
        public string COD_COST { get; set; }

        [MaxLength(6)]
        [AllowNull]
        public string COD_CLASSIFICACAO { get; set; }

        [MaxLength(1)]
        [AllowNull]
        public string STA_STATUS { get; set; }
    }
}
