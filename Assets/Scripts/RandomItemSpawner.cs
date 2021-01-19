using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItemSpawner : MonoBehaviour
{
    [SerializeField]private GameObject _prefab;
    [SerializeField] private GameObject _parent;
    [SerializeField]private int _quantitySpawnPoints;
    [SerializeField] private int _itemsInLine;

    private int _counter;
    private Vector2 _position;

    void Update()
    {        
        _position = new Vector2(Random.Range(-8, 6), Random.Range(-3, 5));
        if (_counter != _quantitySpawnPoints)
        {
            for (int i = 0; i < _itemsInLine; i++)
            {
                Instantiate(_prefab, _position, Quaternion.identity,_parent.transform);
                _position.x += 1;
            }
            _counter++;
        }
        if (_parent.transform.childCount  < _itemsInLine)
            _counter = 0;
    }
}
