using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    public Transform playerStartPosition;
    private Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // �÷��̾ ������ �� ���� ������ ��ġ�� �̵��϶�.
        transform.position = playerStartPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        // �Է��� �޾ƿ;� �Ѵ�
        float moveInput_X = Input.GetAxisRaw("Horizontal");
        rigid.velocity = new Vector2(moveInput_X * moveSpeed, rigid.velocity.y);

        if(Input.GetKey(KeyCode.Space))
        {
            rigid.velocity = new Vector2(rigid.velocity.x, 7);
        }

        // �Է¿� �´� ������ �����ϴ� ��
        // ĳ���Ͱ� ����
        // �ð� �ӷ� ������ �Ÿ�
    }
}
