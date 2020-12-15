using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExperimentFive.Controllers
{
    public class AboutController : Controller
    {
        [Route("About")]
        public IActionResult Index() => View();

        [HttpGet("GetString")]
        public string GetData() => "42";   

        [HttpGet("AddAndReturn")]   
        public int AddAndReturn(
            [FromQuery] int number1, int number2
        )  => number1 + number2;

        [HttpGet("GetBoolean")]
        public bool GetBoolean() => true;

        [HttpGet("GetJsonObject")]
        public string GetJsonObject()
        {
            var cat = new cat();

            cat.color = "black";
            cat.gender = "male";
            cat.name = "skitter";

            return JsonConvert.SerializeObject(cat);
        }

        [HttpGet("GetJsonObjectVariables")]
        public string GetJsonObjectVariables(
            [FromQuery] string color, string gender, string name
        )
        {
            Console.WriteLine(color, gender, name);
            var cat = new cat();
            cat.color = color;
            cat.gender = gender;
            cat.name = name;
            
            return JsonConvert.SerializeObject(cat);
        }
    }

    public class cat : ICat
    {
        public string color { get; set; }
        public string gender { get; set; }
        public string name { get; set; }
    }
}

public interface ICat
{
    string color  {get; set;}
    string gender {get; set;}
    string name   {get; set;}
}