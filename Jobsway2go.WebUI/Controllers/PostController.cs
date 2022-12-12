using Jobsway2go.Core.Enums;
using Jobsway2go.Core.Interfaces;
using Jobsway2go.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jobsway2go.WebUI.Controllers
{ 
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var posts = _postService.GetAll();

            return View(posts);
        }
        /*
        [HttpPost]
        public async Task<IActionResult> Create(Post post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _postService.Add(post);
            await _postService.SaveChangesAsync();

            return Ok(post);
        }

        [HttpGet]
        public async Task<IActionResult> Read(int id)
        {
            // Get the post by id
            var post = await _postService.GetByIdAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }
        
        [HttpPut]
        public async Task<IActionResult> Edit(Post post)
        {
            // Validate the post model
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Get the existing post
            var existingPost = await _postService.GetByIdAsync(post.Id);
            if (existingPost == null)
            {
                return NotFound();
            }

            // Update the post
            existingPost.Title = post.Title;
            existingPost.Description = post.Description;
            existingPost.CreatedAtUTC = post.CreatedAtUTC;
            existingPost.CreatedByUserId = post.CreatedByUserId;
            existingPost.Type = post.Type;

            // Save the changes to the database
            await _postService.SaveChangesAsync();

            return Ok(existingPost);
            }
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            // Get the post by id
            var post = await _postService.GetByIdAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            // Delete the post
            _postService.Remove(post);

            // Save the changes to the database
            await _postService.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> SearchPost(string query)
        {
            // Search for posts that match the given query
            var posts = await _postService.Find(
                p => p.Title.Contains(query) || p.Description.Contains(query),
                p => p.CreatedByUserId
            );

            return Ok(posts);
        }

        [HttpGet]
        public async Task<IActionResult> FilterByType(PostType type)
        {
            // Filter posts by type
            var posts = await _postService.Find(
                p => p.Type == type,
                p => p.CreatedByUserId
            );

            return Ok(posts);
        }*/
    }
}