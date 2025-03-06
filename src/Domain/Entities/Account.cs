using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CleanlinessTrimmed.Domain.Entities
{
    public class Account: BaseEntity
    {
        public string Name { get; set; } = string.Empty;
    }
}
