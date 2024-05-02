using DataLayer;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Utils;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace KHACHSAN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string connoi;
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            if (!File.Exists("connectdb.dba"))
            {
                Application.Run(new frmKetNoiDB());
            }
            else
            {
                if (File.Exists("sysparam.ini"))
                {
                    Application.Run(new frmLogin());
                }
                else
                {
                    Application.Run(new frmSetParam());
                }
            }
           
            


        }
        }
    
}
