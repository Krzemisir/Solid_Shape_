using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiteAnimation : MonoBehaviour
{
    Animator plantAnimator;

    public void resetbool()
    {
        plantAnimator = gameObject.GetComponent<Animator>();
        if (plantAnimator.GetBool("isBiting"))
            {
                //Stop Animation
                plantAnimator.SetBool("isBiting", false);
                Debug.Log("Venus bites!");
            }
            else
            {
                //Start Animation
                plantAnimator.SetBool("isBiting", true);
                Debug.Log("Venus closes mouth...");
            }
    }
}