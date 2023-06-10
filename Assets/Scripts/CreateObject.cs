using UnityEngine;
using Random = UnityEngine.Random;

public class CreateObject : MonoBehaviour
{
    [SerializeField] private GameObject _objectToCreate;
    private Transform _spawnPoint;
    [SerializeField] private bool _useSpawnPoint;
    [Range(0,1)][SerializeField] private float _chance = 1;
    [SerializeField] private Transform _referenceObjectRotation;
    private Quaternion _objectRotation;
    [SerializeField] private int _amountOfObjects = 1;
    [SerializeField] private bool _randomizeInitialPositon;
    [SerializeField] private float _xRandomizationFactor = 1;
    [SerializeField] private float _yRandomizationFactor = 1;
    [SerializeField] private float _zRandomizationFactor = 1;
    
    public void CreateNewObject()
    {
        for (int i = 0; i < _amountOfObjects; i++)
        {
            if (Random.value < _chance)
            {
                _objectRotation = _referenceObjectRotation == null ? Quaternion.identity : _referenceObjectRotation.rotation;
                if (_useSpawnPoint)
                {
                    GameObject clone = Instantiate(_objectToCreate, _spawnPoint.position, _objectRotation);
                    clone.name = $"{clone.name} {clone.GetInstanceID()}";
                }
                else
                {
                    Vector3 spawnPoint = transform.position;
                    if (_randomizeInitialPositon)
                    {
                        spawnPoint.x += Random.Range(-_xRandomizationFactor, _xRandomizationFactor);
                        spawnPoint.y += Random.Range(-_yRandomizationFactor, _yRandomizationFactor);
                        spawnPoint.z += Random.Range(-_zRandomizationFactor, _zRandomizationFactor);
                    }
                    GameObject clone = Instantiate(_objectToCreate, spawnPoint, _objectRotation);
                    clone.name = $"{clone.name} {clone.GetInstanceID()}";
                    
                }    
            } 
        }
    }
}