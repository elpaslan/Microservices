using System;
using System.Collections.Generic;
using System.Text;
using FreeCourse.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;


namespace FreeCourse.Shared.ControllerBase
{
    public class CustomControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public IActionResult CreateActionResultInstance<T>(Response<T> response)
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
