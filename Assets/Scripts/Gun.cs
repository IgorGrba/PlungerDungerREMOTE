using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    [SerializeField] private Transform pfHeartProjectile;
    [SerializeField] private Transform pfheartProjectilePos;
    [SerializeField] private LayerMask mouseColliderLayerMask;
    [SerializeField] private float fireDelay = 1f;
    [SerializeField] private float timeWhenAllowedNextShoot = 0.15f;
    private Animator girlAnimator;


    [SerializeField] private Image fillImage;
    
    
    
    
    private void Awake() {
        girlAnimator = GetComponent<Animator>();
        
    }
    

    private void Update()
    {
        
        Vector3 mousePosition = Mouse3D.GetMouseWorldPosition();
        Vector3 dir = (mousePosition - pfheartProjectilePos.position).normalized;
        
        
        
        if (Input.GetMouseButton(0) && timeWhenAllowedNextShoot <= Time.time)
        {
            girlAnimator.SetTrigger("Kiss");
            Instantiate(pfHeartProjectile, pfheartProjectilePos.position, Quaternion.LookRotation(dir, Vector3.up));
            timeWhenAllowedNextShoot = Time.time + fireDelay;

            StartCoroutine(FillImage());

        }
        
        
        transform.LookAt(mousePosition);// Look at the point
        transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0)); 
    }


    private IEnumerator FillImage()
    {
        fillImage.DOFillAmount(0, 0.25f);
        yield return new WaitForSeconds(1f);
        fillImage.DOFillAmount(1f, 2f);
    }
    
}
