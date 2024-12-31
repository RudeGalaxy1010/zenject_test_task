using System.Collections.Generic;
using Source.Items;

namespace Source.Equipment {

    public class Equipment : IEquipment {
        private readonly List<Item> _items = new List<Item>();

        public Equipment() { }

        public Equipment(Item[] requestItems) {
            for (int i = 0; i < requestItems.Length; i++) {
                if (requestItems[i] == null) {
                    continue;
                }

                _items.Add(requestItems[i]);
            }
        }

        public void AddItem(Item item) {
            if (_items.Contains(item) || item == null) {
                return;
            }

            _items.Add(item);
        }

        public void RemoveItem(Item item) {
            if (!_items.Contains(item) || item == null) {
                return;
            }

            _items.Remove(item);
        }

        public override string ToString() {
            if (_items.Count == 0) {
                return "\t-\n";
            }

            string result = "";

            for (int i = 0; i < _items.Count; i++) {
                result += $"\t[{i + 1}] {_items[i]}\n";
            }

            return result;
        }
    }
}
