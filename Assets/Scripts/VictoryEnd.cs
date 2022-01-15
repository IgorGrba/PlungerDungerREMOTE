using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Dreamteck.Splines;
using UnityEngine;

public class VictoryEnd : MonoBehaviour
{
    [SerializeField] private Animator girlAnim;
    [SerializeField] private Transform girl;
    [SerializeField] private SplineFollower splineFollower;
    [SerializeField] private GameObject confetti;

    [SerializeField] private GameObject crown;
    [SerializeField] private GameObject fakeCrown;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Girl"))
        {
            girlAnim.SetTrigger("dance");
            splineFollower.enabled = false;
            girl.DORotate(new Vector3(0, -85f, 0), 0.25f);
            girl.DOMove(new Vector3(-1.948f, 2.488f, 0.55f), 0.25f);
            confetti.SetActive(true);
            fakeCrown.SetActive(false);
            crown.SetActive(true);
        }
    }
}
