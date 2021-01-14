using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KineGameOver : MonoBehaviour
{

    //ゲームオーバーシーンのきねの音を出す
    public void AttackSE()
    {
        SoundGameOver.instance.PlaySE(SoundGameOver.SE.attack);
    }
}
