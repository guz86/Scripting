using UnityEngine;
using UnityEngine.EventSystems;

public class Block : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private float _jumpForce;
    
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _rigidbody.AddForce(Vector2.up * _jumpForce);
    }
}