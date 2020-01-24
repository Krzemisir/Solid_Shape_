using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXmanager : MonoBehaviour
{
    public AudioSource Fly1;
    public AudioSource Fly2;


    public void PlayFly1()
    {
        Fly1.Play();
    }

    public void PlayFly2()
    {
        Fly2.Play();
    }
}
