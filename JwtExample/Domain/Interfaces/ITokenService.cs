using JwtExample.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtExample.Domain.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
