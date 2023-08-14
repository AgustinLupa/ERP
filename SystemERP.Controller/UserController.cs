using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Data;
using SystemERP.Model;
using SystemERP.Utils;

namespace SystemERP.Controller
{
    public class UserController
    {
        UserData _userData = new UserData();
        User? activeUser;

        public bool Login(string name, string pass)
        {
            if (name == "" || name == null)
            {
                return false;
            }

            if(pass == "" ||  pass == null)
            {
                return false;
            }

            User user = new User()
            {
                Name= name,
                Password= KeySha256.CalculateSHA256(pass)
            };

            activeUser = _userData.Login(user);

            if (activeUser != null)
            {
                return true;
            }
            return false;
            
        }

        public bool CompareKey(string key)
        {
            if (key == "" || key == null)
            {
                return false;
            }
            string pass = KeySha256.CalculateSHA256(key);
            if (pass == activeUser.Password)
            {
                return true;
            }            
            return false;            
        }
 
        public User GetUserActive() {
            return activeUser;
        }
        
        public void SetRoleActive(Role role)
        {
            activeUser.Role = role;
        }

        public bool CreateUser(string name, string pass)
        {
            if (name == "" || name == null)
            {
                return false;
            }

            if (pass == "" || pass == null)
            {
                return false;
            }

            User user = new User()
            {
                Name = name,
                Password = KeySha256.CalculateSHA256(pass)
            };
            return _userData.Create(user);
        }
    }
}
