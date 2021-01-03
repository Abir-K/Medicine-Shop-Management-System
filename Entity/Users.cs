using Medicalshop.DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicalshop.Entity
{
    class Users
    {
        public string UserName { set; get; }
        public string UserConatct { get; set; }
        public string UserAddress { get; set; }
        public string UserDesignation { get; set; }
        public string UserDOB { get; set; }
        public string UserPassword { get; set; }
        public int UserId { get; set; }
       

    }
}
