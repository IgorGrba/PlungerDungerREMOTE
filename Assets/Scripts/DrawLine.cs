using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
   [SerializeField] private LineRenderer line;

   [SerializeField] private Transform pos1;
   [SerializeField] private Transform pos2;


   private void Start()
   {
      line.positionCount = 2;
   }


   private void Update()
   {
      line.SetPosition(0, pos1.transform.position);
      line.SetPosition(1, pos2.transform.position);
   }
}
