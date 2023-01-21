using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LockServices.Repository
{
    public class ProdCust
    {
        public static string GetProdCustByDeviceId(string deviceId,string cstCode,string prdId)
        {
            using (var context = new RaadeenSiteEntities())
            {
                var contractList = context.PROD_CUST.Where(t => t.DEVICE_ID == deviceId && t.CST_CODE == cstCode && t.PRD_ID == prdId).ToList();
                if(contractList.Count != 1)
                {
                    return "False";
                }
                else
                {
                    var customerName = context.CUSTOMERs.Where(t => t.CST_CODE == cstCode).FirstOrDefault().DESC1;
                    var ValidDate = contractList.FirstOrDefault().VALID_DATE;
                    var result = customerName + "|" + ValidDate;
                    return result;
                }
                
            }
        }
    }
}