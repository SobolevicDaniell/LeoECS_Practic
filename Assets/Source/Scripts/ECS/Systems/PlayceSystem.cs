using Leopotam.Ecs;
using UnityEngine;

namespace Ecs
{
    sealed class PlayceSystem : IEcsRunSystem
    {
        private readonly EcsFilter<PlayerComponent, PlaceComponent> _filter = null;
        
        public void Run()
        {
            foreach (var i in _filter)
            {
                ref var playerComponent = ref _filter.Get1(i);
                ref var place = ref _filter.Get2(i);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Object.Instantiate(place.prefab, playerComponent.playerTransform.position, Quaternion.identity);
                }
            }
        }
    }
}