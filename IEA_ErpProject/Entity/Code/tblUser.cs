using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject.Entity.Code
{
    [Table("tblUsers")]
    public class tblUser
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Ad"),StringLength(50,ErrorMessage = "{0} alanı maksimum {1} karakterlidir.")]
        [Required(ErrorMessage = "{0} alanı girilmesi zorunludur.")]
        public string Name { get; set; }

        [DisplayName("Şifre"), StringLength(maximumLength:10,MinimumLength = 5, ErrorMessage = "{0} alanı maksimum {1}minimum {2} karakter almalıdır.")]
        [Required(ErrorMessage = "{0} alanı girilmesi zorunludur.")]
        public string Password { get; set; }

        [DisplayName("Kullanıcı Adı"), StringLength(maximumLength: 10, MinimumLength = 5, ErrorMessage = "{0} alanı maksimum {1}minimum {2} karakter almalıdır.")]
        [Required(ErrorMessage = "{0} alanı girilmesi zorunludur.")]
        public string Username { get; set; }
    }
}
