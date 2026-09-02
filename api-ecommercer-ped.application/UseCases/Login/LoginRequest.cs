using api_ecommercer_ped.application.UseCases.CreateUser;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.application.UseCases.Login
{
    public sealed record LoginRequest(string User, string Password) :
        IRequest<LoginResponse>;
}
