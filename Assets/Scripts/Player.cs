using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform myTransform;
    public List<GameObject> flyList;

    private float playerPostition = 0f;
    private float leftRotation = 45f;
    private float rightRotation = -45f;

    private bool hasRotationLeft = true;
    private bool hasRotationRight = true;



    void Start()
    {
        myTransform = GetComponent<Transform>();
        flyList = new List<GameObject>();
    }

    void PlantRotation()
    {
        // CHECKS THE Z ROTATION VALUE
        myTransform.rotation = Quaternion.Euler(0, 0, playerPostition);

        // CHECKS MAXIMUM ROTATION LEFT
        if(playerPostition == 90)
        {
            hasRotationLeft = false;
        }
        else
        {
            hasRotationLeft = true;
        }

        // CHECKS MAXIMUM ROTATION RIGHT
        if (playerPostition == -90)
        {
            hasRotationRight = false;
        } 
        else
        {
            hasRotationRight = true;
        }
        
        // PLAYER ROTATE LEFT
        if (hasRotationLeft)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                myTransform.rotation = Quaternion.Euler(0, 0, playerPostition + leftRotation);
                playerPostition = playerPostition + leftRotation;
            }
        }

        // PLAYER ROTATE RIGHT
        if (hasRotationRight)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                myTransform.rotation = Quaternion.Euler(0, 0, playerPostition + rightRotation);
                playerPostition = playerPostition + rightRotation;
            }
        }
    }

    void PlantAttack()
    {
        if (playerPostition == 90)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
            }
        }
    }
    
    void Update()
    {
        PlantRotation();
        PlantAttack();
    }
}
