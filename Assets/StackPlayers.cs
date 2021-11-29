using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class StackPlayers : MonoBehaviour
{
   [SerializeField] private Transform guy1;
   [SerializeField] private Transform guy2;
   [SerializeField] private Transform guy3;
   [SerializeField] private Transform guy4;
   [SerializeField] private Transform guy5;
   [SerializeField] private Transform guy6;




   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.CompareTag("Guy1"))
      {
         guy1.GetComponent<Guy>().speed = 0;
         guy1.GetComponent<Animator>().SetTrigger("Kneel");
         guy1.transform.DOMove(new Vector3(-1, 0f, -5), 0.5f);
         guy1.GetComponent<CapsuleCollider>().height = 1.8f;
         guy1.GetComponent<CapsuleCollider>().enabled = false;
         guy1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         guy1.DORotate(new Vector3(0, 0, 0), 0.5f);
      }
      else if (other.gameObject.CompareTag("Guy2"))
      {
         guy2.GetComponent<Guy>().speed = 0;
         guy2.GetComponent<Animator>().SetTrigger("Kneel");
         guy2.transform.DOMove( new Vector3(-0.11f, 0f, -5), 0.5f);
         guy2.GetComponent<CapsuleCollider>().height = 1.8f;
         guy2.GetComponent<CapsuleCollider>().enabled = false;
         guy2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         guy2.DORotate(new Vector3(0, 0, 0), 0.5f);
      }
      else if (other.gameObject.CompareTag("Guy3"))
      {
         guy3.GetComponent<Guy>().speed = 0;
         guy3.GetComponent<Animator>().SetTrigger("Kneel");
         guy3.transform.DOMove(new Vector3(0.75f, 0f, -5), 0.5f);
         guy3.GetComponent<CapsuleCollider>().height = 1.8f;
         guy3.GetComponent<CapsuleCollider>().enabled = false;
         guy3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         guy3.DORotate(new Vector3(0, 0, 0), 0.5f);
      }
      else if (other.gameObject.CompareTag("Guy4"))
      {
         guy4.GetComponent<Guy>().speed = 0;
         guy4.GetComponent<Animator>().SetTrigger("Kneel");
         guy4.transform.DOMove(new Vector3(-0.11f, 1f, -5f), 0.5f);
         guy4.GetComponent<CapsuleCollider>().radius = 0.30f;
         guy4.GetComponent<CapsuleCollider>().height = 2.60f;
         guy4.GetComponent<CapsuleCollider>().direction = 2;
         guy4.GetComponent<CapsuleCollider>().enabled = false;
         guy4.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         guy4.DORotate(new Vector3(0, 0, 0), 0.5f);
      }
      else if (other.gameObject.CompareTag("Guy5"))
      {
         guy5.GetComponent<Guy>().speed = 0;
         guy5.GetComponent<Animator>().SetTrigger("Kneel");
         guy5.transform.DOMove(new Vector3(0.75f, 1f, -5f), 0.5f);
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
         guy6.transform.DOMove(new Vector3(0.75f, 1.75f, -5f), 0.5f);
         guy6.GetComponent<CapsuleCollider>().radius = 0.30f;
         guy6.GetComponent<CapsuleCollider>().height = 2.60f;
         guy6.GetComponent<CapsuleCollider>().direction = 2;
         guy6.GetComponent<CapsuleCollider>().enabled = false;
         guy6.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         guy6.DORotate(new Vector3(0, 0, 0), 0.5f);
      }
   }
}
