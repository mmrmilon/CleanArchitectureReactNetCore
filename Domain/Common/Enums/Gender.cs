using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Domain.Common.Enums
{
    public enum Gender
    {
        [Description("Male")]
        Male = 1,
        [Description("Female")]
        Female = 2
    }
}
