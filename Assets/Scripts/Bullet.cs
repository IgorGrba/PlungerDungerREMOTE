using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody _rigidbody;

    [SerializeField] private Transform heartVFX;


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }


    private void Start()
    {
        float speed = 25f;

        _rigidbody.velocity = transform.forward * speed;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BulletTarget>() != null)
        {
            Instantiate(heartVFX, transform.position, Quaternion.identity);

        }
        else
        {
            //Something Else Hit
        }
        Destroy(gameObject);
    }
}
