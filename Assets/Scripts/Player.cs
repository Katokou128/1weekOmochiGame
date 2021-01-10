using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rbody;
    float direction = 0f; //プレイヤーが移動する向き
    public float moveSpeed = 3f; //プレイヤーの移動スピード

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 動いていない時
        direction = 0f;

        // 右に移動する時
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = moveSpeed;
            //Debug.Log("右移動");
        }

        // 左に移動する時
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = -moveSpeed;
            //Debug.Log("左移動");
        }


    }

    private void FixedUpdate()
    {
        //プレイヤーを動かす処理
        rbody.velocity = new Vector2(direction, rbody.velocity.y);
    }
}
