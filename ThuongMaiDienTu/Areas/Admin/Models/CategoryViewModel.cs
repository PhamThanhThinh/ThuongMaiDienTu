namespace ThuongMaiDienTu.Areas.Admin.Models
{
  public class CategoryViewModel
  {
    // có dấu hỏi để không xử lý cath lệ cho trường hợp null
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public Guid? ParentId { get; set; }
  }
}
