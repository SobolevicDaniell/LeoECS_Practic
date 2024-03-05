using Leopotam.Ecs;
using UnityEngine;

namespace Ecs
{
    sealed class PlayerMovmentSystem : IEcsRunSystem
    {
        private readonly EcsFilter<PlayerComponent> _filter = null;
        
        public void Run()
        {
            foreach (var i in _filter)
            {
                ref var playerComponent = ref _filter.Get1(i);
                
                float moveInputX = Input.GetAxis("Horizontal");
                float moveInputZ = Input.GetAxis("Vertical");
                
                Vector2 movement = new Vector2(moveInputX, moveInputZ) * playerComponent.speed * Time.deltaTime;
                
                playerComponent.playerTransform.position += new Vector3(movement.x, 0, movement.y);
            }
        }
    }
}