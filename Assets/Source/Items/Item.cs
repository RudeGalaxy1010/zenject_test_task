namespace Source.Items {
    public class Item {
        protected string Name;

        public Item(string name) {
            Name = name;
        }

        public override string ToString() {
            return Name;
        }
    }
}
