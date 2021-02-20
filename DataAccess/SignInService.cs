﻿using System.IO;
using System.Xml;

namespace DataAccess
{
    public static class SignInService
    {
        /// <summary>
        /// Checks if in data base is login which user want to sign in by
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static bool FindUsername(string username)
        {
            var xdoc = new XmlDocument();
            var up = new FileStream("/ProjektyC#/CSharpLearnPathConsole/CSharpLearnPathData.xml", FileMode.Open);
            xdoc.Load(up);
            XmlNodeList list = xdoc.GetElementsByTagName("User");

            for (int i = 0; i < list.Count; i++) 
            {
                XmlElement cu = (XmlElement) xdoc.GetElementsByTagName("User")[i];

                if (cu?.GetAttribute("Login") == username)
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