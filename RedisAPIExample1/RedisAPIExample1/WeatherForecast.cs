
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StackExchange.Redis;

namespace RedisWebAPI.Controllers
{
    public class RedisDataController : ApiController
    {
        private readonly ConnectionMultiplexer _redisConnection;

        public RedisDataController()
        {
            // Initialize Redis connection
            _redisConnection = ConnectionMultiplexer.Connect("localhost");
        }

        // Endpoint for fetching all data
        public IHttpActionResult GetAllData()
        {
            var redis = _redisConnection.GetDatabase();
            var keys = redis.Execute("KEYS", "*");
            var data = new List<object>();
            foreach (var key in (RedisResult[])keys)
            {
                var value = redis.StringGet((string)key);
                data.Add(new { id = (string)key, value = (string)value });
            }
            return Ok(data);
        }

        // Endpoint for fetching a specific data item by ID
        public IHttpActionResult GetDataById(string id)
        {
            var redis = _redisConnection.GetDatabase();
            var value = redis.StringGet(id);
            if (value.IsNull)
                return NotFound();
            return Ok(new { id, value });
        }

        // Endpoint for creating new data
        public IHttpActionResult PostData([FromBody] KeyValueModel model)
        {
            var redis = _redisConnection.GetDatabase();
            redis.StringSet(model.Key, model.Value);
            return Created(Request.RequestUri + model.Key, model);
        }

        // Endpoint for updating data by ID
        public IHttpActionResult PutData(string id, [FromBody] KeyValueModel model)
        {
            var redis = _redisConnection.GetDatabase();
            if (!redis.KeyExists(id))
                return NotFound();
            redis.StringSet(id, model.Value);
            return Ok(new { id, model.Value });
        }

        // Endpoint for deleting data by ID
        public IHttpActionResult DeleteData(string id)
        {
            var redis = _redisConnection.GetDatabase();
            if (!redis.KeyExists(id))
                return NotFound();
            redis.KeyDelete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _redisConnection.Dispose();
            }
            base.Dispose(disposing);
        }
    }

    public class KeyValueModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}

namespace RedisAPIExample1
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}