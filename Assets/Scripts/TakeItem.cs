using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeItem : MonoBehaviour
{
    private GameObject _item;

    void Start()
    {
        _item = GetComponent<GameObject>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerMovement>(out PlayerMovement playerMovement))
        {
            Destroy(gameObject);
        }
    }
}
