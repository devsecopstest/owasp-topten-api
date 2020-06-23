using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using owasp_topten_api.Entities;
using owasp_topten_api.Services;

namespace owasp_topten_api.Controllers.MIMETypeValidation
{
    [ApiController]
    [Route("img/[controller]")]
    public class InsImageUploader : ControllerBase
    {

        private IAppServices appServices;

        public InsImageUploader(IAppServices appServ)
        {
            appServices = appServ;
        }

        [HttpPost]
        public ActionResult CreateAccount([FromBody]Account newAccount) {

            appServices.CreateAccount(newAccount);
            return Ok();
        }
    }
}