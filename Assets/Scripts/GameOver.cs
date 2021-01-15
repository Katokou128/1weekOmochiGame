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
        SoundGameOver.instance.PlaySE(SoundGameOver.SE.Button);
        SceneManager.LoadScene("MainScene");
    }

    // タイトルボタンを押したとき
    public void OnClickTitleButton()
    {
        SoundGameOver.instance.PlaySE(SoundGameOver.SE.Button);
        //Debug.Log("タイトルシーンへ");
        SceneManager.LoadScene("StartScene");
    }
}
