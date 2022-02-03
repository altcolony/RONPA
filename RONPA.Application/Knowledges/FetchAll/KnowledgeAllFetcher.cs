using System;
using System.Collections.Generic;
using System.Linq;
using RONPA.Domain.Knowledges;

namespace RONPA.UseCase.Knowledges.FetchAll
{
    public class KnowledgeAllFetcher
    {
        private readonly IKnowledgeRepository _knowledgeRepository;
        public KnowledgeAllFetcher(IKnowledgeRepository knowledgeRepository)
        {
            _knowledgeRepository = knowledgeRepository;
        }
        public IEnumerable<KnowledgeData> Execute()
        {
            var knowledges = _knowledgeRepository.FindAll();
            return knowledges.Select(x => new KnowledgeData(
                x.Id.Value,
                x.Text,
                x.KnowledgeIds.Select(x => x.Value).ToList(),
                x.Date));
        }
    }
}
