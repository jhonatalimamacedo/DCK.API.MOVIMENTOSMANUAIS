using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entity
{
    public class MOVIMENTO_MANUAL
    {
       [Key]
       [MaxLength(2)]
       public int DAT_MES { get; set; }

       [Key]
       [MaxLength(4)]
       public int DAT_ANO { get; set; }

       [Key]
       [MaxLength(18)]
       public int NUM_LANCAMENTO { get; set; }

       [Key]
       [MaxLength(4)]
       public string COD_PRODUTO { get; set; }

       [MaxLength(11)]
       [ForeignKey("COD_COSIF")]
       public string COD_COSIF { get; set; }
       public PRODUTO_COSIF PRODUTO_COSIF_COD_COSIF { get; set; }

       [MaxLength(50)]
       public string DES_DESCRICAO { get; set; }

       public DateTime DAT_MOVIMENTO { get; set; }

       [MaxLength(15)]
       public string COD_USUARIO { get; set; }

       [MaxLength(12)]
       public decimal VAL_VALOR { get; set; }
    }
}
