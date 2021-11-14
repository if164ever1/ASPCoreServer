using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPCoreServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessangerController : ControllerBase
    {
        static List<Message> ListOfMessage = new List<Message>();
        // GET api/<MessangerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string OutputMessage = "Empty message!";

            if (id < ListOfMessage.Count && id >= 0)
            {
                OutputMessage = JsonConvert.SerializeObject(ListOfMessage[id]);
            }

            Console.WriteLine(String.Format("Message {0} : {1}", id, OutputMessage));

            return OutputMessage;
        }

        // POST api/<MessangerController>
        [HttpPost]
        public IActionResult SendMessage([FromBody] Message msg)
        {
            if (msg == null)
            {
                return BadRequest();
            }

            ListOfMessage.Add(msg);
            Console.WriteLine(String.Format("Count of message: {0} Current message is {1}", ListOfMessage.Count, msg.MessageText));

            return new OkResult();
        }

        // PUT api/<MessangerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MessangerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
