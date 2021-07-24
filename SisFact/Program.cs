using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SisFact
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        
        [STAThread]
        static void Main()
        {

            string DataBase_Name = "";
            string DataBase_User = "";
            string DataBase_Password = "";
            string DataBase_source = "";
            try
            {
                using (XmlReader reader = XmlReader.Create(@"C:\Windows\SoftCast.xml"))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            //return only when you have START tag  
                            switch (reader.Name.ToString())
                            {
                                case "Password":
                                    DataBase_Password = reader.ReadString();
                                    break;
                                case "User":
                                    DataBase_User = reader.ReadString();
                                    break;
                                case "DataBase":
                                    DataBase_Name = reader.ReadString();
                                    break;
                                case "Source":
                                    DataBase_source = reader.ReadString();
                                    break;
                            }
                        }
                    }
                }
                Acceso.CadenaConexion = "data source = " + DataBase_source + @"\SQLEXPRESS; initial catalog = " + DataBase_Name + "; user id = " + DataBase_User + "; password = " + DataBase_Password;

            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro el Archivo xml","Aviso...",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenuPrincipal());

        }
    }
}
