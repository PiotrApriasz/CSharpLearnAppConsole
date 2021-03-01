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
            
            XmlElement na5 = xd.CreateElement("LearnPaths");
            cl.AppendChild(na5);
            
            XmlElement na6 = xd.CreateElement("Notes");
            cl.AppendChild(na6);
            
            XmlElement na7 = xd.CreateElement("TODOs");
            cl.AppendChild(na7);

            xd?.DocumentElement?.AppendChild(cl);
            lfile.Close();
            xd.Save("/ProjektyC#/CSharpLearnPathConsole/CSharpLearnPathData.xml");

            return true;
        }
        
        /// <summary>
        /// Checks if in data base is the user with the same login as new user want
        /// </summary>
        /// <param name="login">Login which new user want to register</param>
        /// <returns></returns>
        public static bool IsLoginSameAsRegisteredBefore(string login)
        {
            var xdoc = new XmlDocument();
            var up = new FileStream("/ProjektyC#/CSharpLearnPathConsole/CSharpLearnPathData.xml", FileMode.Open);
            xdoc.Load(up);
            XmlNodeList list = xdoc.GetElementsByTagName("User");

            for (int i = 0; i < list.Count; i++) 
            {
                XmlElement cu = (XmlElement) xdoc.GetElementsByTagName("User")[i];

                if (cu?.GetAttribute("Login") == login)
                {
                    up.Close();
                    return true;
                }
            }

            up.Close();
            return false;
        }
    }
}