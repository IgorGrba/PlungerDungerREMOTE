using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using DG.Tweening;
public class StackIntoPosition : MonoBehaviour
{

    private Waypoints _waypoints;
    [SerializeField] private Animator anim;
    

    private void Awake()
    {
        _waypoints = GetComponent<Waypoints>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ReadyForStacking"))
        {
            other.transform.DORotate(new Vector3(0, 0, 0), 0.5f);
            anim.SetTrigger("Kneel");
            other.gameObject.GetComponent<CapsuleCollider>().height = 1.80f;
            _waypoints.speed = 0;
        }
    }
    
}
