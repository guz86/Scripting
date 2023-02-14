using UnityEngine;

namespace _2DPlatformer
{
    public class MoveController : MonoBehaviour,
        IConstructListener, 
        IStartGameListener,
        IFinishGameListener
    {
        private MoveInput _input;
        
        private IMoveComponent _moveInDirectionComponent;

        void IConstructListener.Construct(GameContext context)
        {
            _input = context.GetService<MoveInput>();
            _moveInDirectionComponent = context.GetService<Entity>()
                .Get<IMoveComponent>();
        }
 
        void IStartGameListener.OnStartGame()
        {
            _input.OnMove += OnMove;
        }

        void IFinishGameListener.OnFinishGame()
        {
            _input.OnMove -= OnMove;
        }
  
        private void OnMove(Vector3 direction)
        {
            var velocity = direction * Time.deltaTime;
            _moveInDirectionComponent.Move(velocity);
        }
    }
}