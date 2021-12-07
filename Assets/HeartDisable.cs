using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartDisable : MonoBehaviour
{
    [SerializeField] private GameObject guysAndGirls;
    [SerializeField] private GameObject heartVisual;


    private void Start()
    {
        Invoke("DisableHeartVisual", 2f);
    }




    void DisableHeartVisual()
    {
        heartVisual.SetActive(true);
        guysAndGirls.SetActive(true);
    }
}
