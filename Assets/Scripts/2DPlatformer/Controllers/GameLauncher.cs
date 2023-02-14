using UnityEngine;

namespace _2DPlatformer
{
    public class GameLauncher : MonoBehaviour
    {
        [SerializeField] private GameContext _gameContext;

        private void Start()
        {
            _gameContext.ConstructGame();
            _gameContext.ReadyGame();
            _gameContext.StartGame();
        }
    }
}