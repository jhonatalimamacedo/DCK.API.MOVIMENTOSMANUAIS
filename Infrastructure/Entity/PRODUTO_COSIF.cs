using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entity
{
    public class PRODUTO_COSIF
    { 
        [Key]
        public string COD_PRODUTO { get; set; }
        [Key]
        public string COD_COST { get; set; }
        public string COD_CLASSIFICACAO { get; set; }
        public string STA_STATUS { get; set; }
    }
}
