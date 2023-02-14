using System;
using UnityEngine;

namespace _2DPlatformer
{
    public class MoveInput : MonoBehaviour,
        IStartGameListener,
        IFinishGameListener
    {
        public event Action<Vector3> OnMove;

        private void Awake()
        {
            enabled = false;
        }

        private void Update()
        {
            HandleKeyboard();
        }

        private void HandleKeyboard()
        {
            if (Input.GetKey(KeyCode.W))
            {
                this.Move(Vector3.forward);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                this.Move(Vector3.back);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                this.Move(Vector3.left);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                this.Move(Vector3.right);
            }
        }

        private void Move(Vector3 direction)
        {
            this.OnMove?.Invoke(direction);
        }

        void IStartGameListener.OnStartGame()
        {
            enabled = true;
        }

        void IFinishGameListener.OnFinishGame()
        {
            enabled = false;
        }

    }
}