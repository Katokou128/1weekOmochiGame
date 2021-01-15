using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointManager : MonoBehaviour
{
    public static int point = default;
    public static int clearPoint = default;

    public int startPoint = 0;
    public Text pointText = default;


    // Start is called before the first frame update
    void Start()
    {
        pointText = GetComponent<Text>();
        point = startPoint; //ポイントの初期化
        clearPoint = startPoint; //クリアポイントの初期化
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = point.ToString();


        
        //かしわ以外のおもちを全て取った時はクリアシーンへ移動
        if(clearPoint >= 16)
        {
            Debug.Log("クリア！");
            SceneManager.LoadScene("ClearScene");
        }
        
    }
}
