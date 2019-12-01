﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;

namespace MyBlog.WebUI.Controllers
{
    public class PostController : Controller
    {
	    private IPostService _postService;

	    public PostController(IPostService postService)
	    {
		    _postService = postService;
	    }

		[HttpGet("/posts")]
	    public IActionResult Index()
        {
            return View();
        }

	    [HttpGet("/post")]
	    public IActionResult GetPost()
	    {
		    return View();
	    }
    }
}