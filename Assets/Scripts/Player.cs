using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent _hit;


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.TryGetComponent(out Block block))
        {
            _hit?.Invoke();
        }
    }
}
