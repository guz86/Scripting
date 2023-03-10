using UnityEngine;

namespace _2DPlatformer
{
    public class MoveСomponent : MonoBehaviour, IMoveComponent
    {
        // логика взаимодействия с ядром

        [SerializeField] private Vector2EventReceiver _moveReceiver;

        public void Move(Vector2 vector)
        {
            _moveReceiver.Call(vector);
        }
    }
}