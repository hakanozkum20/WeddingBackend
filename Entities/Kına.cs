using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Kına : BaseOperation, IEntity
    {
        public bool KınaOrganizasyon { get; set; }
        public int ProgramId { get; set; }
    }
}
