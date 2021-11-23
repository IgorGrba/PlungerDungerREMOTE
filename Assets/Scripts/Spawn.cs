using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private string StickTag;

    private Rigidbody _rigidbody;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(StickTag))
        {
            _rigidbody.isKinematic = true;
        }
        else
        {
            _rigidbody.useGravity = true;
        }
    }

    public void MoveWithVelocity(Vector3 Velocity)
    {
        _rigidbody.velocity = Velocity;
        _rigidbody.useGravity = true;
    }
}
