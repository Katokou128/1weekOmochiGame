using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject player;
    Vector3 mainYposition;
    Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
        mainYposition = mainCamera.transform.position; //メインカメラの最初のY軸の位置を保持
    }

    // Update is called once per frame
    void Update()
    {        
        Vector3 position = player.transform.position; // プレイヤーの位置をposition変数にいれる

        position.z = -10; // position変数のzを-10にする(カメラの位置を手前にする)
        position.y = mainYposition.y; // position変数のyを最初のメインカメラのY軸の高さにする

        mainCamera.transform.position = position; //カメラの位置をプレイヤーの位置にする

        
        if(position.x < 0.0075)
        {
            position.x = 0.0075f;
            mainCamera.transform.position = position;
        }
        
        if (position.x > 35.4)
        {
            position.x = 35.4f;
            mainCamera.transform.position = position;
        }
    }
}
