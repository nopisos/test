using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayChecker : MonoBehaviour
{
    [SerializeField]private Transform _detector;

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * 2);
        RaycastHit2D _hit = Physics2D.Raycast(_detector.position, Vector2.down, 0, 1);
        if (!_hit)
            transform.Rotate(new Vector3(0, -180, 0));

    }
}
