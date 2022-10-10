using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entity
{
    public class PRODUTO
    {
        [Key]
        [MaxLength(4)]
        public string COD_PRODUTO { get; set; }
        [MaxLength(30)]
        [AllowNull]
        public string DES_PRODUTO { get; set; }
        [MaxLength(1)]
        [AllowNull]
        public string STA_STATUS { get; set; }
    }
}
