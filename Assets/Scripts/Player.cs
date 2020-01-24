using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform myTransform;
    private BoxCollider2D myBoxCollider;
    private Vector3 playerPosition = new Vector3(0, -2, 0);

    public GameObject flyOne;
    public GameObject flyTwo;
    public GameObject flyThree;
    public GameObject flyFour;
    public GameObject flyFive;

    private float playerRotationPosition = 0f;
    private float leftRotation = 45f;
    private float rightRotation = -45f;

    private bool hasRotationLeft = true;
    private bool hasRotationRight = true;

    void Start()
    {
        myTransform = GetComponent<Transform>();
        myBoxCollider = GetComponent<BoxCollider2D>();
    }

    void PlantRotation()
    {
        // CHECKS MAXIMUM ROTATION LEFT
        if (playerRotationPosition == 90)
        {
            hasRotationLeft = false;
        }
        else
        {
            hasRotationLeft = true;
        }

        // CHECKS MAXIMUM ROTATION RIGHT
        if (playerRotationPosition == -90)
        {
            hasRotationRight = false;
        }
        else
        {
            hasRotationRight = true;
        }

        // PLAYER ROTATE LEFT
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (hasRotationLeft)
            {
                myTransform.rotation = Quaternion.Euler(0, 0, playerRotationPosition + leftRotation);
                playerRotationPosition = playerRotationPosition + leftRotation;
            }
        }

        // PLAYER ROTATE RIGHT
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (hasRotationRight)
            {
                myTransform.rotation = Quaternion.Euler(0, 0, playerRotationPosition + rightRotation);
                playerRotationPosition = playerRotationPosition + rightRotation;
            }
        }
    }

    void PlantAttack()
    {
        //float cooldown = 2f;
        //float timeStamp = Time.time;

        if (Input.GetKeyDown(KeyCode.G))
        {
            myTransform.position = playerPosition;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (playerRotationPosition == 0)
            {
                myTransform.position = flyThree.transform.position;
                
            }

            if (playerRotationPosition == 45)
            {
                myTransform.position = flyTwo.transform.position;
                
            }

            if (playerRotationPosition == 90)
            {
                myTransform.position = flyOne.transform.position;
                
            }

            if (playerRotationPosition == -45)
            {
                myTransform.position = flyFour.transform.position;
                
            }

            if (playerRotationPosition == -90)
            {
                myTransform.position = flyFive.transform.position;
               
            }
        }
    }
    
    void Update()
    {
        PlantRotation();
        PlantAttack();
    }
}
