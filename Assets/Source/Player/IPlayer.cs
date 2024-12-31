using Source.Equipment;
using Source.Health;
using Source.Skills;

namespace Source.Player {
    // 1. Create interface with access to components
    public interface IPlayer {
        public string NickName { get; }
        public IHealth Health { get; }
        public ISkills Skills { get; }
        public IEquipment Equipment { get; }
    }
}