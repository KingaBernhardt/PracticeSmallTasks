using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeesSQL_WEB_API.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Employees.ToList();
            }
        }

        public Employee Get(int id)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.ID == id);
            }
        }
        
        public HttpResponseMessage Post([FromBody] Employee employee)
        {
            using(EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                entities.Employees.Add(employee);
                entities.SaveChanges();
                var message = Request.CreateResponse(HttpStatusCode.Created, employee);
            }
        }
    }
}
