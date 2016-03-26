﻿using Microsoft.AspNet.Mvc;
using System.Threading.Tasks;

namespace React.Controllers.Status
{
    public class StatusController : BaseController
    {
        [Route("status/status/{statusCode}")]
        public async Task<IActionResult> Status(int statusCode)
        {
            return View($"js-/statuscode{statusCode}", await BuildState());
        }
    }
}