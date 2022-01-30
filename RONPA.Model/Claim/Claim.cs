using System;
using System.Collections.Generic;

namespace RONPA.Domain
{
    public class Claim:IMemo
    {
        public Claim(
            ClaimId id,
            string text,
            IList<KnowledgeId>knowledgeIds,
            ThinkingId thinkingId)
        {
            Id = id;
            Text = text;
            KnowledgeIds = knowledgeIds??throw new Exception("null");
            ThinkingId = thinkingId??throw new Exception("null");
        }
        public ClaimId Id { get; }
        public string Text { get; private set; }
        public IList<KnowledgeId> KnowledgeIds { get; }
        public ThinkingId ThinkingId { get; }

        public void ChangeText(string newText)
        {
            if (newText.Length > 1000) throw new Exception($"1000文字以内で入力して下さい。");
            Text = newText;
        }
        public bool IsGenerate()
        {
            if (KnowledgeIds.Count >= 1) return true;
            throw new Exception("知識は1つ以上必要です。");
            
        }
        
        
        
    }
}
