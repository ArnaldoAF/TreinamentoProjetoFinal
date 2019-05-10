using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAtec.Northwind.Domain.Model
{
    class Selection
    {
        public virtual int Id { get; set; } 

        public virtual DateTime Date { get; set; }

        public virtual int CadidateId { get; set; }

        public virtual Candidate Candidate { get; set; }

    }
}
