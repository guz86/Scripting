using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class LinearColorChanger : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _duration;
    
    private Color _startColor;
    
    private SpriteRenderer _target;
    
    private float _runningTime;
    

    private void Start()
    {
        _target = GetComponent<SpriteRenderer>();
        _startColor = _target.color;
    }

    private void Update()
    {
        if (_runningTime <= _duration)
        {
            _runningTime += Time.deltaTime;
            //Debug.Log(_runningTime);
            float normalizeRunningTime = _runningTime / _duration;
            _target.color = Color.Lerp(_startColor, _targetColor, normalizeRunningTime);
        }
    }
}
