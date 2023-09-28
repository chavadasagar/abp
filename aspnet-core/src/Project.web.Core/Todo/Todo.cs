using Abp.MultiTenancy;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Project.web.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.web.Todo
{
    public class Todo : AbpTenant<User>
    {
        public Todo()
        {

        }

        public Todo(string name, string isactive)
        {

        }

        public string Name { get; set; }

        public bool IsActive
        {
            get; set;
        }
    }
}
