using UnityEngine;

public class LerpExample : MonoBehaviour
{
    [SerializeField] private Transform _a;
    [SerializeField] private Transform _b;
    [SerializeField] private Transform _target;
    [SerializeField] private float _pathTime;
    [SerializeField] private float _pathRunningTime;

    private void Update()
    {
        _pathRunningTime += Time.deltaTime;
        _target.position = Vector3.Lerp(_a.position, _b.position, _pathRunningTime / _pathTime);
    }

    public void SetNormalizePosition(float position)
    {
        // _target.position = Vector3.Lerp(_a.position, _b.position, position);
    }
}