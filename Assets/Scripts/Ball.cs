﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody _rigidbody;
    Vector3 _velocity;
    Renderer _renderer;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _renderer = GetComponent<Renderer>();
        _rigidbody.velocity = Vector3.down * speed;
        
    }

        void FixedUpdate()
    {
        _rigidbody.velocity = _rigidbody.velocity.normalized * speed;
        _velocity = _rigidbody.velocity;

        if (!_renderer.isVisible)
        {
            GameManager.Instance.Balls--;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        _rigidbody.velocity = Vector3.Reflect(_velocity, collision.contacts[0].normal);
    }
}
