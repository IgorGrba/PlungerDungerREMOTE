using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private Transform pfHeartProjectile;
    [SerializeField] private Transform pfheartProjectilePos;
    [SerializeField] private LayerMask mouseColliderLayerMask;
    [SerializeField] private float fireDelay = .5f;
    [SerializeField] private float nextShot = 0.15f;

    

    private void Update()
    {
        
        Vector3 mousePosition = Mouse3D.GetMouseWorldPosition();
        Vector3 dir = (mousePosition - pfheartProjectilePos.position).normalized;
        
        
        if (Input.GetMouseButton(0) && Time.time > nextShot)
        {
            Instantiate(pfHeartProjectile, pfheartProjectilePos.position, Quaternion.LookRotation(dir, Vector3.up));
            nextShot = Time.time + fireDelay;
        }
        
        
        transform.LookAt(mousePosition);// Look at the point
        transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0)); 
    }
    
    
}
