using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Range(0,100)][SerializeField] private float _jumpForce;
    [SerializeField] private float _speed;

    private Rigidbody2D _body;
    private bool _isGrounded;
    private Vector2 _targetVelocity;

    void Start()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _isGrounded = true;
    }

    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.Space)&&_isGrounded)
        {
            _body.AddForce(Vector2.up*_jumpForce, ForceMode2D.Impulse);
            _isGrounded = false;
        }
        _targetVelocity =new Vector2(Input.GetAxis("Horizontal"),0);
        transform.Translate(_targetVelocity * _speed * Time.deltaTime);
    }
}
