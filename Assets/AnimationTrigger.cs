using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public GameObject girlClone;
    public GameObject realGirl;
    public GameObject camera1;
    public GameObject camera2;
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
        realGirl.SetActive(false);
        girlClone.SetActive(true);
        camera1.SetActive(false);
        camera2.SetActive(true);
        
    }
}
