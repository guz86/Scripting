using UnityEngine;

public class LineInstantiate : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private int _count;
    [SerializeField] private int _length;

    private void Start()
    {
        for (int i = 0; i < _count; i++)
        {
            int step = _length / _count;
            GameObject newObject = Instantiate(_template, Vector3.zero, Quaternion.identity);
            Transform transformNewObject = newObject.GetComponent<Transform>();
            transformNewObject.position = new Vector3(step * i, 1, 0);
        }
    }
}