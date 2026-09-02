using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.application.UseCases.Login
{
    public sealed record LoginResponse
    {
        public Guid SessionId { get; set; }
        public string Token { get; set; }
    }
}
