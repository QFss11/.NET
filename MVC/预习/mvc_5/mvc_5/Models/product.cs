using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc_5.Models
{
    public partial class product
    {
        public int productid { get; set; }
        [Display(Name="年龄")]
        [Required(ErrorMessage ="商品标题不能为空！")]
        [StringLength(50,ErrorMessage ="商品标题过长")]
        public string title { get; set; }
        public Nullable<int> cateid { get; set; }
        [Required(ErrorMessage ="标记价格不能为空！")]
        [Range(typeof(decimal),"10.00","999.00",ErrorMessage ="标记价格超出了范围")]
        public Nullable<decimal> marketprice { get; set; }
        public Nullable<decimal> localprice { get; set; }
        public string content { get; set; }
        public string posttime { get; set; }
       [Required(ErrorMessage ="商品数量不能为空")]
       [Range(1,100,ErrorMessage ="数量在1-100之间")]
        public Nullable<int> cnt { get; set; }
        public string imageid { get; set; }
      
    }
}