using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // Attribute
    public class CoursesController : ControllerBase
    {
        //Loosely coupled / gevşek bağlılık
        //naming convention
        //IoC Container -- Inversion of Control / Değişimin kontrolü
        //Hiçbir katman diğer katmanların somut classlarına bağlı olmamalıdır. Diğer katmanların soyut sınıfları üzerinden işlem yapılmalıdır.
        ICourseService _courseService;       

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public List<Course> Get()
        {             
            //Dependency chain --
            var result = _courseService.GetAll();
            return result.Data;
        }
    }
}
