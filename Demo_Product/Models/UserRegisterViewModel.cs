using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen isim değerini giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyisim değerini giriniz")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen kullanıcı adı değerini giriniz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen mail değerini giriniz")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen şifre değerini giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("Password", ErrorMessage = "Lütfen şifrelerin eşleştiğinden emin olun")]
        public string ConfirmPassword { get; set; }
    }
}
