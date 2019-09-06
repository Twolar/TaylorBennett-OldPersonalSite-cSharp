using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaylorBennett.FrontEnd.Services
{
    public interface IAdminService
    {
        long CreationKey { get; }
        Task<bool> AllowAdminUserCreationAsync();
    }
}
