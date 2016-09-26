using LaceraParser;
using LaceraWebApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LaceraWebApp.Controllers.Api
{
    [RoutePrefix("api/employees")]
    public class EmployeesApiController : ApiController
    {
        [HttpGet, Route("")]
        public HttpResponseMessage Get()
         {
            try
            {
                EmployeeData empData = new EmployeeData();
                List<EmployeeRecord> invalidRecords;
                List<Employee> data = CsvParser.Parse(@"C:\Users\adolf\Desktop\LaceraTest.csv", out invalidRecords);


                empData.InvalidData = invalidRecords;
                empData.ValidData = data;
                
                return Request.CreateResponse(HttpStatusCode.OK , empData);
            }
            catch (UnauthorizedAccessException)
            {
                
                return Request.CreateResponse(HttpStatusCode.Forbidden);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

    }
}
