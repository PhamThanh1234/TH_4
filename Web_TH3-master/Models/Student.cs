using System.ComponentModel.DataAnnotations;

namespace Web_ThucHanh1.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên
        [Required(ErrorMessage = "Hãy nhập tên.")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Tên phải có ít nhất 4 và tối đa 100 ký tự.")]
        public string? Name { get; set; } //Họ tên
        [Required(ErrorMessage = "Hãy nhập email!")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@gmail\.com", ErrorMessage = "Email phải có đuôi gmail.com.")]
        public string? Email { get; set; } //Email
        [Required(ErrorMessage = "Hãy nhập mật khẩu.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số và ký tự đặc biệt.")]
        public string? Password { get; set; }//Mật khẩu
        [Required(ErrorMessage = "Hãy chọn chi nhánh.")]
        public Branch? Branch { get; set; }//Ngành học
        [Required(ErrorMessage = "Hãy chọn giới tính.")]
        public Gender? Gender { get; set; }//Giới tính
        public bool IsRegular { get; set; }//Hệ: true-chính quy, false-phi chính quy
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Hãy nhập địa chỉ.")]
        public string? Address { get; set; }//Địa chỉ
        // [Range(typeof(DateTime), "1/1/1963", "31/12/2005", ErrorMessage = "Ngày sinh phải nằm trong khoảng từ 1/1/1963 đến 31/12/2005.")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Hãy nhập ngày sinh.")]
        public DateTime DateOfBorth { get; set; }//Ngày sinh
        [Required(ErrorMessage = "Bạn chưa nhập Score")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0.")]
        public float Score { get; set; }
        public string? AvatarUrl { get; set; }
    }
}
