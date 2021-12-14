using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne.Models;
using AllForOne.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerService data;
        public RestaurantPickerController(RestaurantPickerService dataFromService)
        {
            data = dataFromService;
        }

        [HttpPost]
        public string RestaurantPicker(){
            return data.RandomRestaurantPicker();
        }

        [HttpPost("selection")]

        public string RandomFastFood(RestaurantPickerModel userinput){

            string selection = "";

            if(userinput.category?.ToLower() == "Fine Dining".ToLower())
            {
               selection = data.RandomFineDining();
            }
            else{
                selection = data.RandomFastFood();
            }
            return selection;
            }
        }

    


    }
