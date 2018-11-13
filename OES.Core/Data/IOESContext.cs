using OnEstEnsemble.Core.Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace OnEstEnsemble.Core.Data
{
    public interface IOESContext
    {
        DbSet<OES_Events> Events { get; set; }
    }
}
