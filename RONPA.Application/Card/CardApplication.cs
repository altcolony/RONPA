using System;
using System.Collections.Generic;
using RONPA.Model;

namespace RONPA.Application
{
    public class CardApplication
    {
        private readonly ICardRepository _cardRepository; 
        public CardApplication(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }
        public IEnumerable<Card> GetAll(GetAllCardCommand command)
        {
            return _cardRepository.FindAll(command.Ids);
        }
        public IEnumerable<Card> GetAll()
        {
            return _cardRepository.FindAll();
        }
    }
}
