using UnityEngine;


public class GenerateRandomPoints : MonoBehaviour
{
    [SerializeField] private EmptyPoint _emptyPoint;
    private int _count;
    private EmptyPoint[] _points;
    
    public EmptyPoint[] Points => _points;

    private void Awake()
    {
        var randCount = Random.Range(5, 10);
        _count = 0;
        _points = new EmptyPoint[randCount];
        
        for (int i = 0; i < randCount; i++)
        {
            Vector3 position = new Vector3(i + _count, 0, 0);
            var point = Instantiate(_emptyPoint, position, Quaternion.identity, gameObject.transform);
            _count += 2;
            
            _points[i] = point;
        }
    }
}
