using api_ecommercer_ped.application.UseCases.CreateOrder;
using api_ecommercer_ped.domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.application.UseCases.CancelOrder
{
    public sealed class CancelOrderMapper : Profile
    {
        public CancelOrderMapper()
        {
            CreateMap<CancelOrderRequest, OrderEntity>();
            CreateMap<OrderEntity, CancelOrderResponse>();
            CreateMap<OrderEntity, OrderDTO>();
            CreateMap<OrderDTO, OrderEntity>();
            CreateMap<OrderItemEntity, OrderItem>();
            CreateMap<OrderItem, OrderItemEntity>();
        }
    }
}
