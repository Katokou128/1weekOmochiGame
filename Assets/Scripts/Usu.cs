using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Usu : MonoBehaviour
{
    // 敵キャラ（うす）のスクリプト

    //Animator animator;
    Rigidbody2D rbody;
    AudioSource audioSource;

    public float moveSpeed = -3;　// 移動スピード
    public string player;        // プレイヤーの設定

    void Start()
    {
        // animator = GetComponent<Animator>(); // Animatorの取得
        rbody = GetComponent<Rigidbody2D>(); // Rigidbody2Dの取得
        audioSource = GetComponent<AudioSource>();

    }

    void Update()
    {
        rbody.velocity = new Vector2(moveSpeed, 0); // 移動の処理
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ぶつかったら逆へ移動する
        if (collision.gameObject.name != player)
        {
            moveSpeed = -moveSpeed;
        }

        // 移動している方向の向きに画像を合わせる
        if (moveSpeed > 0)
        {
            transform.localScale = new Vector3(-0.2f, 0.2f, 1); // 逆を向く
            // animator.SetTrigger("MoveChangeTrigger"); // アニメーターの変更
        }
        else
        {
            transform.localScale = new Vector3(0.2f, 0.2f, 1); // 逆を向く
            // animator.SetTrigger("MoveChangeTrigger"); // アニメーターの変更

        }

        // プレイヤーとぶつかったらシーン移動
        if (collision.gameObject.name == player)
        {
            audioSource.Play();
            Invoke("SceneChange", 0.15f);

        }
    }

    //シーン変更
    void SceneChange()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
