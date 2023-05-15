using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Education_Provider.Models;

namespace Online_Education_Provider.Repository
{
    public class DerivedCourse : ICourse
    {
        private readonly OnlineEducationProviderContext ctx;

        public DerivedCourse(OnlineEducationProviderContext _ctx)
        {
            ctx = _ctx;
        }

        //Get
        public async Task<ActionResult<IEnumerable<Course>>> Get()
        {

            return await ctx.Courses.Include(x => x.Quizzes).ToListAsync();

        }

        //Get by ID
        public async Task<ActionResult<Course>> GetByID(int id)
        {
            return await ctx.Courses.Include(x => x.Quizzes).FirstOrDefaultAsync(x => x.CourseId == id);
        }

        //Post
        public async Task<ActionResult<Course>> Post(Course cs)
        {
            ctx.Courses.AddAsync(cs);
            await ctx.SaveChangesAsync();
            return cs;
        }

        //Put
        public async Task<ActionResult<Course>> Put(Course cs)
        {
            ctx.Entry(cs).State = EntityState.Modified;
            await ctx.SaveChangesAsync();
            return cs;
        }

        //Delete
        public async Task<ActionResult<string>> Delete(int id)
        {
            Course cc = await ctx.Courses.FindAsync(id);
            ctx.Courses.Remove(cc);
            await ctx.SaveChangesAsync();
            return "Course deleted successfully!!!";
        }

        //Count
        public async Task<string> Count(int id)
        {
            int res = ctx.Courses.Count(x => x.CourseRating == id);
            return res.ToString();

        }


    }
}
