using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhamSiDuc_deThiMau2023.Models;

public partial class HangHoa
{
    public int MaHang { get; set; }

    public int MaLoai { get; set; }

    [Required(ErrorMessage = "Tên hàng không được để trống")]
    public string TenHang { get; set; } = null!;

    [Required(ErrorMessage = "Vui lòng nhập giá")]
    [Range(100, 5000, ErrorMessage = "Giá phải là số và nằm trong giới hạn 100 đến 5000")]
    public decimal? Gia { get; set; }

    [Required(ErrorMessage = "Vui lòng nhập tên ảnh")]
    [RegularExpression(@".*\.(jpg|png|gif|tiff)$", ErrorMessage = "Tên file ảnh phải có đuôi: .jpg | .png | .gif | .tiff")]
    public string? Anh { get; set; }

    public virtual LoaiHang? MaLoaiNavigation { get; set; }
}
