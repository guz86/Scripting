using UnityEngine;

namespace _2DPlatformer
{
    public class GameContextInstaller : MonoBehaviour
    {
        [SerializeField] private GameContext _context;

        [SerializeField] private MonoBehaviour[] _listeners;

        [SerializeField] private MonoBehaviour[] _services;

        private void Awake()
        {
            foreach (var service in _services)
            {
                _context.AddService(service);
            }

            foreach (var listener in _listeners)
            {
                _context.AddListener(listener);
            }
        }
    }
}