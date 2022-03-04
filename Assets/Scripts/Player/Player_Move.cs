using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 moveVector;

    public float speedMove = 4.0f;
    public float leftRightSpeed = 5.0f;
    public float jumpPower = 50.0f;

    private bool isDead = false;
    public GameObject lostGame;
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        moveVector = Vector3.zero;
        lostGame.SetActive(false);
    }
    void Update()
    {
        if (isDead)
        {
            return;
        }
        // X - Trái và Phải
        //if (Object.transform)
        //{

        //}
            moveVector.x = Input.GetAxisRaw("Horizontal") * leftRightSpeed;
        // Y - Trên và dưới
        if (characterController.isGrounded)
        {
            if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W))
            {
                moveVector.y = jumpPower;
            }
        }
        else
        {
            moveVector.y -= jumpPower * 3 * Time.deltaTime;
        }

        // Z - Trước và sau
        moveVector.z = speedMove;
        characterController.Move(moveVector * Time.deltaTime * Time.timeScale);
    }

    private void OnTriggerEnter(Collider other) //orther collider của đối tượng mà player va chạm
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Dead");
            Death();
        }
        else Debug.Log("No");
    }
    private void Death()
    {
        isDead = true;
        lostGame.SetActive(true);
    }
}
//It is begin called every time our capsule hits something
/*private void OnControllerColliderHit(ControllerColliderHit hit)
{
    if (hit.point.z > transform.position.z + characterController.radius)
        Debug.Log("Dead");
        *//*Death();*//*
}*/