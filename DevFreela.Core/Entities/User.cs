using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class User
    {
        public string UserName { get; private set; }
        public string UserPassword { get; private set; }
        public string Role { get; private set; }
        public UserStatusEnum Status {  get; private set; }


    }
}
