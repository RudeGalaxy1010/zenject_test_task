namespace Source.Items {
    public class RocketPack : Item {
        private int _charges;
        
        public RocketPack(string name, int charges) : base(name) {
            _charges = charges;
        }
    
        public override string ToString() {
            return $"{base.ToString()}, использования: {_charges}";
        }
    }
}
