using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float moveSpeed = 2.5f;
    public Transform playerStartPosition;
    private Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }


    // Start is called before the first frame update
    void Start()
    {
        transform.position = playerStartPosition.position;  // pc 초기 위치
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput_X = Input.GetAxisRaw("Horizontal");

        rigid.velocity = new Vector2(moveInput_X * moveSpeed, rigid.velocity.y);


        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigid.velocity = new Vector2(0, 10);
        }
    }
}
