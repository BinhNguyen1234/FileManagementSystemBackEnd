using System;
using System.Collections.Generic;

namespace FileManagementSystemBE.Model;

public partial class TblUser
{
    public Guid Id { get; set; }

    public string? Email { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? HashPassword { get; set; }

    public DateTime? RegistDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
