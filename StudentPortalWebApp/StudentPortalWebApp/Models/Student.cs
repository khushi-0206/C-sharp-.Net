using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentPortalWebApp.Models;

public partial class Student
{
    public int StudentId { get; set; }

    [Required(ErrorMessage = "Full name is required")]
    [StringLength(50, MinimumLength = 2,
        ErrorMessage = "Name must be between 2 and 50 characters")]
    public string FullName { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string Email { get; set; } = null!;
    [Required(ErrorMessage = "Phone number is required")]
    [RegularExpression(@"^[0-9]{10}$",
        ErrorMessage = "Phone number must be exactly 10 digits")]
    public string? Phone { get; set; }
    [Required(ErrorMessage = "Status is required")]
    public string Status { get; set; } = null!;
    [Required(ErrorMessage = "Join date is required")]
    [DataType(DataType.Date)]
    public DateOnly JoinDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual ICollection<TblLog> TblLogs { get; set; } = new List<TblLog>();
}
