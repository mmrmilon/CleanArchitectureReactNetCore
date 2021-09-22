using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common
{
    public interface ICurrentUserService
    {
        long UserId { get; }
    }
}
