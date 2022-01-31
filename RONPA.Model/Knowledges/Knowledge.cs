using System;
using System.Collections.Generic;
using RONPA.Domain.Thinkings;
using RONPA.Domain.Claims;

namespace RONPA.Domain.Knowledges
{
    public class Knowledge : IMemo
    {
        public Knowledge(KnowledgeId id, string text)
        {
            Id = id;
            Text = text;
        }
        public KnowledgeId Id { get; }
        public string Text { get; private set; }
        public IList<KnowledgeId> KnowledgeIds { get; }
        public IList<ThinkingId> ThinkingIds { get; }
        public IList<ClaimId> ClaimIds { get; }

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
            KnowledgeIds.Add(id);
        }
        public void JoinThinking(ThinkingId id)
        {
            ThinkingIds.Add(id);
        }
        public void JoinClaim(ClaimId id)
        {
            ClaimIds.Add(id);
        }
    }
}
