using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndiaMirror.Models
{
    public interface IUserRepository
    {
        Users GetUsers(int Id);
        IEnumerable<Users> GetAllUserss();
        Users Add(Users Users);
        Users Update(Users UsersChanges);
        Users Delete(int Id);
    }
}
