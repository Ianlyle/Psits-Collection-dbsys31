using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.AppData;

namespace Final_Project
{
    public class UserRepository
    {
        private DB_PsitsModel db;
        public UserRepository()
        {
            db = new DB_PsitsModel();
        }

        //private       
        public enum ErrorCode
        {
            Error,
            Success
        }
        public ErrorCode Signup(String username, String password)
        {
            try
            {
                using (var db = new DB_PsitsModel())
                {
                    var newUser = new USERACCOUNT();
                    newUser.username = username;
                    newUser.userpassword = password;

                    db.USERACCOUNTs.Add(newUser);
                    db.SaveChanges();
                    
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
                return ErrorCode.Error;
            }
        }

        public USERACCOUNT GetUserByUsername(String username)
        {
            // re-initialize db object because sometimes data in the list not updated
            using (db = new DB_PsitsModel())
            {
                // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
                return db.USERACCOUNTs.Where(s => s.username == username).FirstOrDefault();
            }
        }
        //public ErrorCode UpdateUser(int? userId, Event aUserAccount, ref String outMessage)
        //{
        //    ErrorCode retValue = ErrorCode.Error;
        //    try
        //    {
        //        // Find the user with id
        //        UserAccount user = db.UserAccounts.Where(m => m.UserId == userId).FirstOrDefault();

        //        if (user != null)
        //        {
        //            // Update the value of the retrieved user
        //            user.Username = aUserAccount.Username;
        //            user.Password = aUserAccount.Password;
        //            user.ContactInfo = aUserAccount.ContactInfo;
        //            user.FirstName = aUserAccount.FirstName;
        //            user.LastName = aUserAccount.LastName;
        //            user.RoleID = aUserAccount.RoleID;

        //            db.SaveChanges(); // Execute the update

        //            outMessage = "Updated";
        //            retValue = ErrorCode.Success;
        //        }
        //        else
        //        {
        //            outMessage = "User not found";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        outMessage = ex.Message;
        //        MessageBox.Show(ex.Message);
        //    }
        //    return retValue;
        //}



        public ErrorCode RemoveUser(int? EventId, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                Event e = db.Events.Where(m => m.EventID == EventId).FirstOrDefault();
                // Remove the user
                db.Events.Remove(e);
                db.SaveChanges();       // Execute the update

                outMessage = "Deleted";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                retValue = ErrorCode.Error;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

        //public List<UserAccount> UserAccounts()
        //{
        //    using (db = new UserRegisEntities())
        //    {
        //        return db.UserAccount.ToList();
        //    }
        //}

        //public List<vw_all_user_role> AllUserRole()
        //{
        //    using (db = new UserRegisEntities())
        //    {
        //        return db.vw_all_user_role.ToList();
        //    }
        //}

        //public List<Events> ShowEvents()
        //{
        //    using (db = new UserRegisEntities())
        //    {
        //        return db.Events.ToList();
        //    }
        //}

        //public List<Misc> ShowMisc()
        //{
        //    using (db = new UserRegisEntities())
        //    {
        //        return db.Misc.ToList();
        //    }
        //}


    }
}