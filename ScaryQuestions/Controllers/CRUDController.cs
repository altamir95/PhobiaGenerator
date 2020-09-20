using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScaryQuestions.Models;

namespace ScaryQuestions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CRUDController : ControllerBase
    {
        ScaryQuestionsContext db;
        public CRUDController(ScaryQuestionsContext context)
        {
            db = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Question>>> Get()
        {
            return await db.Questions.ToListAsync();
        }
    }
}
