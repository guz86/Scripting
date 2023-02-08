using UnityEngine;
using UnityEngine.Events;

public class EnterPoint : MonoBehaviour
{
    [SerializeField] private UnityEvent _reached;

    public bool IsReached { get; private set; }

    public event UnityAction Reached
    {
        add => _reached.AddListener(value);
        remove => _reached.RemoveListener(value);
    }

    private void OnTriggerEnter2D(Collider2D col)
        {
            if (IsReached)
               return; 
            
            if (col.TryGetComponent<Player>(out Player player))
            {
                IsReached = true;
                _reached?.Invoke();
            }
        }
    }