using System;

namespace IPv5.UI.Tools
{
    public class CustomTools
    {
        public static string SetCSSclass(DateTime currentDate)
        {
            if (currentDate < DateTime.Today.AddDays(-60)) // Overdue 
                return "_overdue";
            else if (currentDate > DateTime.Today.AddDays(-60) && (currentDate <= DateTime.Today)) // Due now
                return "_duenow";
            else if ((currentDate > DateTime.Today) && (currentDate < DateTime.Today.AddDays(60))) // Due next month
                return "_nextmonth";
            return "";
        }
    }

    public class UserSecurityTools
    {
        public UserSecurityTools()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static bool UserActive()
        {
            string userId = BaseClasses.Utils.SecurityControls.GetCurrentUserID();
            return IPv5.Business.UsersTable.GetRecord(userId, false).Active;
        }
        public static bool PasswordUpdateRequired()
        {
            string userId = BaseClasses.Utils.SecurityControls.GetCurrentUserID();
            return IPv5.Business.UsersTable.GetRecord(userId, false).PwdExp;
        }

    }

}