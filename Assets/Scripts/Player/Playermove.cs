using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Playermove : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed = 100f;
    public float LeftRightSpeed = 200;
    public float velocity;
    public float gravity = 80f;
    public float jump = 70.0f;

    private bool isDead = false;
  public GameObject startMenu;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            velocity = -gravity * Time.deltaTime;
            if(Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown(KeyCode.W))
            { velocity = jump; }
        }
        else { velocity -= gravity * Time.deltaTime; }
        Vector3 moveVector = new Vector3(0, velocity, 0);
        controller.Move(moveVector * Time.deltaTime);



        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * LeftRightSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.right * Time.deltaTime * LeftRightSpeed);
            }
        }

       if(Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime * jump);
        }


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
        //SceneManager.LoadScene("lose");
    }
}