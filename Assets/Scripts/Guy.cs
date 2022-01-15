using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using DG.Tweening;

public class Guy : MonoBehaviour
{
    [SerializeField] private Transform girl1;
    [SerializeField] private Transform girl2;



    [SerializeField] private Material shirtMaterial;


    private Bullet bullet;

    private void Start()
    {
        shirtMaterial.DOColor(new Color32(255, 255, 255, 255), 0.25f);
        
    }
    


    private void OnTriggerEnter(Collider other) {
        
        if (other.GetComponent<Bullet>() != null)
        {
           
                shirtMaterial.DOColor(new Color32(255, 70, 255, 255), 0.25f);
                Quaternion targetRotation = Quaternion.LookRotation(girl1.transform.position - transform.position);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 50 * Time.deltaTime);
                transform.position += transform.forward * 1 * Time.deltaTime;
                Debug.Log("I've hit him");
                
                gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                gameObject.GetComponent<CapsuleCollider>().enabled = false;
                StartCoroutine(Delay());
        }
        else
        {
            if (other.GetComponent<EnemyBullet>() != null)
            {
                
                    shirtMaterial.DOColor(new Color32(255, 135, 0, 255), 0.25f);
                    Quaternion targetRotation = Quaternion.LookRotation(girl2.transform.position - transform.position);
                    transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 50 * Time.deltaTime);
                    transform.position += transform.forward * 1 * Time.deltaTime;

                    Debug.Log("Enemy hit him");
            }

        }
        
    }


    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(1f);
        gameObject.GetComponent<CapsuleCollider>().enabled = true;
    }
}
