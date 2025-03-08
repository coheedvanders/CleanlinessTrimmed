using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanlinessTrimmed.Domain.Entities;

namespace CleanlinessTrimmed.Application.Accounts.Queries.GetAccountList
{
    public class AccountDto
    {
        public  int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        private class Mapping: Profile
        {
            public Mapping()
            {
                CreateMap<Account, AccountDto>();
            }
        }
    }
}
