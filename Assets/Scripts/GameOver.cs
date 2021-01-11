using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // ゲームオーバーシーンのボタン設定


    // リトライボタンを押したとき
    public void OnClickRetryButton()
    {
        SceneManager.LoadScene("MainScene");
    }
}
