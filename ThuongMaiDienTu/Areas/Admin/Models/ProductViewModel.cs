namespace ThuongMaiDienTu.Areas.Admin.Models
{
  public class ProductViewModel
  {
    public Guid? Id { get; set; }
    public string? Title { get; set; }
    public string? Intro { get; set; }
    public string? Content { get; set; }
    public string? Picture { get; set; }
    public string? Price { get; set; }
    public Guid? Category { get; set; }
  }
}
