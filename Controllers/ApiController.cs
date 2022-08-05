using Microsoft.AspNetCore.Mvc;
using WebEOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace WebEOC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {


        private readonly ILogger<ApiController> _logger;

        private readonly ProQAContext _context;

        public ApiController(ProQAContext context)
        {
            _context = context;
        }

        /*public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }*/
        [HttpGet("")]
        public String index ()
        {
            return "WebEOC API v1";
        }

        [HttpGet("GetLogs")]
        public IEnumerable<Log> Get()
        {
            return _context.Logs;
        }


        // GET GetLogByID/5
        [HttpGet("GetLogByID/{id}")]
        
        public Log Get(int id)
        {
            return _context.Logs.FirstOrDefault(s => s.Id == id);
        }

    }
}