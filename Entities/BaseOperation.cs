using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BaseOperation
    {
        public int Id { get; set; }
        public DateTime? OperationDate { get; set; }
        public string Detay { get; set; }

    }
}
