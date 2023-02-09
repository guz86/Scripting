using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class EndPoint : MonoBehaviour
{
    [SerializeField] private Color _reachedColor;
    
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.TryGetComponent<Player>(out Player player))
        {
            _spriteRenderer.color = _reachedColor;
        }
    }
}
