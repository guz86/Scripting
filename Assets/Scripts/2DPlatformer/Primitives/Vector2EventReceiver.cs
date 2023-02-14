using System;
using UnityEngine;

namespace _2DPlatformer
{
    public class Vector2EventReceiver : MonoBehaviour
    {
        public Action<Vector2> OnEvent;

        public void Call(Vector2 value)
        {
            this.OnEvent?.Invoke(value);
        }
    }
}