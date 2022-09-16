﻿using PoPoy.Shared.Dto;
using PoPoy.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PoPoy.Admin.Services.ProductService
{
    public interface IProductService
    {
        Task<List<ProductVM>> GetAllProducts();
        Task<List<ProductVM>> SearchProduct(string searchText);
        Task<ProductVM> GetProductById(int productId);
        Task<bool> CreateProduct(ProductCreateRequest request);
        Task UpdateProduct(ProductVM product);
        Task DeleteProduct(int productId);
        Task DeleteFile(int imageId);
        Task AssignCate(CategoryAssignRequest request);
        Task<CategoryAssignRequest> GetCateAssignRequest(int productId);
    }
}
