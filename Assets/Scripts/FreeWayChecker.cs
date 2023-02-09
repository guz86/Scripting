using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class FreeWayChecker : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private ContactFilter2D _filter;
    
    private Rigidbody2D _rigidbody;
    private RaycastHit2D[] _results = new RaycastHit2D[1];

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        int collisionCount = _rigidbody.Cast(Vector2.right, _filter, _results, 2);
        if (collisionCount == 0)
        {
            _rigidbody.velocity = transform.right * _speed;
        }
    }
}
