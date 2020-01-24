using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    private Transform flyTransform;

    void Start()
    {
        flyTransform = GetComponent<Transform>();
    }

    void FlyPosition()
    {

    }


    void Update()
    {
        FlyPosition();
    }
}
