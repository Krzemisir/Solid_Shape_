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

    int position;
    bool waiting = false;

    public bool deadFly;



    IEnumerator Delay(int x) // wait for x seconds
    {
        yield return new WaitForSeconds(x);

        waiting = false;
    }

    void Start()
    {
        Time.timeScale = 1f;
        StartCoroutine(Delay(2));


        position = Random.Range(6, 8); //spawn the fly at a random position at top

        if (position == 6)
        {
            fly6.SetActive(true);
        }
        else if (position == 7)
        {
            fly7.SetActive(true);
        }
        else if (position == 8)
        {
            fly8.SetActive(true);
        }

    }

    void Update()
    {
        if (waiting == false) // the movement code is only being executed when the coroutine (the waiting time) is off
        {
            if (fly8.activeSelf == true) // check at what position is the fly and randomly move it to another position
            {
                position = Random.Range(1, 3);

                switch (position)
                {
                    case 1:
                        fly8.SetActive(false);
                        fly7.SetActive(true);
                        break;
                    case 2:
                        fly8.SetActive(false);
                        fly3.SetActive(true);
                        break;
                    case 3:
                        fly8.SetActive(false);
                        fly4.SetActive(true);
                        break;
                }

                waiting = true; //wait for 2s

                StartCoroutine(Delay(2));
            }
            else if (fly7.activeSelf == true)
            {
                position = Random.Range(1, 5);

                switch (position)
                {
                    case 1:
                        fly7.SetActive(false);
                        fly8.SetActive(true);
                        break;
                    case 2:
                        fly7.SetActive(false);
                        fly6.SetActive(true);
                        break;
                    case 3:
                        fly7.SetActive(false);
                        fly4.SetActive(true);
                        break;
                    case 4:
                        fly7.SetActive(false);
                        fly3.SetActive(true);
                        break;
                    case 5:
                        fly7.SetActive(false);
                        fly2.SetActive(true);
                        break;
                }

                waiting = true;

                StartCoroutine(Delay(2)); //wait for 2s
            }
            else if (fly6.activeSelf == true)
            {
                position = Random.Range(1, 3);

                switch (position)
                {
                    case 1:
                        fly6.SetActive(false);
                        fly7.SetActive(true);
                        break;
                    case 2:
                        fly6.SetActive(false);
                        fly3.SetActive(true);
                        break;
                    case 3:
                        fly6.SetActive(false);
                        fly2.SetActive(true);
                        break;
                }

                waiting = true;

                StartCoroutine(Delay(2)); //wait for 2s
            }
            else if (fly5.activeSelf == true)
            {
                position = Random.Range(1, 2);
                emptyFly5.SetActive(false);

                switch (position)
                {
                    case 1:
                        fly5.SetActive(false);
                        fly4.SetActive(true);
                        break;
                    case 2:
                        fly5.SetActive(false);
                        fly3.SetActive(true);
                        break;
                }

                waiting = true;
                StartCoroutine(Delay(2)); //wait for 2s

                emptyFly5.SetActive(true);

            }
            else if (fly4.activeSelf == true)
            {
                position = Random.Range(1, 4);
                emptyFly4.SetActive(false);

                switch (position)
                {
                    case 1:
                        fly4.SetActive(false);
                        fly3.SetActive(true);
                        break;
                    case 2:
                        fly4.SetActive(false);
                        fly5.SetActive(true);
                        break;
                    case 3:
                        fly4.SetActive(false);
                        fly7.SetActive(true);
                        break;
                    case 4:
                        fly4.SetActive(false);
                        fly8.SetActive(true);
                        break;
                }

                waiting = true;
                StartCoroutine(Delay(2)); //wait for 2s

                emptyFly4.SetActive(true);

            }
            else if (fly3.activeSelf == true)
            {
                position = Random.Range(1, 7);
                emptyFly3.SetActive(false);

                switch (position)
                {
                    case 1:
                        fly3.SetActive(false);
                        fly1.SetActive(true);
                        break;
                    case 2:
                        fly3.SetActive(false);
                        fly2.SetActive(true);
                        break;
                    case 3:
                        fly3.SetActive(false);
                        fly4.SetActive(true);
                        break;
                    case 4:
                        fly3.SetActive(false);
                        fly5.SetActive(true);
                        break;
                    case 5:
                        fly3.SetActive(false);
                        fly6.SetActive(true);
                        break;
                    case 6:
                        fly3.SetActive(false);
                        fly7.SetActive(true);
                        break;
                    case 7:
                        fly3.SetActive(false);
                        fly8.SetActive(true);
                        break;
                }

                waiting = true;
                StartCoroutine(Delay(2)); //wait for 2s

                emptyFly3.SetActive(true);

            }
            else if (fly2.activeSelf == true)
            {
                position = Random.Range(1, 4);
                emptyFly2.SetActive(false);

                switch (position)
                {
                    case 1:
                        fly2.SetActive(false);
                        fly1.SetActive(true);
                        break;
                    case 2:
                        fly2.SetActive(false);
                        fly3.SetActive(true);
                        break;
                    case 3:
                        fly2.SetActive(false);
                        fly6.SetActive(true);
                        break;
                    case 4:
                        fly2.SetActive(false);
                        fly7.SetActive(true);
                        break;
                }

                waiting = true;
                StartCoroutine(Delay(2)); //wait for 2s

                emptyFly2.SetActive(true);

            }
            else if (fly1.activeSelf == true)
            {
                position = Random.Range(1, 2);
                emptyFly1.SetActive(false);

                switch (position)
                {
                    case 1:
                        fly1.SetActive(false);
                        fly2.SetActive(true);
                        break;
                    case 2:
                        fly1.SetActive(false);
                        fly2.SetActive(true);
                        break;
                }

                waiting = true;
                StartCoroutine(Delay(2)); //wait for 2s

                emptyFly1.SetActive(true);

            }

        }
    }


}