using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
using Newtonsoft.Json;
using System;


namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StudentController : ControllerBase
    {
        private static List<Student> students = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "Karan",
                    Age =  23,
                    City = "Mumbai"
                }
            };

        private readonly ConnectionMultiplexer _redisConnection;

        public StudentController()
        {
            _redisConnection = ConnectionMultiplexer.Connect("localhost");
        }
        [HttpGet]
        [Route("storeObjectInRedis")]
        public void StoreObjectInRedis(string key, object value)
        {
            var redis = _redisConnection.GetDatabase();

            string jsonValue = JsonConvert.SerializeObject(value);

            redis.StringSet(key, jsonValue);
        }

        [HttpGet]
        [Route("retrieveObjectFromRedis")]
        public T RetrieveObjectFromRedis<T>(string key)
        {
            var redis = _redisConnection.GetDatabase();

            string jsonValue = redis.StringGet(key);

            return JsonConvert.DeserializeObject<T>(jsonValue);
        }

        [HttpGet]
        [Route("exampleMethod")]
        public void ExampleMethod()
        {
            StoreObjectInRedis("sampleObject", students);

            var retrievedObject = RetrieveObjectFromRedis<dynamic>("sampleObject");

        }


        [HttpGet]
        [Route("getStudents")]

        public async Task<ActionResult<Student>> GetStudents()
        {
            StoreObjectInRedis("sampleObject", students);
            return Ok(students);
        }


        [HttpGet]
        [Route("findStudent")]

        public async Task<ActionResult<Student>> FindStudent(int id)
        {
            var student = students.Find(x => x.Id == id);
            if (student == null)
                return BadRequest("No Student found");

            return Ok(students);
        }

        [HttpPost]
        [Route("addStudent")]

        public async Task<ActionResult<Student>> AddStudent(Student request)
        {
            students.Add(request);
            StoreObjectInRedis("sampleObject", students);

            return Ok(students);
        }

        [HttpPut]
        [Route("updateStudent")]

        public async Task<ActionResult<Student>> UpdateStudent(Student request)
        {
            var student = students.Find(x => x.Id == request.Id);
            if (student == null)
                return BadRequest("No Student found");
            student.Name = request.Name;
            student.Age = request.Age;
            student.City = request.City;
            StoreObjectInRedis("sampleObject", students);
            return Ok(students);
        }


        [HttpDelete]
        [Route("deleteStudent")]

        public async Task<ActionResult<Student>> deleteStudent(int id)
        {
            var student = students.Find(x => x.Id == id);
            if (student == null)
                return BadRequest("No Student found");
            students.Remove(student);
            StoreObjectInRedis("sampleObject", students);
            return Ok(students);
        }
    }
}