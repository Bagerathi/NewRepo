using BLL_EMS;
using DAL_EMS;
using EMS_Full_Stack_App_Requirement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EMS_Full_Stack_App_Requirement.Controllers
{
    [RoutePrefix("DEPT")]
    public class DeptController : ApiController
    {
        Dept_Helper helper = null;
        public DeptController()
        {
            helper = new Dept_Helper();
        }
        // GET api/<controller>
        [Route("GetDeptDetails")]
        public List<DeptModel> GetDeptLsit()
        {
            List<DeptModel> list = new List<DeptModel>();

            List<DeptMaster> dlist = helper.ShowDeptList();
            foreach (var item in dlist)
            {
                list.Add(new DeptModel { DeptCode = item.DeptCode, DeptName = item.DeptName });
                
            }
            return list;
        }

        // GET api/<controller>/5
        [Route("GetDeptById/{id}")]
        public DeptModel GetDeptById(int id)
        {
            DeptMaster dep = helper.FindDept(id);
            DeptModel dept = new DeptModel();
            dept.DeptCode = dep.DeptCode;
            dept.DeptName = dep.DeptName;
            return dept;
        }

        // POST api/<controller>
        [Route("AddDept")]
        public HttpResponseMessage PostDept([FromBody] DeptModel dep)
        {
            DeptMaster dept = new DeptMaster();
            dept.DeptCode = dep.DeptCode;
            dept.DeptName= dep.DeptName;
            bool ans = helper.AddDept(dept);
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
        [Route("UpdateDept/{id}")]
        public HttpResponseMessage PutDept(int id, [FromBody] DeptModel dep)
        {
            DeptMaster dept = new DeptMaster();
            dept.DeptCode = dep.DeptCode;
            dept.DeptName = dep.DeptName;
            bool ans=helper.UpdateDept(id, dept);
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
        [Route("DeleteDept/{id}")]
        public HttpResponseMessage DeleteDept(int id)
        {
            bool ans=helper.DeleteDept(id);
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