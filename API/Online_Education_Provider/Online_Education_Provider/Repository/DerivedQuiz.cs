using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Education_Provider.Models;

namespace Online_Education_Provider.Repository
{
    public class DerivedQuiz:IQuiz
    {
        private readonly OnlineEducationProviderContext ctx;

        public DerivedQuiz(OnlineEducationProviderContext _ctx)
        {
            ctx = _ctx;
        }

        //Get
        public async Task<ActionResult<IEnumerable<Quiz>>> Get()
        {

            return await ctx.Quizzes.Include(x => x.Course).ToListAsync();

        }

        //Get by ID
        public async Task<ActionResult<Quiz>> GetByID(int id)
        {
            return await ctx.Quizzes.Include(x=>x.Course).FirstOrDefaultAsync(x => x.QuizId == id);
        }

        //Post
        public async Task<ActionResult<Quiz>> Post(Quiz cs)
        {
            Course acc = ctx.Courses.Find(cs.Course.CourseId);
            cs.Course = acc;
            ctx.Quizzes.AddAsync(cs);
            await ctx.SaveChangesAsync();
            return cs;
        }

        //Put
        public async Task<ActionResult<Quiz>> Put(Quiz cs)
        {
            ctx.Entry(cs).State = EntityState.Modified;
            await ctx.SaveChangesAsync();
            return cs;
        }

        //Delete
        public async Task<ActionResult<string>> Delete(int id)
        {
            Quiz cc = await ctx.Quizzes.FindAsync(id);
            ctx.Quizzes.Remove(cc);
            await ctx.SaveChangesAsync();
            return "Quiz deleted successfully!!!";
        }

        //Count
        public async Task<string> Count(int id)
        {
            int res = await ctx.Quizzes.CountAsync( x=>x.CourseId== id);
            return res.ToString();

        }
        //Filter
        public async Task<ActionResult<IEnumerable<Quiz>>> Filter(string s)
        {
            return await ctx.Quizzes.Where(x => x.QuizDifLevel == s).ToListAsync();
        }

        

    }
}
