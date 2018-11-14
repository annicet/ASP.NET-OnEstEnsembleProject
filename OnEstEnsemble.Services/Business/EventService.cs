using OnEstEnsemble.Core.Business.Dtos;
using OnEstEnsemble.Core.Business.Model;
using OnEstEnsemble.Core.Business.Services;
using OnEstEnsemble.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnEstEnsemble.Services.Business
{
    public class EventService : IEventService
    {
        private readonly IUnitOfWork _uow;

        public EventService (IUnitOfWork uow)
        {
            _uow = uow;
        }
        public List<Event> GetList()
        {
            List<OES_Events> _entityList = _uow.EventsRepository.GetList();
            if (_entityList == null)
                throw new Exception("No Events found");
            List<Event> entityList = new List<Event>();
            foreach (OES_Events entity_ in _entityList)
            {
                Event entity = new Event
                {
                    ID = entity_.ID,
                    Name = entity_.Name,
                    Date = entity_.Date,
                    Description = entity_.Description,
                    ImageUrl = entity_.ImageUrl
                };
                entityList.Add(entity);
            }
            return entityList;
        }

        List<OES_Events> IService<OES_Events>.GetList()
        {
            throw new NotImplementedException();
        }
    }
}
