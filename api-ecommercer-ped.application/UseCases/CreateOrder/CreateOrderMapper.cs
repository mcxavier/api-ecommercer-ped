using api_ecommercer_ped.domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.application.UseCases.CreateOrder
{
    public sealed class CreateOrderMapper : Profile
    {
        public CreateOrderMapper() 
        {
            CreateMap<CreateOrderRequest, OrderEntity>();
            CreateMap<OrderEntity, CreateOrderResponse>();
            CreateMap<OrderEntity, OrderDTO>();
            CreateMap<OrderDTO, OrderEntity>();
            CreateMap<OrderItemEntity, OrderItem>();
            CreateMap<OrderItem, OrderItemEntity>();
        }
    }
}
