using UnityEngine;

public class CircleInstantiate : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private int _count;
    [SerializeField] private float _radius;
    
    

    private void Start()
    {
        for (int i = 0; i < _count; i++)
        {
            int angleStep = 360 / _count;
            GameObject newObject = Instantiate(_template, Vector3.zero, Quaternion.identity);
            Transform transformNewObject = newObject.GetComponent<Transform>();
            transformNewObject.position = new Vector3(_radius * Mathf.Cos(angleStep * (i+1) * Mathf.Deg2Rad),
                _radius * Mathf.Sin(angleStep * (i+1) * Mathf.Deg2Rad),
                0);
        }
        
    }
}
