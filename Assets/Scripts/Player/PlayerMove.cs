using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 moveVector;

    public float speedMove = 15f;
    public float leftRightSpeed = 20f;
    public float jumpPower = 30f;

    private bool isDead = false;
    public GameObject lostGame;

    public MonsterFollow monster;
    private float curDistance = 5.0f;
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        moveVector = Vector3.zero;
        lostGame.SetActive(false);
    }

    void Update()
    {
        monster.curDis = curDistance;
        if (isDead)
        {
            curDistance = 1.0f;
            monster.Follow(transform.position, speedMove);
            return;
        }

        // X - Trái và Phải
        moveVector.x = Input.GetAxisRaw("Horizontal") * leftRightSpeed;

        // Y - Trên và dưới
        if (characterController.isGrounded)
        {
            if (Input.GetKey(KeyCode.Space))
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
        monster.Follow(characterController.transform.position, speedMove);
    }

    //It is begin called every time our capsule hits something
    /*private void OnControllerColliderHit(ControllerColliderHit hit)
	{
        if (hit.point.z > transform.position.z + characterController.radius)
            Debug.Log("Dead");
		    *//*Death();*//*
	}*/

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
