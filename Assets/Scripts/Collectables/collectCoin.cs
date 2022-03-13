using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectCoin : MonoBehaviour
{
    public AudioSource coinSound;
    void OnTriggerEnter(Collider other)
    {
        goldscore.score += 1;
        coinSound.Play();
        this.gameObject.SetActive(false);
    }
}
