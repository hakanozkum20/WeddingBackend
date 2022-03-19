using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Dugun : BaseOperation , IEntity
    {
        public bool Dj { get; set; }
        public bool Menu { get; set; }
        public int ProgramId { get; set; }
    }
}
