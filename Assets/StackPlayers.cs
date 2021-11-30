using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class StackPlayers : MonoBehaviour
{
   
   [Header("Guy References:")]
   [SerializeField] private Transform guy1;
   [SerializeField] private Transform guy2;
   [SerializeField] private Transform guy3;
   [SerializeField] private Transform guy4;
   [SerializeField] private Transform guy5;
   [SerializeField] private Transform guy6;


   [SerializeField] private Transform enemyGuy1;
   [SerializeField] private Transform enemyGuy2;
   [SerializeField] private Transform enemyGuy3;
   [SerializeField] private Transform enemyGuy4;
   [SerializeField] private Transform enemyGuy5;
   [SerializeField] private Transform enemyGuy6;
   
   [Header("Stack Positions:")]
   [SerializeField] private Transform stackPosition1;
   [SerializeField] private Transform stackPosition2;
   [SerializeField] private Transform stackPosition3;
   [SerializeField] private Transform stackPosition4;
   [SerializeField] private Transform stackPosition5;
   [SerializeField] private Transform stackPosition6;
   
   [Header("Enemy Stack Positions:")]
   [SerializeField] private Transform enemyStackPosition1;
   [SerializeField] private Transform enemyStackPosition2;
   [SerializeField] private Transform enemyStackPosition3;
   [SerializeField] private Transform enemyStackPosition4;
   [SerializeField] private Transform enemyStackPosition5;
   [SerializeField] private Transform enemyStackPosition6;




   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.CompareTag("Guy1"))
      {
         guy1.GetComponent<Guy>().speed = 0;
         guy1.GetComponent<Animator>().SetTrigger("Kneel");
         guy1.transform.DOMove(stackPosition1.position, 0.5f);
         guy1.GetComponent<CapsuleCollider>().center = new Vector3(0, 1.73f, 0.35f);
         guy1.GetComponent<CapsuleCollider>().height = 2.08f;
         guy1.GetComponent<CapsuleCollider>().direction = 2;
         guy1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         guy1.DORotate(new Vector3(0, 0, 0), 0.5f);
      }
      else if (other.gameObject.CompareTag("Guy2"))
      {
         guy2.GetComponent<Guy>().speed = 0;
         guy2.GetComponent<Animator>().SetTrigger("Kneel");
         guy2.transform.DOMove(stackPosition2.position, 0.5f);
         guy2.GetComponent<CapsuleCollider>().center = new Vector3(0, 1.73f, 0.35f);
         guy2.GetComponent<CapsuleCollider>().height = 2.08f;
         guy2.GetComponent<CapsuleCollider>().direction = 2;
         guy2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         guy2.DORotate(new Vector3(0, 0, 0), 0.5f);
      }
      else if (other.gameObject.CompareTag("Guy3"))
      {
         guy3.GetComponent<Guy>().speed = 0;
         guy3.GetComponent<Animator>().SetTrigger("Kneel");
         guy3.transform.DOMove(stackPosition3.position, 0.5f);
         guy3.GetComponent<CapsuleCollider>().center = new Vector3(0, 1.73f, 0.35f);
         guy3.GetComponent<CapsuleCollider>().height = 2.08f;
         guy3.GetComponent<CapsuleCollider>().direction = 2;
         guy3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         guy3.DORotate(new Vector3(0, 0, 0), 0.5f);
      }
      else if (other.gameObject.CompareTag("Guy4"))
      {
         guy4.GetComponent<Guy>().speed = 0;
         guy4.GetComponent<Animator>().SetTrigger("Kneel");
         guy4.transform.DOMove(stackPosition4.position, 0.5f);
         guy4.GetComponent<CapsuleCollider>().center = new Vector3(0, 1.73f, 0.35f);
         guy4.GetComponent<CapsuleCollider>().height = 2.08f;
         guy4.GetComponent<CapsuleCollider>().direction = 2;
         guy4.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         guy4.DORotate(new Vector3(0, 0, 0), 0.5f);
      }
      else if (other.gameObject.CompareTag("Guy5"))
      {
         guy5.GetComponent<Guy>().speed = 0;
         guy5.GetComponent<Animator>().SetTrigger("Kneel");
         guy5.transform.DOMove(stackPosition5.position, 0.5f);
         guy5.GetComponent<CapsuleCollider>().radius = 0.30f;
         guy5.GetComponent<CapsuleCollider>().height = 2.60f;
         guy5.GetComponent<CapsuleCollider>().direction = 2;
         guy5.GetComponent<CapsuleCollider>().enabled = false;
         guy5.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         guy5.DORotate(new Vector3(0, 0, 0), 0.5f);
      }
      else if (other.gameObject.CompareTag("Guy6"))
      {
         guy6.GetComponent<Guy>().speed = 0;
         guy6.GetComponent<Animator>().SetTrigger("Kneel");
         guy6.transform.DOMove(stackPosition6.position, 0.5f);
         guy6.GetComponent<CapsuleCollider>().radius = 0.30f;
         guy6.GetComponent<CapsuleCollider>().height = 2.60f;
         guy6.GetComponent<CapsuleCollider>().direction = 2;
         guy6.GetComponent<CapsuleCollider>().enabled = false;
         guy6.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         guy6.DORotate(new Vector3(0, 0, 0), 0.5f);
      }
      
      
      
      else if (other.gameObject.CompareTag("EnemyGuy1"))
      {
         enemyGuy1.GetComponent<Guy>().speed = 0;
         enemyGuy1.GetComponent<Animator>().SetTrigger("Kneel");
         enemyGuy1.transform.DOMove(enemyStackPosition1.position, 0.5f);
         enemyGuy1.GetComponent<CapsuleCollider>().height = 1.8f;
         enemyGuy1.GetComponent<CapsuleCollider>().enabled = false;
         enemyGuy1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         enemyGuy1.DORotate(new Vector3(0, 0, 0), 0.5f);
      }
      else if (other.gameObject.CompareTag("EnemyGuy2"))
      {
         enemyGuy2.GetComponent<Guy>().speed = 0;
         enemyGuy2.GetComponent<Animator>().SetTrigger("Kneel");
         enemyGuy2.transform.DOMove(enemyStackPosition2.position, 0.5f);
         enemyGuy2.GetComponent<CapsuleCollider>().height = 1.8f;
         enemyGuy2.GetComponent<CapsuleCollider>().enabled = false;
         enemyGuy2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         enemyGuy2.DORotate(new Vector3(0, 0, 0), 0.5f);
      }
      else if (other.gameObject.CompareTag("EnemyGuy3"))
      {
         enemyGuy3.GetComponent<Guy>().speed = 0;
         enemyGuy3.GetComponent<Animator>().SetTrigger("Kneel");
         enemyGuy3.transform.DOMove(enemyStackPosition3.position, 0.5f);
         enemyGuy3.GetComponent<CapsuleCollider>().height = 1.8f;
         enemyGuy3.GetComponent<CapsuleCollider>().enabled = false;
         enemyGuy3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         enemyGuy3.DORotate(new Vector3(0, 0, 0), 0.5f);
      }
      else if (other.gameObject.CompareTag("EnemyGuy4"))
      {
         enemyGuy4.GetComponent<Guy>().speed = 0;
         enemyGuy4.GetComponent<Animator>().SetTrigger("Kneel");
         enemyGuy4.transform.DOMove(enemyStackPosition4.position, 0.5f);
         enemyGuy4.GetComponent<CapsuleCollider>().height = 1.8f;
         enemyGuy4.GetComponent<CapsuleCollider>().enabled = false;
         enemyGuy4.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         enemyGuy4.DORotate(new Vector3(0, 0, 0), 0.5f);
      }
      else if (other.gameObject.CompareTag("EnemyGuy5"))
      {
         enemyGuy5.GetComponent<Guy>().speed = 0;
         enemyGuy5.GetComponent<Animator>().SetTrigger("Kneel");
         enemyGuy5.transform.DOMove(enemyStackPosition5.position, 0.5f);
         enemyGuy5.GetComponent<CapsuleCollider>().height = 1.8f;
         enemyGuy5.GetComponent<CapsuleCollider>().enabled = false;
         enemyGuy5.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         enemyGuy5.DORotate(new Vector3(0, 0, 0), 0.5f);
      }
      else if (other.gameObject.CompareTag("EnemyGuy6"))
      {
         enemyGuy6.GetComponent<Guy>().speed = 0;
         enemyGuy6.GetComponent<Animator>().SetTrigger("Kneel");
         enemyGuy6.transform.DOMove(enemyStackPosition6.position, 0.5f);
         enemyGuy6.GetComponent<CapsuleCollider>().height = 1.8f;
         enemyGuy6.GetComponent<CapsuleCollider>().enabled = false;
         enemyGuy6.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         enemyGuy6.DORotate(new Vector3(0, 0, 0), 0.5f);
      }
      
   }
}
