using System;
using System.Collections.Generic;
using RONPA.Domain.Knowledges;

namespace RONPA.Application.Knowledges
{
    public class CardApplication
    {
        private readonly IKnowledgeRepository _cardRepository; 
        public CardApplication(IKnowledgeRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }
        public IEnumerable<Knowledge> GetAll(GetAllCardCommand command)
        {
            return _cardRepository.FindAll();
        }
        public IEnumerable<Knowledge> GetAll()
        {
            return _cardRepository.FindAll();
        }
    }
}
