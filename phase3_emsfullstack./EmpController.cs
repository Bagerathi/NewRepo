using BLL_EMS;
using DAL_EMS;
using EMS_Full_Stack_App_Requirement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EMS_Full_Stack_App_Requirement.Controllers
{
    [RoutePrefix("EMP")]
    public class EmpController : ApiController
    {
        EMP_Helper helper = null;
        public EmpController()
        {
            helper = new EMP_Helper();
        }
        // GET api/<controller>
        [Route("GetEmployeeDetails")]
        public List<EmpModel> GetEmpDetails()
        {
            List<EmpModel> empDetails = new List<EmpModel>();
            List<EmpProfile> list = helper.Employeelist();
            foreach (var item in list)
            {
                empDetails.Add(new EmpModel { EmpCode = item.EmpCode, EmpName = item.EmpName, DateOfBirth = item.DateOfBirth, Email = item.Email, DeptCode = item.DeptCode });
            }
            return empDetails;
        }

        // GET api/<controller>/5
        [Route("GetEmpByID/{id}")]
        public EmpModel GetEmpById(int id)
        {
            
            EmpProfile emp1 = helper.LocateEmp(id);
            EmpModel emp = new EmpModel();
            emp.EmpCode = emp1.EmpCode;
            emp.EmpName = emp1.EmpName;
            emp.DateOfBirth = emp1.DateOfBirth;
            emp.Email = emp1.Email;
            emp.DeptCode = emp1.DeptCode;
            return emp;
        }

        // POST api/<controller>
        [Route("AddEmployee")]
        public HttpResponseMessage PostEmployee([FromBody] EmpModel emp)
        {
            EmpProfile emp1 = new EmpProfile();
            emp1.EmpCode = emp.EmpCode;
            emp1.EmpName = emp.EmpName;
            emp1.DateOfBirth = emp.DateOfBirth;
            emp1.Email=emp.Email;
            emp1.DeptCode = emp.DeptCode;
            bool ans=helper.AddEmployee(emp1);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);

            }
        }

        // PUT api/<controller>/5
        [Route("UpdateEmployee/{id}")]
        public HttpResponseMessage PutEmployee(int id, [FromBody] EmpModel emp1)
        {
            EmpProfile emp = new EmpProfile();
            emp.EmpCode = emp1.EmpCode;
            emp.EmpName = emp1.EmpName;
            emp.DateOfBirth = emp1.DateOfBirth;
            emp.Email = emp1.Email;
            emp.DeptCode = emp1.DeptCode;
            bool ans = helper.UpdateEmployee(id,emp);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);

            }
        }

        // DELETE api/<controller>/5
        [Route("DeleteEmployee/{id}")]
        public HttpResponseMessage DeleteEmployee(int id)
        {
            bool ans = helper.DeleteEmp(id);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);

            }
        }
    }
}