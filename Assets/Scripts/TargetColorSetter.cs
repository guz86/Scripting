using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class TargetColorSetter : MonoBehaviour
{
    //Adapter
    private SpriteRenderer _spriteRenderer;
    
    [SerializeField] private Color _targetColor;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Change()
    {
        _spriteRenderer.color = _targetColor;
    }
}