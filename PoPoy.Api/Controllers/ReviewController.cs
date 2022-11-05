﻿using System;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using System.Net.Mime;
using PoPoy.Api.Services.ReviewService;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using PoPoy.Shared.Dto;
using System.Collections.Generic;
using System.Linq;
using PoPoy.Shared.Paging;
using Newtonsoft.Json;

namespace PoPoy.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService reviewService;

        public ReviewController(IReviewService reviewService)
            => this.reviewService = reviewService;

        [AllowAnonymous]
        [HttpGet("{id}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async ValueTask<ActionResult<Review>> Get(int id)
        {
            var review = await reviewService.GetAsync(id);
            if (review is null)
                return NotFound("Không tìm thấy đánh giá.");

            return Ok(review);
        }

        [AllowAnonymous]
        [HttpGet("filter/{productId}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async ValueTask<ActionResult<List<Review>>> FilterByProductIdAsync(int productId, [FromQuery] ProductParameters productParameters)
        {
            var reviews = await reviewService.FilterByProductIdAsync(productId ,productParameters);
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(reviews.MetaData));
            return Ok(reviews);
        }

        [Authorize]
        [HttpPost]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async ValueTask<ActionResult<int>> Post(Review review)
            => Ok(await reviewService.PostAsync(review, GetUserId()));

        [Authorize]
        [HttpPut]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async ValueTask<ActionResult> Put(Review review)
        {
            var statusCode = await reviewService.PutAsync(review, GetUserId());

            return statusCode switch
            {
                StatusCodes.Status400BadRequest => BadRequest(),
                StatusCodes.Status404NotFound => NotFound("Không tìm thấy đánh giá."),
                _ => NoContent()
            };
        }

        [Authorize]
        [HttpDelete("{id}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async ValueTask<ActionResult> Delete(int id)
        {
            var statusCode = await reviewService.DeleteAsync(id, GetUserId());

            return statusCode switch
            {
                StatusCodes.Status400BadRequest => BadRequest(),
                StatusCodes.Status404NotFound => NotFound("Không tìm thấy đánh giá."),
                _ => NoContent()
            };
        }

        private Guid GetUserId()
            => Guid.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
    }
}



