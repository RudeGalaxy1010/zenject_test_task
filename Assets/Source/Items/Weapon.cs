namespace Source.Items {
    public class Weapon : Item {
        private int _ammo;

        public Weapon(string name, int ammo) : base(name) {
            _ammo = ammo;
        }

        public override string ToString() {
            return $"{base.ToString()}, патроны: {_ammo}";
        }
    }
}
