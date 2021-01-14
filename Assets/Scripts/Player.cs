using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rbody;
    AudioSource audioSource;

    public AudioClip jumpSE;
    public AudioClip getSE;

    float direction = 0f; //プレイヤーが移動する向き
    public float moveSpeed = 3f; //プレイヤーの移動スピード
    public float jump = 3f;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
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

        // ジャンプする時
        if (Input.GetKeyDown(KeyCode.Space) && rbody.velocity.y == 0)
        {
            rbody.AddForce(transform.up * jump);
            audioSource.PlayOneShot(jumpSE);
            //Debug.Log("ジャンプ");
        }


    }

    private void FixedUpdate()
    {
        //プレイヤーを動かす処理
        rbody.velocity = new Vector2(direction, rbody.velocity.y);
    }

    //おもちにぶつかった時の処理
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //普通のおもち
        if (collision.gameObject.tag == "Mochis")
        {
            //Debug.Log("おもち");
            PointManager.point += 10;
            audioSource.PlayOneShot(getSE);
            PointManager.clearPoint += 1;
            Destroy(collision.gameObject);
        }

        //海苔巻き
        if (collision.gameObject.tag == "NoriMochi")
        {
            //Debug.Log("おもち");
            PointManager.point += 20;
            audioSource.PlayOneShot(getSE);
            PointManager.clearPoint += 1;
            Destroy(collision.gameObject);
        }

        //顔もち
        if (collision.gameObject.tag == "KaoMochi")
        {
            //Debug.Log("おもち");
            PointManager.point += 30;
            audioSource.PlayOneShot(getSE);
            PointManager.clearPoint += 1;
            Destroy(collision.gameObject);
        }

        //膨れもち
        if (collision.gameObject.tag == "FatMochi")
        {
            //Debug.Log("おもち");
            PointManager.point += 40;
            audioSource.PlayOneShot(getSE);
            PointManager.clearPoint += 1;
            Destroy(collision.gameObject);
        }

        //きな粉もち
        if (collision.gameObject.tag == "KinakoMochi")
        {
            //Debug.Log("おもち");
            PointManager.point += 50;
            audioSource.PlayOneShot(getSE);
            PointManager.clearPoint += 1;
            Destroy(collision.gameObject);
        }

        //かしわもち
        if (collision.gameObject.tag == "KashiwaMochi")
        {
            //Debug.Log("おもち");
            PointManager.point -= 30;
            audioSource.PlayOneShot(getSE);
            Destroy(collision.gameObject);
        }

    }
}
