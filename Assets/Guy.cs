using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Guy : MonoBehaviour
{
    [SerializeField] private float speed;


    private Bullet bullet;


    private void Update() {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }


    private void OnTriggerEnter(Collider other) {
        if (other.GetComponent<Bullet>() != null)
        {
            transform.DORotate(new Vector3(0, 180, 0), 0.5f, RotateMode.Fast);
        }
        else
        {
            if (other.GetComponent<EnemyBullet>() != null)
            {
                transform.DORotate(new Vector3(0, 0, 0), 0.5f, RotateMode.Fast);
            }
        }
    }
}
