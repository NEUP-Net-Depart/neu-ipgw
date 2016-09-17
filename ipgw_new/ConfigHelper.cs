using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace ipgw_new
{
    /// <summary>
    /// 读取或保存配置
    /// </summary>
    class ConfigHelper
    {
        private string appdata;
        public ConfigHelper()
        {
            this.appdata = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            this.CreateDirectory();
        }
        private void CreateDirectory()
        {
            if (!Directory.Exists(appdata + "/2645"))//如果不存在就创建2645文件夹
            {
                Directory.CreateDirectory(appdata + "/2645");
            }
            if (!Directory.Exists(appdata + "/2645/ipgw_new"))//如果不存在就创建ipgw_new文件夹
            {
                Directory.CreateDirectory(appdata + "/2645/ipgw_new");
            }
        }
        public bool Check()
        {
            return File.Exists(appdata + "/2645/ipgw_new/ipgw.config");
        }
        public bool SaveConfig(ipgwConfig myconfig)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.CreateXmlDeclaration("1.0", "utf-8", null);
            XmlElement root = xmldoc.CreateElement("ipgw");
            XmlElement node = xmldoc.CreateElement("uid");
            node.InnerText = myconfig.uid;
            root.AppendChild(node);
            node = xmldoc.CreateElement("pwd");
            node.InnerText = myconfig.pwd;
            root.AppendChild(node);
            node = xmldoc.CreateElement("linkOnStart");
            node.InnerText = myconfig.linkOnStart;
            root.AppendChild(node);
            node = xmldoc.CreateElement("minOnStart");
            node.InnerText = myconfig.minOnStart;
            root.AppendChild(node);
            node = xmldoc.CreateElement("onClosing");
            node.InnerText = myconfig.onClosing;
            root.AppendChild(node);

            xmldoc.AppendChild(root);
            try
            {
                xmldoc.Save(appdata + "/2645/ipgw_new/ipgw.config");
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
        public ipgwConfig LoadConfig()
        {
            XmlDocument xmldoc = new XmlDocument();
            ipgwConfig myconfig = new ipgwConfig();
            xmldoc.Load(appdata + "/2645/ipgw_new/ipgw.config");
            XmlNode root = xmldoc.SelectSingleNode(xmldoc.DocumentElement.Name);
            myconfig.uid = root.SelectSingleNode("uid").InnerText;
            myconfig.pwd = root.SelectSingleNode("pwd").InnerText;
            myconfig.linkOnStart = root.SelectSingleNode("linkOnStart").InnerText;
            myconfig.minOnStart = root.SelectSingleNode("minOnStart").InnerText;
            myconfig.onClosing = root.SelectSingleNode("onClosing").InnerText;
            return myconfig;
        }
    }
}
