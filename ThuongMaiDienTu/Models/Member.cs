﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ThuongMaiDienTu.Interfaces;

namespace ThuongMaiDienTu.Models
{
  [Table("Member")]
  public class Member : IAuditable
  {
    [Key]
    public Guid Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }
    [MaxLength(50)]
    public string? Picture { get; set; }
    [MaxLength(100)]
    public string? LoginName { get; set; }
    [MaxLength(100)]
    public string? Password { get; set; }
    [MaxLength(100)]
    public string? Email { get; set; }
    public DateTime? LastLogin { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTime? CreatedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    [ForeignKey("GroupId")]
    public Guid? GroupId { get; set; }
    public Group? Group { get; set; }
  }
}
