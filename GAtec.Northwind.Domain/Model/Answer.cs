using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAtec.Northwind.Domain.Model
{
    class Answer
    {
        public virtual int Id { get; set; }

        public virtual string Description { get; set; }

        public virtual int QuesionId { get; set; }

        public virtual bool IsRight { get; set; }

        public virtual Question Question { get; set; }
    }
}
