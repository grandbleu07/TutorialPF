using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randombox : MonoBehaviour
{
    public GameObject CoinPrefab; // 코인 프리펩 사용하겠다
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("랜덤박스와 충돌.");

        Instantiate(CoinPrefab, transform.position, Quaternion.identity);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("랜덤박스와 충돌 끝");
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("랜덤박스와 충돌 중");
    }

}
