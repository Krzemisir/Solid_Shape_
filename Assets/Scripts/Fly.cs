using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public Vector3 flyPos;

    void Start()
    {
        flyPos = transform.position;
        Debug.Log(flyPos);
    }

    void Update()
    {

    }
}
