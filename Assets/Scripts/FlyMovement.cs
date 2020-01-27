using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMovement : MonoBehaviour
{

    public GameObject fly1;
    public GameObject fly2;
    public GameObject fly3;
    public GameObject fly4;
    public GameObject fly5;
    public GameObject fly6;
    public GameObject fly7;
    public GameObject fly8;

    public GameObject emptyFly1;
    public GameObject emptyFly2;
    public GameObject emptyFly3;
    public GameObject emptyFly4;
    public GameObject emptyFly5;

    public int position;



    void Start()
    {
        position = Random.Range(6, 8);

        if (position == 6)
		{
			fly6.SetActive(true);
		}

		if (position == 7)
		{
			fly7.SetActive(true);
		}

		if (position == 8)
        {
            fly8.SetActive(true);
        }
    }

    void Update()
    {



    }
}
