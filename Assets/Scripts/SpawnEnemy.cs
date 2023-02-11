using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GenerateRandomPoints _generatePoints;
    [SerializeField] private Rogue _rogue;
    
    private Transform[] _points;
    private int _currentPoint;
    private float _secsToNext;

    private void Start()
    {
        _secsToNext = 2f;
    }

    private void Update()
    {
        _secsToNext -= Time.deltaTime;  
        SpawnCheck();
    }

    private void SpawnCheck()
    {
        if(_secsToNext <= 0)
        {
            PeriodSpawn();
            _secsToNext = 2;
        }
    }

    private void PeriodSpawn()
    {
        var idPoints  = Random.Range(0, _generatePoints.Points.Length);
        Instantiate(_rogue, 
            _generatePoints.Points[idPoints].transform.position, 
            Quaternion.identity,
            gameObject.transform);
        
        Debug.Log("PeriodSpawn()");
    }
}
