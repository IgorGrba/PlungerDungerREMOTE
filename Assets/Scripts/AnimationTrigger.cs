using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public GameObject girlClone;
    public GameObject girl2Clone;
    public GameObject realGirl2;
    public GameObject realGirl;
    public GameObject camera1;
    public GameObject camera2;


    [SerializeField] private GameObject heartVisual;


    public GameObject line;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("StackTrigger"))
        {
            GameManager.instance.DecreaseItemCount();

            if (GameManager.instance.itemCount == -3)
            {
                Debug.Log("Completed");
                Invoke("ActivateCutscene", 2f);
            }
        }
    }


    void ActivateCutscene()
    {
        realGirl2.SetActive(false);
        realGirl.SetActive(false);
        girlClone.SetActive(true);
        girl2Clone.SetActive(true);
        camera1.SetActive(false);
        camera2.SetActive(true);
        line.SetActive(false);
        heartVisual.SetActive(false);
    }
}
