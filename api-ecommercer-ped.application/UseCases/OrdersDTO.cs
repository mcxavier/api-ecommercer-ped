using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.application.UseCases
{
    public record OrdersDTO
    {
        public List<OrderDTO> Orders { get; init; } = new List<OrderDTO>();
    }
      

}   
