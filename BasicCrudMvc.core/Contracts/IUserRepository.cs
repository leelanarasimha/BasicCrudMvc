using System;
using System.Collections.Generic;
using System.Text;
using BasicCrudMvc.core.Models;

namespace BasicCrudMvc.core.Contracts
{
    public interface IUserRepository
    {
        IEnumerable<User> getAllUsers();
    }
}
