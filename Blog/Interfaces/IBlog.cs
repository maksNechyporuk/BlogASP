﻿using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Interfaces
{
    public interface IBlogRepository
    {
        BlogModel GetPostById(int id);
        IEnumerable<BlogModel> GetAllPosts();
        BlogModel CreatePost(BlogModel post);
        BlogModel UpdatePost(BlogModel newPost);
        BlogModel DeletePost(int Id);
    }
}
