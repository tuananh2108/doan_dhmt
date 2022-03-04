using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGold : MonoBehaviour
{
    public AudioSource coinFX;

    private void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        GoldScore.score += 1;
        //GameManager.inst.IncrementScore();

        this.gameObject.SetActive(false);
    }
}
