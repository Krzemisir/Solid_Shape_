using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform myTransform;
    private BoxCollider2D myBoxCollider;
    private Rigidbody2D myRigidbody;
    private Vector3 playerPosition = new Vector3(0, -2, 0);

    public GameObject flyOne;
    public GameObject flyTwo;
    public GameObject flyThree;
    public GameObject flyFour;
    public GameObject flyFive;

    public AudioSource chompSound;

    public static bool deadFly = false;

    private float playerRotationPosition = 0f;
    private float leftRotation = 45f;
    private float rightRotation = -45f;

    private float cooldown = 2f;
    private float attackStart = 0f;

    //private bool hasAttacked = false;
    //private bool isHitting = true;
    private bool canAttack = true;
    private bool canMove = true;
    private bool hasRotationLeft = true;
    private bool hasRotationRight = true;

    Animator plantAnimator;

    void Start()
    {
        myTransform = GetComponent<Transform>();
        myBoxCollider = GetComponent<BoxCollider2D>();
        myRigidbody = GetComponent<Rigidbody2D>();
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

            // PLAYS ANIMATION

        }

        if (!canAttack)
        {
            // STARTS THE COOLDOWN
            if (Time.time > attackStart + cooldown)
            {
                // RESETS POSITION AND ABLE TO ATTACK
                attackStart = Time.time;

                canMove = true;
                canAttack = true;

                myTransform.position = playerPosition;
                
                //RESETS ANIMATION
                plantAnimator = gameObject.GetComponent<Animator>();
                plantAnimator.SetBool("isBiting", false);
                plantAnimator.SetBool("isMissing", false);
            }
        }
    }
    
    void Update()
    {
        PlantRotation();
        PlantAttack();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // SUCCESSFUL HIT
        if (other.gameObject.tag == "Fly")
        {
            Debug.Log("Fly dead");
            chompSound.Play(); 
            other.gameObject.SetActive(false);
            plantAnimator = gameObject.GetComponent<Animator>();
            plantAnimator.SetBool("isBiting", true);
        }

        // UNSUCCESSFUL HIT
        if (other.gameObject.tag == "Miss")
        {
            Debug.Log("You Missed MF");
            //Play Miss animation
            plantAnimator = gameObject.GetComponent<Animator>();
            plantAnimator.SetBool("isMissing", true);
            // ADD SOUND
        }
    }

}
