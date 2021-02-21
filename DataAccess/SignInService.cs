using System.IO;
using System.Xml;
using ApplicationCore;

namespace DataAccess
{
    public static class SignInService
    {
        /// <summary>
        /// Checks if in data base is login and password which user want to sign in by
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static User FindUser(string username, string password)
        {
            User user;
            
            var xdoc = new XmlDocument();
            var up = new FileStream("/ProjektyC#/CSharpLearnPathConsole/CSharpLearnPathData.xml", FileMode.Open);
            xdoc.Load(up);
            XmlNodeList list = xdoc.GetElementsByTagName("User");

            for (int i = 0; i < list.Count; i++) 
            {
                XmlElement cu = (XmlElement) xdoc.GetElementsByTagName("User")[i];

                if (cu?.GetAttribute("Login") == username)
                {
                    XmlElement pass = (XmlElement) xdoc.GetElementsByTagName("Password")[i];
                    if (pass?.InnerText == password)
                    {
                        user = new User();
                        user.Username = username;
                        user.Password = password;
                        
                        XmlElement name = (XmlElement) xdoc.GetElementsByTagName("Name")[i];
                        user.Name = name?.InnerText;
                        
                        XmlElement lastName = (XmlElement) xdoc.GetElementsByTagName("LastName")[i];
                        user.LastName = lastName?.InnerText;
                        
                        XmlElement email = (XmlElement) xdoc.GetElementsByTagName("Email")[i];
                        user.Email = email?.InnerText;
                        
                        up.Close();
                        return user;
                    }
                }
            }

            up.Close();
            return null;
        }
    }
}