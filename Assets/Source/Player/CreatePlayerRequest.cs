using System.Collections.Generic;
using Source.Items;

namespace Source.Player {
    public struct CreatePlayerRequest {
        public string NickName;
        public int Health;
        public int MaxHealth;
        public int Lives;
        public bool IsGodMode;
        public List<string> Skills;
        public Item[] Items;
    }
}
