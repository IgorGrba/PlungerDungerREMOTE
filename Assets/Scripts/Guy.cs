using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Guy : MonoBehaviour
{
    [SerializeField] private float speed = 0.75f;
    [SerializeField] private Transform girl1;
    [SerializeField] private Transform girl2;
    [SerializeField] private float minimumDistance;
    [SerializeField] private Animator guyAnim;
    

    private Bullet bullet;

    

    private void Update() {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }


    private void OnTriggerEnter(Collider other) {
        
        if (other.GetComponent<Bullet>() != null)
        {
            if (Vector3.Distance(transform.position, girl1.position) > minimumDistance)
            {
                Quaternion targetRotation = Quaternion.LookRotation(girl1.transform.position - transform.position);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 50 * Time.deltaTime);
                transform.position += transform.forward * 1 * Time.deltaTime;
            }
        }
        else
        {
            if (other.GetComponent<EnemyBullet>() != null)
            {
                if (Vector3.Distance(transform.position, girl2.position) > minimumDistance)
                {
                    Quaternion targetRotation = Quaternion.LookRotation(girl2.transform.position - transform.position);
                    transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 50 * Time.deltaTime);
                    transform.position += transform.forward * 1 * Time.deltaTime;
                }
            }
        }

        if (other.GetComponent<StopPlayer>() != null)
        {
            speed = 0;
            guyAnim.SetTrigger("Dance");
            transform.DORotate(new Vector3(0, 0, 0), 2f);
        }
        
    }
}
