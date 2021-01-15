using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    // リトライボタンを押したとき
    public void OnClickRetryButton()
    {
        //SoundGameOver.instance.PlaySE(SoundGameOver.SE.Button);
        SceneManager.LoadScene("MainScene");
    }

    // タイトルボタンを押したとき
    public void OnClickTitleButton()
    {
        //SoundGameOver.instance.PlaySE(SoundGameOver.SE.Button);
        Debug.Log("タイトルシーンへ");
        SceneManager.LoadScene("StartScene");
    }
}
