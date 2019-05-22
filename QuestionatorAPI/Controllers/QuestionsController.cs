using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using QuestionatorAPI.UseCase;

namespace QuestionatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class QuestionsController : ControllerBase
    {
        // GET api/questions
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var listQuestions = new ListQuestions();
            var questions = listQuestions.Execute();
                
            return questions;
        }

        // GET api/questions/id
        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            return $"single question {id}";
        }
        
        [HttpPost("{question}")]
        public ActionResult<string> Post(string question)
        {
            return "this is a POST";
        }

    }
}