using Microsoft.AspNetCore.Mvc;
using Online_Education_Provider.Models;

namespace Online_Education_Provider.Repository
{
    public interface ICourse
    {

        //Get
        public Task<ActionResult<IEnumerable<Course>>> Get();

        //Get by ID
        public Task<ActionResult<Course>> GetByID(int id);

        //POST
        public Task<ActionResult<Course>> Post(Course cs);

        //Put
        public Task<ActionResult<Course>> Put(Course cs);

        //Delete
        public Task<ActionResult<string>> Delete(int id);

        //Count
        public Task<string> Count(int id);
    }
}
