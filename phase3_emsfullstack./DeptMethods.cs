using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.EntitySql;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL_EMS
{
    public class DeptMethods
    {
        MyContext context = null;
        public DeptMethods()
        {
            context= new MyContext();
        }
        public bool AddDepts(DeptMaster d)
        {
            try
            {             
                context.DeptMasters.Add(d);
                context.SaveChanges();
                return true;    
                
            }
            catch (Exception )
            {

                return false;
            }
        }
        public bool UpdateDept(int id,DeptMaster d)
        {
            try
            {
                List<DeptMaster> list = context.DeptMasters.ToList();
                DeptMaster found= list.Find(x => x.DeptCode == id);
                found.DeptCode=d.DeptCode;
                found.DeptName=d.DeptName;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public DeptMaster FindDept(int id)
        {
            try
            {
                List<DeptMaster> list = context.DeptMasters.ToList();
                DeptMaster found = list.Find(x => x.DeptCode == id);
                return found;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool RemoveDept(int id)
        {
            try
            {
                List<DeptMaster> list = context.DeptMasters.ToList();
                DeptMaster found = list.Find(x => x.DeptCode == id);
                context.DeptMasters.Remove(found);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public List<DeptMaster> GetDeptMasters()
        {
            List<DeptMaster> list = context.DeptMasters.ToList();
            return list;
        }
    }
}
