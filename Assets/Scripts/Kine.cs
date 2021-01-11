using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kine : MonoBehaviour
{
    // 敵キャラ（きね）のスクリプト

    Rigidbody2D rbody;
    public float moveSpeed = -3;
    public string player;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rbody.velocity = new Vector2(moveSpeed, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //ぶつかったら逆へ移動する
        if(collision.gameObject.name != player)
        {
            moveSpeed = -moveSpeed;
        }

        //移動している方向の向きに画像を合わせる
        if (moveSpeed > 0)
        {
            transform.localScale = new Vector3(-0.25f, 0.25f, 1);
        }
        else
        {
            transform.localScale = new Vector3(0.25f, 0.25f, 1);
        }

        // プレイヤーとぶつかったらシーン移動
        if(collision.gameObject.name == player)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
