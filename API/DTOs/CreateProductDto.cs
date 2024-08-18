using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class CreateProductDto
    {
        [Required(ErrorMessage = "Thiếu tên sản phẩm")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Thiếu mô tả")]
        public string Description { get; set; } = string.Empty;
        [Range(1000, long.MaxValue, ErrorMessage = "Giá phải lớn hơn 0")]
        public long Price { get; set; }
        [Required(ErrorMessage = "Thiếu hình ảnh")]
        public string PictureUrl { get; set; } = string.Empty;
        [Required(ErrorMessage = "Thiếu loại sản phẩm")]
        public string Type { get; set; } = string.Empty;
        [Required(ErrorMessage = "Thiếu hãng sản phẩm")]
        public string Brand { get; set; } = string.Empty;
        [Range(0, int.MaxValue, ErrorMessage = "Số lượng sản phẩm trong kho phải lớn hơn hoặc bằng 0")]
        public int QuantityInStock { get; set; }
    }
}
