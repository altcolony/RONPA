using System;
using System.Collections.Generic;
using RONPA.Domain.Knowledges;
using RONPA.Domain.Claims;

namespace RONPA.Domain.Thinkings
{
    public class Thinking:IMemo
    {
        public Thinking(
            ThinkingId id,
            string text,
            IList<KnowledgeId>knowledgeIds,
            ClaimId claimId)
        {
            Id = id;
            if (text.Length > 300) throw new Exception("思考は300文字以内で入力して下さい。");
            Text = text;
            KnowledgeIds = knowledgeIds;
            ClaimId = claimId;
        }
        public ThinkingId Id { get; }
        public string Text { get;private set; }
        public IList<KnowledgeId> KnowledgeIds { get; private set; }
        public ClaimId ClaimId { get; private set; }

        public void ChangeText(string newText)
        {
            throw new NotImplementedException("思考は編集できません");
        }
        public void JoinKnowledge(KnowledgeId id)
        {
            if (KnowledgeIds == null) KnowledgeIds = new List<KnowledgeId>();
            KnowledgeIds.Add(id);
        }
        public void RemoveKnowledge(KnowledgeId id)
        {
            KnowledgeIds.Remove(id);
        }
        public void FetchClaim(ClaimId claimId)
        {
            ClaimId = claimId;
        }
    }
}
