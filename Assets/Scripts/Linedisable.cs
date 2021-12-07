using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linedisable : MonoBehaviour
{
    [SerializeField] private GameObject LineVisual;


    private void Start()
    {
        Invoke("DisableLineVisual", 2f);
    }




    void DisableLineVisual()
    {
        LineVisual.SetActive(true);
    }
}