using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemiesSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private int _quantitySpawnPoints;
    [SerializeField] private Transform _parent;
    [SerializeField] private float _spawnTime;

    private int _counter;
    private Vector2 _position;
    private float _currentTime;

    void Update()
    {
        _position = new Vector2(Random.Range(-8, 6), Random.Range(-3, 5));
        if (_counter != _quantitySpawnPoints && _currentTime >= _spawnTime)
        {
            Instantiate(_prefab, _position, Quaternion.identity,_parent);
            _counter++;
            _currentTime = 0;
        }
        _currentTime += Time.deltaTime;
    }
}