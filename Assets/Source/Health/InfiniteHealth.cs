namespace Source.Health {
    public class InfiniteHealth : IHealth {
        public int CurrentHealth => -1;
        public int CurrentLives => -1;

        public void TakeHeal(int amount) { }

        public void TakeDamage(int amount) { }

        public override string ToString() {
            return "Макс.";
        }
    }
}
