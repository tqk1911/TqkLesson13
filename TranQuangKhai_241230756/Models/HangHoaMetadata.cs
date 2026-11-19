using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
namespace TranQuangKhai_241230756.Models;
[ModelMetadataType(typeof(HangHoaMetadata))]
public partial class HangHoa { }
public class HangHoaMetadata
{
    [Required(ErrorMessage ="Vui lòng nhập tên hàng")]
    public string? TenHang { get; set; }
    [Required(ErrorMessage ="Vui lòng nhập giá")]
    [Range(100, 5000, ErrorMessage ="Gía phải là số trong khoảng 100 đến 5000")]
    public decimal? Gia { get; set; }
    [RegularExpression(@"(?i)^.+\.(jpg|png|gif|tiff)$", ErrorMessage ="Sai đuôi file ảnh")]
    public string? Anh { get; set; }
}

