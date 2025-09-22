using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Company
{
    public class CompanyCategory : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
