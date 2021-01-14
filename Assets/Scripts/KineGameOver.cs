using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KineGameOver : MonoBehaviour
{
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void AttackSE()
    {
        audioSource.Play();
    }
}
