using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move: MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;
    private float speed = 100.0f;
    public float gravity = 70.0f;
    public float jump = 60.0f;
    private bool isDead = false;
    public float verticalVelocity;
    public GameObject startMenu;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {    
    

        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
            { verticalVelocity = jump; }
        }
        else { verticalVelocity -= gravity * Time.deltaTime; }
        Vector3 moveVector = new Vector3(0, verticalVelocity, 0);
        controller.Move(moveVector * Time.deltaTime);

        //x left and right
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        }

        //y up and down
        moveVector.y = verticalVelocity;
        //z forward and backward
        moveVector.z = speed;


        if (Input.GetKey(KeyCode.Space)|| Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * jump);
        }


        controller.Move(moveVector * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) //orther collider của đối tượng mà player va chạm
    {
        if (other.gameObject.CompareTag("dead"))
        {
            Debug.Log("Dead");
            Death();
        }
        else Debug.Log("No");
    }
    private void Death()
    {
        isDead = true;
        SceneManager.LoadScene("lose");
    }

}
