using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class DisableOnClick : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _duration;
    private SpriteRenderer _target;
    private Color _startColor;
    [SerializeField] private float _runningTime;

    private void Start()
    {
        _target = GetComponent<SpriteRenderer>();
        _startColor = _target.color;
    }

    private void OnMouseDown()
    {
        StartCoroutine(Fade());
    }

    private IEnumerator Fade()
    {
        while (_runningTime <= _duration)
        {
            _runningTime += Time.deltaTime;
            float normalizeRunningTime = _runningTime / _duration;
            _target.color = Color.Lerp(_startColor, _targetColor, normalizeRunningTime);
            yield return null;
        }

        gameObject.SetActive(false);
    }
}