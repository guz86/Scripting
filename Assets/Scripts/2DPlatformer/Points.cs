using UnityEngine;

namespace _2DPlatformer
{
    public class Points : MonoBehaviour
    {
        [SerializeField] private EmptyPoint[] _points;

        public EmptyPoint[] PointsArray => _points;

        private void Awake()
        {
            _points = gameObject.GetComponentsInChildren<EmptyPoint>();
        }
    }
}