using System;
using System.Collections.Generic;
using RONPA.Domain;

namespace RONPA.Application
{
    public class CardApplication
    {
        private readonly IReasonRepository _cardRepository; 
        public CardApplication(IReasonRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }
        public IEnumerable<Reason> GetAll(GetAllCardCommand command)
        {
            return _cardRepository.FindAll(command.Ids);
        }
        public IEnumerable<Reason> GetAll()
        {
            return _cardRepository.FindAll();
        }
    }
}
