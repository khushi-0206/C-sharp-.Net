using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FirstWebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        public static List<String> cityList = null;
        public CitiesController()
        {
            if (cityList == null)
            {
                cityList = new List<String>() 
                { 
                    "Delhi", 
                    "Pune", 
                    "Mumbai", 
                    "Chennai", 
                    "Hyderabaad" 
                };
            }
        }
        [Route("JoiningCities")] //localhost:portnumber/api/cities/JoiningCities
        [Route("/CgLocations")] //localhost:portnumber/cglocations
        [HttpGet]
        public List<String> ShowAllCities()
        {
            return cityList;
        }
        [Route("GetCityList/{stateName}")]
        [HttpGet]
        public List<String> GetCityList(string stateName)
        {
            return cityList;
        }
        [Route("FetchAllCities/{stateId}")]
        [HttpGet]
        public List<String> FetchAllCities(int stateId)
        {
            return cityList;
        }
        [HttpPost]
        public int AddMe(int num1,int num2)
        {
            return num1 + num2;
        }
    }
}
