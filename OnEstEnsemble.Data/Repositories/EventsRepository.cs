using OnEstEnsemble.Core.Business.Model;
using OnEstEnsemble.Core.Data;
using OnEstEnsemble.Core.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnEstEnsemble.Data.Repositories
{
    class EventsRepository : IEventsRepository
    {
        IOESContext _context;
        IUnitOfWork _uow;

        public EventsRepository(IOESContext context, IUnitOfWork uow)
        {
            _context = context;
            _uow = uow;
        }

        public void Delete(OES_Events entity)
        {
            throw new NotImplementedException();
        }

        public OES_Events GetById(decimal key)
        {
            return _context.Events.FirstOrDefault(c => c.ID == key);
        }

        public IEnumerable<OES_Events> GetEventsList()
        {
            string sql = _uow.EventsQueryManager.Query();
            return _context.Events.SqlQuery(sql).AsNoTracking().ToList();
        }

        public List<OES_Events> GetList()
        {
            return _context.Events.ToList();
        }

        public void Insert(OES_Events entity)
        {
            throw new NotImplementedException();
        }

        public void update(decimal key, OES_Events entity)
        {
            throw new NotImplementedException();
        }


    }
}
