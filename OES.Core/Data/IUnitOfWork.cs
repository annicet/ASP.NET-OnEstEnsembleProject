using OnEstEnsemble.Core.Data.QueryManager;
using OnEstEnsemble.Core.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnEstEnsemble.Core.Data
{
    public interface IUnitOfWork
    {
        IEventsRepository EventsRepository { get; }
        IEventsQueryManager EventsQueryManager { get; }
    }
}
