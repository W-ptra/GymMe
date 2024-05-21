using backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backend.Repository
{
    public class UserRepository
    {
        public static void createNewMsUser(MsUser newUser)
        {
            GymMeSQLDatabaseEntities1 db = DBInstance.getInstance();
            db.MsUsers.Add(newUser);
            db.SaveChanges();
        }

        public static List<MsUser> getAllMsUser()
        {
            GymMeSQLDatabaseEntities1 db = DBInstance.getInstance();
            return db.MsUsers.ToList();
        }

        public static MsUser getMsUser(String username)
        {
            GymMeSQLDatabaseEntities1 db = DBInstance.getInstance();
            return db.MsUsers.Where((u)=> u.UserName == username).ToList().FirstOrDefault();
        }

        
        public static void updateMsUser(String username,String email,DateTime DOB,String gender, String role)
        {
            GymMeSQLDatabaseEntities1 db = DBInstance.getInstance();
            MsUser currentMsUser = getMsUser(username);
            currentMsUser.UserName = username;
            currentMsUser.UserEmail = email;
            currentMsUser.UserDOB = DOB;
            currentMsUser.UserGender = gender;
            currentMsUser.UserRole = role;
            db.SaveChanges();
        }

        public static void updateMsUserPassword(String username,String newPassword)
        {
            GymMeSQLDatabaseEntities1 db = DBInstance.getInstance();
            MsUser currentUser = getMsUser(username);
            currentUser.Password = newPassword;
            db.SaveChanges();
        }
    }
}