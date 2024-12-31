using Source.Equipment;
using Source.Health;
using Source.Skills;

namespace Source.Player {
    // 2. Player implements IPlayer
    public class Player : IPlayer {
        private readonly string _nickname;
        private readonly IHealth _health;
        private readonly ISkills _skills;
        private readonly IEquipment _equipment;

        public Player(string name, IHealth health, ISkills skills, IEquipment equipment) {
            _nickname = name;
            _health = health;
            _skills = skills;
            _equipment = equipment;
        }

        // Player components access
        public string NickName => _nickname;
        public IHealth Health => _health;
        public ISkills Skills => _skills;
        public IEquipment Equipment => _equipment;

        public override string ToString() {
            string result = "";

            result += $"Никнейм: {NickName}\n";
            result += $"Здоровье: {Health}\n";
            result += $"Умения: \n{Skills}";
            result += $"Предметы: \n{Equipment}";

            return result;
        }
    }
}