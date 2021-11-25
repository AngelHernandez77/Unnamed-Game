using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rigidBody;
    private Vector3 change;
    private Animator movementAnim;

    // Start is called before the first frame update
    void Start()
    {
        //Alex movement
        if (PlayerPrefs.GetInt("selectedOption") == 0)
        {
            rigidBody = GetComponent<Rigidbody2D>();
            //Finish sprite animation for movement
        }

        //Leah
        else if (PlayerPrefs.GetInt("selectedOption") == 1)
        {
            movementAnim = GetComponent<Animator>();
            rigidBody = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //reset change
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

        if (PlayerPrefs.GetInt("selectedOption") == 0) 
        {
            moveCharacter();
        }

        else 
        {
            updateAnimationMovement();
        }
    }

    void updateAnimationMovement() 
    {
        if (change != Vector3.zero)
        {
            moveCharacter();

            //Animation part
            movementAnim.SetFloat("MoveX", change.x);
            movementAnim.SetFloat("MoveY", change.y);

            movementAnim.SetBool("moving", true);
        }

        else
        {
            movementAnim.SetBool("moving", false);
        }
    }

    void moveCharacter() 
    {
        //Movement logic .normalized makes it so that movement is the same if going diagonally when holding "up + left, up + righ, down + left,
        //and, down + right" 
        rigidBody.MovePosition(transform.position + change.normalized * playerSpeed * Time.deltaTime);
    }

    //Tutorial
    //https://www.youtube.com/watch?v=--N5IgSUQWI&t=43s&ab_channel=MisterTaftCreates
}
