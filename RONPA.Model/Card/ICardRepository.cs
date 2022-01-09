using System;
using System.Collections.Generic;

namespace RONPA.Model
{
    public interface ICardRepository
    {
        Card Find(int id);
        IEnumerable<Card> FindAll(IEnumerable<int> ids);
        IEnumerable<Card> FindAll();

        void Save(Card card);
        void Delete(int id);
    }
}
