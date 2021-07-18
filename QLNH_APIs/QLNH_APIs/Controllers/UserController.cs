﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;  
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _context.User.ToList();
        }
    }
}
