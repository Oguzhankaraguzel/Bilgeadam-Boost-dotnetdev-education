using Bogus;
using GROUP2_apı_list.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GROUP2_apı_list.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        // GET: api/<StudentController>
        [HttpGet]
        public List<Student> Get()
        {
            List<Student> students = GenerateStudents(100);
            return students;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private List<Student> GenerateStudents(int count)
        {
            var faker = new Faker<Student>()
                .RuleFor(s => s.Id, f => f.IndexFaker)
                .RuleFor(s => s.Name, f => f.Name.FirstName())
                .RuleFor(s => s.SurName, f => f.Name.LastName())
                .RuleFor(s => s.Address, f => f.Address.FullAddress());

            return faker.Generate(count);
        }
    }
}
