using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online_Education_Provider.Models;
using Online_Education_Provider.Repository;

namespace Online_Education_Provider.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuiz co;
        public QuizController(IQuiz _co)
        {
            co = _co;
        }

        //Get 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Quiz>>> Get()
        {
            try
            {
                return await co.Get();
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        //Get By ID
        [HttpGet("Quiz/{id}")]
        public async Task<ActionResult<Quiz>> GetByID(int id)
        {
            try
            {
                return await co.GetByID(id);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        //POST
        [HttpPost]
        public async Task<ActionResult<Quiz>> Post(Quiz cs)
        {
            try
            {
                return await co.Post(cs);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        //Put
        [HttpPut]
        public async Task<ActionResult<Quiz>> Put(Quiz cs)
        {
            try
            {
                return await co.Put(cs);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        //Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult<string>> Delete(int id)
        {
            try
            {
                return await co.Delete(id);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        //Count
        [HttpGet("Quizzes/{id}")]
        public async Task<string> Count(int id)
        {
            try
            {
                return $"The count of Quizzes in the course ID {id} is : {await co.Count(id)}";
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message).ToString();
            }
        }

        //Filter
        [HttpGet("Quizzes/")]
        public async Task<ActionResult<IEnumerable<Quiz>>> Filter(string s)
        {
            try
            {
                return await co.Filter(s);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }
    }
}
