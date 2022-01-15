using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;

public class RotateGuys : MonoBehaviour
{
    string[] guyTags = {"Guy1", "Guy2", "Guy3"};
    private void OnTriggerEnter(Collider other)
    {
        if (guyTags.Contains(other.gameObject.tag))
        {
            other.transform.DORotate(new Vector3(0, 90, 0), 1f);
            Debug.Log("Hit");
        }
    }
}
