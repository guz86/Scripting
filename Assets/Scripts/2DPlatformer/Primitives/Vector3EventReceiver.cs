using System;
using UnityEngine;

namespace _2DPlatformer
{
    public class Vector3EventReceiver : MonoBehaviour
    {
        public Action<Vector3> OnEvent;

        public void Call(Vector3 value)
        {
            this.OnEvent?.Invoke(value);
        }
    }
}