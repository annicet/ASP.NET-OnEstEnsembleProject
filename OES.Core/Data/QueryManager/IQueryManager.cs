using System;
using System.Collections.Generic;
using System.Text;

namespace OnEstEnsemble.Core.Data.QueryManager
{
    public interface IQueryManager<T>
    {
        string Query();
    }
}
