using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entity
{
    public class MOVIMENTO_MANUAL
    {
       [Key]
       public int DAT_MES { get; set; }
       public int DAT_ANO { get; set; }
       public int NUM_LANCAMENTO { get; set; }
       public string COD_PRODUTO { get; set; }
       public string COD_COSIF { get; set; }
       public string DES_DESCRICAO { get; set; }
       public DateTime DAT_MOVIMENTO { get; set; }
       public string COD_USUARIO { get; set; }
       public int VAL_VALOR { get; set; }
    }
}
