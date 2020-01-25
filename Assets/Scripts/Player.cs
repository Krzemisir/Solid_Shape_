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

    private float cooldown = 2f;
    private float attackStart = 0f;

    private bool canAttack = true;
    private bool canMove = true;
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
        if (Input.GetKeyDown(KeyCode.LeftArrow) && canMove)
        {
            if (hasRotationLeft)
            {
                myTransform.rotation = Quaternion.Euler(0, 0, playerRotationPosition + leftRotation);
                playerRotationPosition = playerRotationPosition + leftRotation;
            }
        }

        // PLAYER ROTATE RIGHT
        if (Input.GetKeyDown(KeyCode.RightArrow) && canMove)
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
        // PRESS SPACE TO ATTACK
        if (Input.GetKeyDown(KeyCode.Space) && canAttack)
        {
            // IF PLAYER HAS ROTATION VALUE 0
            if (playerRotationPosition == 0)
            {
                myTransform.position = flyThree.transform.position;
                canMove = false;
                canAttack = false;
            }

            // IF PLAYER HAS ROTATION VALUE 45
            if (playerRotationPosition == 45)
            {
                myTransform.position = flyTwo.transform.position;
                canMove = false;
                canAttack = false;
            }

            // IF PLAYER HAS ROTATION VALUE 90
            if (playerRotationPosition == 90)
            {
                myTransform.position = flyOne.transform.position;
                canMove = false;
                canAttack = false;
            }

            // IF PLAYER HAS ROTATION VALUE -45
            if (playerRotationPosition == -45)
            {
                myTransform.position = flyFour.transform.position;
                canMove = false;
                canAttack = false;
            }

            // IF PLAYER HAS ROTATION VALUE -90
            if (playerRotationPosition == -90)
            {
                myTransform.position = flyFive.transform.position;
                canMove = false;
                canAttack = false;
            }
        }

        if (!canAttack)
        {
            // STARTS THE COOLDOWN
            if (Time.time > attackStart + cooldown)
            {
                // RESETS POSITION AND ABLE TO ATTACK
                attackStart = Time.time;
                canMove = true;
                myTransform.position = playerPosition;
                canAttack = true;
            }
        }
    }
    
    void Update()
    {
        PlantRotation();
        PlantAttack();
    }
}
