

using System.Collections;
using UnityEngine;

public class SpawnColliderArea : MonoBehaviour
{
  	[SerializeField] private GameObject _prefab;
  	[SerializeField] private Collider _collider;
  	[SerializeField] private float _spawnDelayTime = 1;
  	[SerializeField] private GameState _gameState;
  	private Vector3 _spawnPosition;

  	void Start()
  	{
        // start spawn
    	StartCoroutine(SpawnRoutine());
  	}

IEnumerator SpawnRoutine()
  	{
        // continue loop while GameOveris false
    	while (!_gameState.GameOver)
            {
            // get new position for asteroid
            _spawnPosition = GetSpawnPosition();

            // create a new asteroid from prefab
            GameObject clone = Instantiate(_prefab, _spawnPosition, Quaternion.identity);

            // change new asteroid's game object name
            clone.name = $"{clone.name}{(clone.GetInstanceID())}";

            // wait before looping again
            yield return new WaitForSeconds(_spawnDelayTime);
            }
  	}	

  	Vector3 GetSpawnPosition()
  	{
    	// get a random position from the bounds of the AsteroidSpawner's Box Collider
    	// use this to position our new spawned asteroid
    	return new Vector3(Random.Range(_collider.bounds.min.x, _collider.bounds.max.x),
        Random.Range(_collider.bounds.min.y, _collider.bounds.max.y),
        Random.Range(_collider.bounds.min.z, _collider.bounds.max.z));
  	}  
}