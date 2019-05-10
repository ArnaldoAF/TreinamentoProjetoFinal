using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAtec.Northwind.Domain.Model
{
    class Question
    {
        public virtual int id { get; set; }

        public virtual string Description { get; set; }

        public virtual int Type { get; set; }

        public virtual int SelectionId { get; set; }

        public virtual Selection Selection { get; set; }

    }
}
