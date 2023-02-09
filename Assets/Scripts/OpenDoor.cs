using UnityEngine;
using UnityEngine.Events;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] private UnityEvent _doorOpened;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<Rogue>(out Rogue rogue))
        {
            _doorOpened?.Invoke();
            Debug.Log("_doorOpened");
        }
    }
}
