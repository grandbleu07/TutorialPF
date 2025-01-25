using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCoin : MonoBehaviour  // ctrl + r + r : 이름 바꾸기
{
    private Rigidbody2D rigid;
    public float PopPower = 2.5f;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>(); // 컴포넌트 찾아서 타입이 <Rigedbody2D>인 rigid변수에 할당
        rigid.AddForce(Vector2.up * PopPower, ForceMode2D.Impulse); // vector2.up 방향 힘을 가한다.

        Invoke(nameof(DisableObject), 1.5f); // 1.5s 뒤에 DisableObject 함수 실행
        Destroy(gameObject, 2f);             // gameObject 파괴, 2f 뒤에
    }

    private void DisableObject()
    {
        gameObject.SetActive(false); // 게임 오브젝트를 비활성화해라
    }
}
