using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PlayerMove : MonoBehaviour
{
    //This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb; //
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    public float moveSpeed = 15;
    public float leftRightSpeed = 20;
    public float jumpSpeed = 50;


    float horizontalInput; //
    /*public float horizontalMultiplier = 2;*/

    //We mark this as "Fixed"Update because we are using it to mess with physics
    private void FixedUpdate()
    {
        /*Vector3 fowardMove = transform.forward * moveSpeed * Time.fixedDeltaTime; //
        Vector3 horizontalMove = transform.right * horizontalInput * leftRightSpeed * Time.fixedDeltaTime; //

        rb.MovePosition(rb.position + fowardMove); //*/

        //Add a forward force
        /*rb.AddForce(0, 0, forwardForce * Time.deltaTime);*/
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (rb.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (rb.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed);
            }
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (rb.position.y < LevelBoundary.jumpLimit)
            {
                transform.Translate(Vector3.up * Time.deltaTime * jumpSpeed);
            }
        }

    }

    void Update()
    {
        /*transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);*/
        /*if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed);
            }
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (this.gameObject.transform.position.y < LevelBoundary.jumpLimit)
            {
                transform.Translate(Vector3.up * Time.deltaTime * jumpSpeed);
            }
        }*/

        /*horizontalInput = Input.GetAxis("Horizontal"); //*/
    }
}
