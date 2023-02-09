using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody2D))]
public class Block : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private float _jumpForce;
    
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _rigidbody.AddForce(Vector2.up * _jumpForce);
    }
}