using System;

namespace IPv5.UI.Tools
{
    public class CustomTools
    {
        public CustomTools()
        {

        }
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

        public static string GetAppSetting(string setting)
        {
            try
            {
                return System.Web.Configuration.WebConfigurationManager.AppSettings[setting];
            }
            catch
            {
                return "";
            }
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

        public static string PasswordUpdateRedirect()
        {
            string encryptFrom = BaseClasses.Utils.SecurityControls.GetCurrentUserID();
            string encryptTo = Data.BaseFormulaUtils.Encrypt(encryptFrom as string);
            string url = @"../Users/EditUsers1.aspx?Users=" + encryptTo;

            return url;
        }

    }

    public class RecoverPasswordTools
    {
        public RecoverPasswordTools()
        {

        }

        public static void CreateRecoverPasswordMessage(SendGrid.SendGridMessage myMessage, string subject, BaseClasses.IUserIdentityRecord userRecord)
        {
            myMessage.Subject = subject;
            System.Text.StringBuilder _sb = new System.Text.StringBuilder();
            string _text;
            _text = string.Format("Password recovery for {0} ({1})", userRecord.GetUserName(), userRecord.GetUserEmail());
            _sb.Append(_text + "\n");
            _text = string.Format("     Username : {0}", userRecord.GetUserName());
            _sb.Append(_text + "\n");
            _text = string.Format("     Password : {0}", userRecord.GetUserPassword());
            _sb.Append(_text + "\n");

            myMessage.Text = _sb.ToString();
        }



    }

}