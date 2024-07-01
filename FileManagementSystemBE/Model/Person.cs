using System;
using System.Collections.Generic;

namespace FileManagementSystemBE.Model;

public partial class Person
{
    public Guid PersonId { get; set; }

    public string Email { get; set; } = null!;

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }
}
