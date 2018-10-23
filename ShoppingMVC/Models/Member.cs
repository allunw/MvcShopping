using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace ShoppingMVC.Models
{
    [DisplayName("会员信息")]
    [DisplayColumn("Name")]
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("会员帐号")]
        [Required(ErrorMessage = "请输入 Email 地址")]
        [Description("我们直接以 Email 当成会员的登录帐号")]
        [MaxLength(250, ErrorMessage = "Email 地址长度无法超过250个字符")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("会员密码")]
        [Required(ErrorMessage = "请输入密码")]
        [MaxLength(40, ErrorMessage = "密码不得超过40个字符")]
        [Description("密码将以SHA1进行哈希运算，通过SHA1哈希运算后的结果转为HEX表示法的字符串长度皆为40个字符")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("中文姓名")]
        [Required(ErrorMessage = "请输入中文姓名")]
        [MaxLength(5, ErrorMessage = "中文姓名不可超过5个字")]
        [Description("暂不考虑有外国人用英文名注册的情况")]
        public string Name { get; set; }

        [DisplayName("网络昵称")]
        [Required(ErrorMessage = "请输入网络昵称")]
        [MaxLength(5, ErrorMessage = "网络昵称请勿输入超过10个字")]        
        public string NickName { get; set; }

        [DisplayName("会员注册时间")]        
        public DateTime RegisterOn { get; set; }

        [DisplayName("会员启用认证码")]
        [MaxLength(36)]
        [Description("当 AuthCode 等于 null 则代表此会员已经通过Email有效性验证")]
        public string AuthCode { get; set; }
    }
}
