using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Task1Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private  List<Course> courses = new List<Course>()
        {
        new  Course(){id=1,name="Math",duration="Math1",status=true},
         new  Course(){id=2,name="computer",duration="computer1",status=false},
          new  Course(){id=1,name="scinse",duration="scinse1",status=true},

        };

        [HttpGet]
       
        public List<Course> GetAllCourse()
        {
            return courses;
        }

        [HttpGet]
        [Route("{id}")]
        
        public Course GetCourseById(int id)
        {
            return courses.Where(x => x.id == id).FirstOrDefault();
        }
    }
}
