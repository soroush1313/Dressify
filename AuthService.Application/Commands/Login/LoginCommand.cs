using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Application.Commands.Login
{
    public class LoginCommand : IRequest<string>
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
