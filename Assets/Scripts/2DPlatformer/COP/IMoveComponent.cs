using UnityEngine;

namespace _2DPlatformer
{
    public interface IMoveComponent
    {
        void Move(Vector3 direction);
    }
}