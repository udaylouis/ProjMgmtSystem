using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.DataEntity
{
    public class UserRoles
    {
        private readonly ArrayList _roles;
        
        public UserRoles(string member, string role)
        {
            Username = member;
            _roles = new ArrayList { role };
            _roles.TrimToSize();
        }
       
        public void AddRole(string role)
        {
            if (!_roles.Contains(role))
            {
                _roles.Add(role);
            }
        }
    
        public bool HasRole(string role)
        {
            return _roles.Contains(role);
        }
       
        public string Username { get; private set; }
     
        public string RoleString
        {
            get
            {
                var tmpstr = _roles.Cast<string>().Aggregate("", (current, rs) => current + (rs + ", "));
                return tmpstr.Remove(tmpstr.Length - 2, 2);
            }
        }

        public IList Roles
        {
            get { return _roles; }
        }
    }
}
