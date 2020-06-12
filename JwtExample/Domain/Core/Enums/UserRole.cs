using System.ComponentModel;

namespace JwtExample.Domain.Core.Enums
{
    public enum UserRole
    {
        [Description("manager")]
        Manager,

        [Description("employee")]
        Employee
    }
}
