using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlEnemy : MonoBehaviour
{
    [SerializeField] private Transform pfHeartProjectile;
    [SerializeField] private Transform pfheartProjectilePos;
    [SerializeField] private LayerMask mouseColliderLayerMask;
    [SerializeField] private float timer = .5f;
    [SerializeField] private int waitingTime = 2;
    private Animator girlAnimator;


    [SerializeField] private GameObject guy1;
    [SerializeField] private GameObject guy2;

    private void Awake() {
        girlAnimator = GetComponent<Animator>();
        
    }

    private void Start() {
        

    }


    private void Update() {


        Vector3 targetPos = guy1.transform.position;


        Vector3 dir = (targetPos - pfheartProjectilePos.position).normalized;
        
            timer += Time.deltaTime;
            if (timer > waitingTime)
            {
                girlAnimator.SetTrigger("Kiss");
            Instantiate(pfHeartProjectile, pfheartProjectilePos.position, Quaternion.LookRotation(dir, Vector3.up));
            

            transform.LookAt(targetPos);// Look at the point
            transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0));
                timer = 0;
                StartCoroutine(TargetDelay());
            }
            
    }


    private IEnumerator TargetDelay()
    {
        Vector3 targetPos2 = guy2.transform.position;


        Vector3 dir = (targetPos2 - pfheartProjectilePos.position).normalized;
        yield return new WaitForSeconds(3f);
        Instantiate(pfHeartProjectile, pfheartProjectilePos.position, Quaternion.LookRotation(dir, Vector3.up));
                    transform.LookAt(targetPos2);// Look at the point
            transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0));

    }
    
}
