using System;
using UnityEngine;

namespace Ecs
{
    [Serializable]
    public struct PlayerComponent
    {
        public Transform playerTransform;
        public float speed;
    }
}