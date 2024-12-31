using System;
using System.Collections.Generic;
using Source.Equipment;
using Source.Health;
using Source.Items;
using Source.Player;
using Source.Skills;
using Zenject;

namespace Source.Installers {
    public class PlayerInstaller : MonoInstaller {
        // Inject player
        public override void InstallBindings() {
            CreatePlayerRequest createPlayerRequest = new CreatePlayerRequest {
                NickName = "John",
                IsGodMode = false,
                Health = 10,
                MaxHealth = 100,
                Lives = 3,
                Skills = new List<string>(),
                Items = Array.Empty<Item>() // 12. Here can add equipment
            };
            
            IHealth health = CreateHealth(createPlayerRequest);
            ISkills skills = CreateSkills(createPlayerRequest);
            IEquipment equipment = CreateEquipment(createPlayerRequest);

            // 3. Create IoC-container
            // 10. AsSingle guarantees single instance of IPlayer
            Container.Bind<IPlayer>().To<Player.Player>().FromNew().AsSingle()
                .WithArguments(createPlayerRequest.NickName, health, skills, equipment).NonLazy();
        }

        // Help methods
        private IHealth CreateHealth(CreatePlayerRequest request) {
            return request.IsGodMode
                ? new InfiniteHealth()
                : new Health.Health(request.Health, request.MaxHealth, request.Lives);
        }

        private ISkills CreateSkills(CreatePlayerRequest request) {
            return new Skills.Skills(request.Skills);
        }

        private IEquipment CreateEquipment(CreatePlayerRequest request) {
            return request.Items?.Length > 0 ? new Equipment.Equipment(request.Items) : new Equipment.Equipment();
        }
    }
}
