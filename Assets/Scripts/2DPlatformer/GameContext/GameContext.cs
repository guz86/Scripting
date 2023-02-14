using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace _2DPlatformer
{
    public class GameContext : MonoBehaviour
    {
        [SerializeReference] private readonly List<object> _listeners = new();
        [SerializeReference] private readonly List<object> _services = new();

        public void AddService(object service)
        {
            _services.Add(service);
        }

        public void RemoveService(object service)
        {
            _services.Remove(service);
        }

        public T GetService<T>()
        {
            foreach (var service in _services)
            {
                if (service is T result)
                {
                    return result;
                }
            }

            throw new Exception($"Service of type {typeof(T).Name} is not found!");
        }
        
        public void ConstructGame()
        {
            foreach (var listener in _listeners)
            {
                if (listener is IConstructListener constructListener)
                {
                    constructListener.Construct(context: this);
                }
            }

            Debug.Log("Game Construct!");
        }
        
        public void ReadyGame()
        {
            foreach (var listener in _listeners)
            {
                if (listener is IReadyGameListener readyListener)
                {
                    readyListener.OnReadyGame();
                }
            }

            Debug.Log("ReadyGame!");
        }

        // _listeners

        public void AddListener(object listener)
        {
            _listeners.Add(listener);
        }

        public void RemoveListener(object listener)
        {
            _listeners.Remove(listener);
        }
        
        public void StartGame()
        {
            foreach (var listener in _listeners)
            {
                if (listener is IStartGameListener startGameListener)
                {
                    startGameListener.OnStartGame();
                }
            }

            Debug.Log("Game Started!");
        }
        
        public void FinishGame()
        {
            foreach (var listener in _listeners)
            {
                if (listener is IFinishGameListener finishGameListener)
                {
                    finishGameListener.OnFinishGame();
                }
            }

            Debug.Log("Game Finish!");
        }
    }
}