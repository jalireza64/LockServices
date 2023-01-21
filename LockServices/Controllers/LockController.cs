using LockServices.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LockServices.Helper;

namespace LockServices.Controllers
{
    public class LockController : ApiController
    {
        [HttpGet]
        public string ValidateDeviceId(string deviceId,string cstCode,string prdId)
        {
            return Lock.ValidateDeviceId(deviceId, cstCode, prdId);
        }
    }
}
