
using Microsoft.EntityFrameworkCore;

namespace FileManagementSystemBE.Model;
public partial class MockupContext
{
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        Console.WriteLine(modelBuilder.GetType().ToString())
;    }
}

