using LockServices.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LockServices.Helper
{
    public class Lock
    {
        public static string ValidateDeviceId(string deviceId,string cstCode,string prdId)
        {
            var prodCust = ProdCust.GetProdCustByDeviceId(deviceId, cstCode, prdId);
            return prodCust;
        }
    }
}