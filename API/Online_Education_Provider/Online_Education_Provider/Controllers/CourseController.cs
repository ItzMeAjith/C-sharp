using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Education_Provider.Models;
using Online_Education_Provider.Repository;

namespace Online_Education_Provider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourse co;
        public CourseController(ICourse _co)
        {
            co= _co;
        }

        //Get 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> Get()
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
        [HttpGet("/{id}")]
        public async Task<ActionResult<Course>> GetByID(int id)
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
        public async Task<ActionResult<Course>> Post(Course cs)
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
        public async Task<ActionResult<Course>> Put(Course cs)
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
        [HttpGet("Courses/{id}")]
        public async Task<string> Count(int id)
        {
            try
            {
                return $"The count of courses having the popularity {id} is : {await co.Count(id)}";
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message).ToString();
            }
        }
    }
}
