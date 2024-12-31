namespace Source.Health {
    public interface IHealth {
        int CurrentHealth { get; }
        int CurrentLives { get; }
        void TakeHeal(int amount);
        void TakeDamage(int amount);
    }
}
