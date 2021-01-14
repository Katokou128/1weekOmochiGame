using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundGameOver : MonoBehaviour
{
    //ゲームオーバーシーンとタイムアップシーンのBGMとSE

    public AudioSource bgmAudioSource;
    public AudioSource seAudioSource;

    public AudioClip bgm;
    public AudioClip[] seList;

    public enum SE
    {
        Button,
        attack,
    }

    public static SoundGameOver instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        PlayBgm();
    }

    public void PlayBgm()
    {
        bgmAudioSource.clip = bgm; // 音をセットする
        bgmAudioSource.Play();  // 再生する
    }

    public void PlaySE(SE se)
    {
        int index = (int)se;
        AudioClip clip = seList[index];
        seAudioSource.PlayOneShot(clip);
    }
}
