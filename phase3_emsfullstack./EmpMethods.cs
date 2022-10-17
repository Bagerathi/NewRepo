
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_EMS
{
    public class EmpMethods
    {
        MyContext context = null;
        public EmpMethods()
        {
            context = new MyContext();
        }
        public bool AddEmployee(EmpProfile emp)
        {
            try
            {
                context.EmpProfiles.Add(emp);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateEmployee(int id, EmpProfile emp)
        {
            try
            {
                List<EmpProfile> list = context.EmpProfiles.ToList();
                EmpProfile found = list.Find(s1 => s1.EmpCode == id);
                found.DeptCode = emp.DeptCode;
                found.EmpCode = emp.EmpCode;
                found.EmpName = emp.EmpName;
                found.DateOfBirth = emp.DateOfBirth;
                found.Email = emp.Email;

                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public EmpProfile FindEmployee(int id)
        {
            try
            {
                List<EmpProfile> list = context.EmpProfiles.ToList();
                EmpProfile found = list.Find(s1 => s1.EmpCode == id);
                return found;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           

        }
        public bool Removeemployee(int id)
        {
            try
            {
                List<EmpProfile> list = context.EmpProfiles.ToList();
                EmpProfile found = list.Find(s1 => s1.EmpCode == id);
                context.EmpProfiles.Remove(found);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
         
        public List<EmpProfile> GetEmpProfiles()
        {
            List<EmpProfile> list = context.EmpProfiles.ToList();
            return list;
        }
    }
}
