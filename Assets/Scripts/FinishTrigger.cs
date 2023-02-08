using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    private EnterPoint[] _points;

    private void OnEnable()
    {
        _points = gameObject.GetComponentsInChildren<EnterPoint>();
        foreach (var point in _points)
        {
            point.Reached += OnPointReached;
        }
    }
    
    private void OnDisable()
    {
        _points = gameObject.GetComponentsInChildren<EnterPoint>();
        foreach (var point in _points)
        {
            point.Reached -= OnPointReached;
        }
    }

    private void OnPointReached()
    {
        foreach (var point in _points)
        {
            if (point.IsReached == false) return;
        }
            
        Debug.Log("Finish");
    }
}