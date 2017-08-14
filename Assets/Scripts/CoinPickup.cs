using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {
    int coinValue = 1;
    public Transform coinEffect;
    private void OnTriggerEnter(Collider info)
    {
        if (info.tag == "Player")
        {
            GameMaster.currentScore += coinValue;
            var effect = Instantiate(coinEffect, transform.position, transform.rotation);

            Destroy(effect.gameObject, 3);
            Destroy(gameObject);
        }
    }
}
