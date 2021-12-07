using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Dreamteck.Splines;
using UnityEngine;

public class ActivateAngryAnimation : MonoBehaviour
{
    [SerializeField] private Animator girlAnim;

    [SerializeField] private GameObject girl;

    [SerializeField] private SplineFollower splineFollower;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Girl"))
        {
            splineFollower.enabled = false;
            girl.transform.DORotate(new Vector3(0, -104.256f, 0), 0.25f);
            girlAnim.SetTrigger("Angry");
        }
    }
}
