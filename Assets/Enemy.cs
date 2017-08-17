using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Rigidbody player;
    float bounceAmount = 6f;
    public Transform deathParticles;
    public Animator enemyAnim;
    private Animator centerAnim;
    public Transform colliders;

    private void Awake()
    {
        centerAnim = transform.GetComponent<Animator>();
    }

    private void Start()
    {
        
    }
    public void Die ()
    {
        player.velocity = new Vector3(player.velocity.x, bounceAmount, player.velocity.z);
        Instantiate(deathParticles, enemyAnim.transform.position, enemyAnim.transform.rotation);
        enemyAnim.SetTrigger("Die");
        centerAnim.SetTrigger("Stop");
        Destroy(colliders.gameObject);
        //Destroy(gameObject);

        
    }
}
