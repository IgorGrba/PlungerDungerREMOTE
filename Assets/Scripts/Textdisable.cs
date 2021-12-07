using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textdisable : MonoBehaviour
{
    [SerializeField] private GameObject TextVisual;


    private void Start()
    {
        Invoke("DisableTextVisual", 3f);
    }




    void DisableTextVisual()
    {
        TextVisual.SetActive(true);
    }
}