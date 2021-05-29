using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_3.Models
{
    public class person
    {
        /// <summary>
        /// 证件id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 姓
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// 名
        /// </summary>
        public string LastName { get; set; }
    }
}