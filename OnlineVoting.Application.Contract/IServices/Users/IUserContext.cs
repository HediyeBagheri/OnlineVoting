using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVoting.Application.Contract.IServices.Users
{
    public interface IUserContext
    {
        public string UserId { get; set; }
    }
}
