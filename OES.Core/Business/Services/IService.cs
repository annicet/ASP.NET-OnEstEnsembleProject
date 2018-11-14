using System;
using System.Collections.Generic;
using System.Text;

namespace OnEstEnsemble.Core.Business.Services
{
   public interface IService <T>
    {
        List<T> GetList();
    }
}
