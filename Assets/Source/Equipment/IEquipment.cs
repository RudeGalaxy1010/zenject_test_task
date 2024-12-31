using Source.Items;

namespace Source.Equipment {
    public interface IEquipment {
        void AddItem(Item item);
        void RemoveItem(Item item);
    }
}