using api_ecommercer_ped.application.UseCases.CreateOrder;
using api_ecommercer_ped.domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.application.UseCases.ListOrders
{
    public sealed class ListOrderMapper : Profile
    {
        public ListOrderMapper()
        {
            CreateMap<ListOrderRequest, OrderEntity>();
            CreateMap<OrderEntity, ListOrderResponse>();
            CreateMap<OrderEntity, OrderDTO>();
            CreateMap<OrderDTO, OrderEntity>();
            CreateMap<OrderItemEntity, OrderItem>();
            CreateMap<OrderItem, OrderItemEntity>();
        }
    }
}
