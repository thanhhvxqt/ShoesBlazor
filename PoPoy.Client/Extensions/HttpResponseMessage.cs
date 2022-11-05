﻿using PoPoy.Client.Services.AuthService;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PoPoy.Client.Extensions
{
    public static class HttpResponseMessageExtension
    {
        public static async ValueTask HandleError(this HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
                return;

            var message = await response.Content.ReadFromJsonAsync<string>();

            var ex = new Exception();
            ex.Data.Add((int)response.StatusCode, message);
            throw ex;
        }
        public static bool CheckAuthorized(this HttpResponseMessage response, IAuthService authService)
        {
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                authService.Logout();
                return false;
            }

            return true;
        }
    }
}



