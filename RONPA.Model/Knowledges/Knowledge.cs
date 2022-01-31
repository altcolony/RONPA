using System;
using System.Collections.Generic;
using RONPA.Domain.Thinkings;
using RONPA.Domain.Claims;

namespace RONPA.Domain.Knowledges
{
    public class Knowledge : IMemo
    {
        public Knowledge(
            KnowledgeId id,
            string text,
            IList<KnowledgeId>knowledgeIds,
            IList<ThinkingId>thinkingIds,
            IList<ClaimId>claimIds)
        {
            Id = id;
            Text = text;
            KnowledgeIds = knowledgeIds;
            ThinkingIds = thinkingIds;
            ClaimIds = claimIds;
        }
        public KnowledgeId Id { get; }
        public string Text { get; private set; }
        public IList<KnowledgeId> KnowledgeIds { get; private set; }
        public IList<ThinkingId> ThinkingIds { get; private set; }
        public IList<ClaimId> ClaimIds { get; private set; }

        public void ChangeText(string newText)
        {
            if (newText.Length > 100) throw new Exception($"100文字以内で入力して下さい。");
            Text = newText;
        }
        public bool IsNotSame(KnowledgeId other)
        {
            return this.Id.Value == other.Value ? throw new Exception("同一の知識は紐づけられません") : true;
        }
        public void JoinKnowledge(KnowledgeId id)
        {
            if (KnowledgeIds == null) KnowledgeIds = new List<KnowledgeId>();
            KnowledgeIds.Add(id);
        }
        public void JoinThinking(ThinkingId id)
        {
            if (ThinkingIds == null) ThinkingIds = new List<ThinkingId>();
            ThinkingIds.Add(id);
        }
        public void JoinClaim(ClaimId id)
        {
            if (ClaimIds == null) ClaimIds = new List<ClaimId>();
            ClaimIds.Add(id);
        }
    }
}
