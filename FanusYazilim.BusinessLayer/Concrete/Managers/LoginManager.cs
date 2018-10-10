using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FanusYazilim.BusinessLayer.Concrete.Mail;
using FanusYazilim.Entities;
using FanusYazilim.Entities.Hash_SHA1;

namespace FanusYazilim.BusinessLayer.Concrete.Managers
{
    public class LoginManager
    {
       private UserManager _manager = new UserManager();

        
       public bool LoginControl(User model)
       {
            User login = new User();
            login = _manager.Find(u => u.Email == model.Email);

            if(login != null)
                if(Sha.Encoder(model.Password) == login.Password)
                    return true;

            return false;
       }

       public bool EmailExits(string email)
        {
            if(_manager.Find(r => r.Email == email.ToLower()) != null)
            {
                User user = _manager.Find(r => r.Email == email.ToLower());
                string content = "Parolanızı değiştirmek için aşağıdaki linke tıklayınız.\r\n\r\n"+
                  "http://www.hikayecimatik.com/NewPassword/" + user.SecurityGuid.ToString();


                SendMail.MailSend(email, "Parola Değiştirme", content);

                return true;
            }

            return false;
        }

       public bool ChangePassword(string OldPassword , string password)
       {

            User u = _manager.Find(r => r.UserID == 1);
            if (Sha.Encoder(OldPassword) == u.Password)
            {
                u.Password = Sha.Encoder(password);
                int response = _manager.Update(u);

                if (response == 1)
                    return true;

                return false;
            }
        
            return false;
            
       }


       public bool NewPassGuidControl(string guid)
       {
            User _user = _manager.Find(u => u.SecurityGuid.ToString() == guid);

            if (_user != null)
            {
                _user.SecurityGuid = Guid.NewGuid();
                _manager.Update(_user);
                return true;
            }

            return false;

       }

        public bool ChangeNewPassword(string password)
        {
            User _user = _manager.Find(u => u.UserID == 1);

            if(_user != null)
            {
                _user.Password = Sha.Encoder(password);
                _manager.Update(_user);
                return true;
            }

            return false;
        }

    }
}
