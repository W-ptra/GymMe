using backend.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace frontend.Controller
{
    public class ProfileController
    {
        public static String updateProfileValidation(String idStr,String username,String email,String DOB, String gender,String role )
        {
            if (username == "" || email == "" || DOB == "" || gender == "")
            {
                return "Input can't empty";
            }

            if (username.Length < 5 || username.Length > 15)
            {
                return "username length must between 5 and 15";
            }

            if (!email.EndsWith(".com"))
            {
                return "Email must be ended with '.com'";
            }

            if (gender != "female" && gender != "male")
            {
                return "gender must be choose either male/female";
            }

            DateTime userDOB = DateTime.Parse(DOB);
            int id = int.Parse(idStr);
            localhost.GymMeWebService service = new localhost.GymMeWebService();
            String result = json<String>.decode(service.updateUserProfile(id, username, email, userDOB, gender, role));
            return result;
        }

        public static Boolean updateNewPassword(String username, String oldPassword,String newPassword)
        {
            localhost.GymMeWebService service = new localhost.GymMeWebService();
            Boolean isSuccessfull = json<Boolean>.decode(service.changeUserPassword(username, oldPassword, newPassword));
            if (!isSuccessfull)
            {
                return false;
            }
            return true;
        }
    }
}