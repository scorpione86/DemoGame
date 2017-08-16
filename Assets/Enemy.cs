using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Rigidbody player;
    float bounceAmount = 6f;
    public Transform deathParticles;

    public void Die ()
    {
        player.velocity = new Vector3(player.velocity.x, bounceAmount, player.velocity.z);
        Instantiate(deathParticles, transform.position, transform.rotation);
        Destroy(gameObject);
        
    }
}
