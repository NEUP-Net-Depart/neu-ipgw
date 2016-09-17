using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipgw_new
{
    /// <summary>
    /// 配置类
    /// </summary>
    public class ipgwConfig
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string uid { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string pwd { get; set; }
        /// <summary>
        /// 启动时连接，true或false
        /// </summary>
        public string linkOnStart { get; set; }
        /// <summary>
        /// 启动时最小化至托盘，true或false
        /// </summary>
        public string minOnStart { get; set; }
        /// <summary>
        /// 关闭按钮的动作，none,exit或minimum
        /// </summary>
        public string onClosing { get; set; }
        /// <summary>
        /// 空构造
        /// </summary>
        public ipgwConfig()
        {
            this.onClosing = "none";
        }
    }
}
