using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    [SerializeField] private List<GameObject> _respawnObjects;
    [SerializeField] private float _minPositionY;
    [SerializeField] private float _maxPositionY;
    [SerializeField] private float _respawnTime;

    private void Start()
    {
        Pool.Initialize(transform);

        if (_respawnTime <= 0)
            _respawnTime = 1;

        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        var spawnObjectIndex = Random.Range(0, _respawnObjects.Count);
        var spawnObjectPositionY = Random.Range(_minPositionY, _maxPositionY);
        var spawnObjectPosition = new Vector3(transform.position.x, spawnObjectPositionY, transform.position.z);
        Pool.GetFromPool(_respawnObjects[spawnObjectIndex], spawnObjectPosition);

        yield return new WaitForSeconds(_respawnTime);
        StartCoroutine(Spawner());
    }
}
