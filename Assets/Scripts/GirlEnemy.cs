using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlEnemy : MonoBehaviour
{
    [SerializeField] private Transform pfHeartProjectile;
    [SerializeField] private Transform pfheartProjectilePos;
    private Animator girlAnimator;


    [SerializeField] private GameObject guy1;
    [SerializeField] private GameObject guy2;
    [SerializeField] private GameObject guy3;

    private void Awake() {
        girlAnimator = GetComponent<Animator>();
        
    }

    private void Start() {
        Invoke("ShootGuy1", 4f);
        Invoke("ShootGuy2", 8f);
        //Invoke("ShootGuy3", 14f);
        // Invoke("ShootGuy3", 18f);
        // Invoke("ShootGuy3", 22f);
        // Invoke("ShootGuy3", 26f);
        // Invoke("ShootGuy3", 31f);
    }


    /*private void Update()
    {
        timer += Time.deltaTime;
        if(timer > waitingTime){
            Invoke("ShootGuy1", 2f);
            timer = 0;
            Invoke("ShootGuy2", 5f);
            timer = 0;
            Invoke("ShootGuy3", 7f);
            timer = 0;
            
            Invoke("ShootGuy3", 10f);
            timer = 0;
        }
    }*/

    

    


    void ShootGuy1()
    {
        Vector3 targetPos = guy1.transform.position;

        Vector3 dir = (targetPos - pfheartProjectilePos.position).normalized;
        
        girlAnimator.SetTrigger("Kiss");
        Instantiate(pfHeartProjectile, pfheartProjectilePos.position, Quaternion.LookRotation(dir, Vector3.up));


        transform.LookAt(targetPos); // Look at the point
        transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0));
    }
    void ShootGuy2()
    {
        Vector3 targetPos = guy2.transform.position;

        Vector3 dir = (targetPos - pfheartProjectilePos.position).normalized;
        
        girlAnimator.SetTrigger("Kiss");
        Instantiate(pfHeartProjectile, pfheartProjectilePos.position, Quaternion.LookRotation(dir, Vector3.up));


        transform.LookAt(targetPos); // Look at the point
        transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0));
        
    }
    void ShootGuy3()
    {
        Vector3 targetPos = guy3.transform.position;

        Vector3 dir = (targetPos - pfheartProjectilePos.position).normalized;
        
        girlAnimator.SetTrigger("Kiss");
        Instantiate(pfHeartProjectile, pfheartProjectilePos.position, Quaternion.LookRotation(dir, Vector3.up));


        transform.LookAt(targetPos); // Look at the point
        transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0));
    }
    

}
