using CodigoSistClases.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodigoSistClases.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GradesController : ControllerBase
    {
        [HttpGet]
        public List<Grade> GetGrades()
        {
            using (var context = new DemoContext() )
            {
                return context.Grades.ToList();
            }
        }
        
        [HttpPost]
        public void InsertGrades(Grade _grade)
        {
            using (var context = new DemoContext())
            {
                context.Grades.Add( _grade );
                context.SaveChanges();
            }
        }
    }
}
