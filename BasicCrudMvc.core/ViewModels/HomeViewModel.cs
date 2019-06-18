using System.Collections.Generic;
using BasicCrudMvc.core.Models;

namespace BasicCrudMvc.core.ViewModels
{
    public class HomeViewModel
    {
        public string Message { get; set; }

        public List<User> Users { get; set; }
    }
}