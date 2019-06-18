using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCrudMvc.core.Contracts
{
    public class IUserRepository
    {
        public IEnumerable<User> getAllUsers();
    }
}
