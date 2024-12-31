using Source.Items;
using Source.Player;
using UnityEngine;
using Zenject;

namespace Source {
    // 6. Container resolve demonstration
    public class Main : MonoBehaviour {
        // 4. Get player from container
        [Inject] private IPlayer _player;

        private void Start() {
            // 9. Values changes demonstration
            Debug.Log("Начальные значения:");
            Debug.Log(_player);
            
            _player.Health.TakeHeal(90);
            Debug.Log("Лечим полностью:");
            Debug.Log(_player);
            
            _player.Skills.Add("SuperUltraMegaSkill3000");
            Debug.Log("Прокачиваем скилл:");
            Debug.Log(_player);

            // 11. Add equipment
            _player.Equipment.AddItem(new Weapon("Винтовка Мосина", 4));
            _player.Equipment.AddItem(new Parachute("Парашют"));
            _player.Equipment.AddItem(new RocketPack("Ракетный ранец", 3));
            Debug.Log("Добавляем предметы:");
            Debug.Log(_player);
        }
    }
}
