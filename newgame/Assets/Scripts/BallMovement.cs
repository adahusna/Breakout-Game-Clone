using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody _rigidbody;
    Vector3 _velocity;
    float _speed = 20f;

    
    void Start()
    {
        _rigidbody=GetComponent<Rigidbody>();
        _rigidbody.velocity = Vector3.down * _speed;
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        _rigidbody.velocity = Vector3.Reflect(_velocity, collision.contacts[0].normal); 
    }

    void FixedUpdate()
    {
        _rigidbody.velocity = _rigidbody.velocity.normalized * _speed;
        _velocity = _rigidbody.velocity;
    }
}
