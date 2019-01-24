using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Abstract;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private IMessageRepository messageRepo;
       public MessageController(IMessageRepository repo)
        {
            messageRepo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<Message>> Get()
        {
            return await messageRepo.getMessage();
        } 
    }
}