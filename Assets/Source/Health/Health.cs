using System;

namespace Source.Health {
    public class Health : IHealth {
        private readonly int _maxHealth;

        private int _health;
        private int _lives;

        public Health(int health, int maxHealth, int lives) {
            _health = health;
            _maxHealth = maxHealth;
            _lives = lives;
        }

        public int CurrentHealth => _health;
        public int CurrentLives => _lives;

        public void TakeHeal(int amount) {
            if (amount < 0) {
                return;
            }

            _health = Math.Min(amount, _maxHealth);
        }

        public void TakeDamage(int amount) {
            if (amount < 0) {
                return;
            }

            _health -= amount;

            if (_health <= 0) {
                _lives--;
            }

            if (_lives <= 0) {
                // Player dead
                return;
            }

            // Player spent 1 life and need health to be restored
            _health = _maxHealth;
        }

        public override string ToString() {
            int progressBarLength = 10;
            string result = "";

            for (int i = 0; i < progressBarLength; i++) {
                if (i < (float)_health / _maxHealth * progressBarLength) {
                    result += "■";
                    continue;
                }

                result += "_";
            }

            return $"[x{_lives}] {result}";
        }
    }
}