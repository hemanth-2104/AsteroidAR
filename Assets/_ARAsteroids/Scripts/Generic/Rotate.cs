using UnityEngine;
using Random = UnityEngine.Random;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 _speed;
    [SerializeField] private bool _randomizeInitialRotation;
    [SerializeField] private float _randomizationFactor = 1;
    private void Start()
    {
        if (_randomizeInitialRotation)
        {
            _speed *= Random.Range(-_randomizationFactor, _randomizationFactor);
        }
    }

    void Update()
    {
        transform.Rotate(_speed * Time.deltaTime, Space.Self);
    }
}
