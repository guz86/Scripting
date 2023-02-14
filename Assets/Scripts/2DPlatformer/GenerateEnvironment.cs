using UnityEngine;

namespace _2DPlatformer
{
    public class GenerateEnvironment : MonoBehaviour
    {
        [SerializeField] private Points _generatePoints;
        [SerializeField] private PlatformChangeColor _platform;
    
        private Transform[] _points;
        private int _currentPoint;
        private float _secsToNext;

        private void Start()
        {
            var value  = Random.Range(1, 3);
            for (int i = 0; i < _generatePoints.PointsArray.Length; i++)
            {
                Instantiate(_platform, 
                    _generatePoints.PointsArray[i].transform.position,
                    Quaternion.identity,
                    gameObject.transform);
                i += value;
            }
        }
    }
}
