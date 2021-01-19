using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAnimations : MonoBehaviour
{
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {        
        if (Input.GetKey(KeyCode.D))
            _animator.SetBool("runRight", true);
        else
            _animator.SetBool("runRight", false);
        if (Input.GetKey(KeyCode.A))
            _animator.SetBool("runLeft", true);
        else
            _animator.SetBool("runLeft", false);  
    }
}
