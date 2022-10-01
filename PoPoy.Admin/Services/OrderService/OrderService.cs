﻿using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using PoPoy.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PoPoy.Admin.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        private readonly NavigationManager _navigationManager;
        public OrderService(HttpClient httpClient,
                           ILocalStorageService localStorage,
                           NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
            _navigationManager = navigationManager;
        }
        public async Task<List<Order>> GetAllOrders()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Order>>("/api/order");
            return result;
        }

        public async Task<List<OrderDetails>> GetOrderDetails(string orderId)
        {
            var result = await _httpClient.GetFromJsonAsync<List<OrderDetails>>($"/api/order/orderDetails/{orderId}");
            return result;
        }
    }
}