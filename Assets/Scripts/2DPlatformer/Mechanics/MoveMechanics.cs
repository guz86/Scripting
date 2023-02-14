using UnityEngine;

namespace _2DPlatformer
{
    public class MoveMechanics : MonoBehaviour
    {
        [SerializeField] private Vector2EventReceiver _moveReceiver;
        [SerializeField] private TransformEngine _transformEngine;
        [SerializeField] private int _speed;

        private void OnEnable()
        {
            _moveReceiver.OnEvent += OnMove;
        }

        private void OnDisable()
        {
            _moveReceiver.OnEvent -= OnMove;
        }

        private void OnMove(Vector2 direction)
        {
            _transformEngine.AddPosition(direction * _speed);
        }
    }
}