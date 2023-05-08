using Microsoft.AspNetCore.Mvc;
using Online_Education_Provider.Models;

namespace Online_Education_Provider.Repository
{
    public interface IQuiz
    {
        //Get
        public Task<ActionResult<IEnumerable<Quiz>>> Get();

        //Get by ID
        public Task<ActionResult<Quiz>> GetByID(int id);

        //POST
        public Task<ActionResult<Quiz>> Post(Quiz cs);

        //Put
        public Task<ActionResult<Quiz>> Put(Quiz cs);

        //Delete
        public Task<ActionResult<string>> Delete(int id);

        //Count
        public Task<string> Count(int id);

        //Filter by level
        public Task<ActionResult<IEnumerable<Quiz>>> Filter(string s);
    }
}
