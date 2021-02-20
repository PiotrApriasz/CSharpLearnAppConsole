using System;
using System.IO;
using System.Xml;
using ApplicationCore;

namespace DataAccess
{
    public static class RegisterService
    {
        /// <summary>
        /// Saves user data in xml database in sign up process
        /// </summary>
        /// <param name="user">User object with all informations needed to perform sign up</param>
        /// <returns></returns>
        public static bool SignUp(User user)
        {
            var xd = new XmlDocument();
            FileStream lfile = new FileStream("/ProjektyC#/CSharpLearnPathConsole/CSharpLearnPathData.xml", FileMode.Open);
            xd.Load(lfile);
            XmlElement cl = xd.CreateElement("User");
            
            cl.SetAttribute("Login", user.Username);
            XmlElement na1 = xd.CreateElement("Password");
            XmlText na1Text = xd.CreateTextNode(user.Password);
            na1.AppendChild(na1Text);
            cl.AppendChild(na1);
            
            XmlElement na2 = xd.CreateElement("Name");
            XmlText na2Text = xd.CreateTextNode(user.Name);
            na2.AppendChild(na2Text);
            cl.AppendChild(na2);
            
            XmlElement na3 = xd.CreateElement("LastName");
            XmlText na3Text = xd.CreateTextNode(user.LastName);
            na3.AppendChild(na3Text);
            cl.AppendChild(na3);
            
            XmlElement na4 = xd.CreateElement("Email");
            XmlText na4Text = xd.CreateTextNode(user.Email);
            na4.AppendChild(na4Text);
            cl.AppendChild(na4);

            xd?.DocumentElement?.AppendChild(cl);
            lfile.Close();
            xd.Save("/ProjektyC#/CSharpLearnPathConsole/CSharpLearnPathData.xml");

            return true;
        }
    }
}