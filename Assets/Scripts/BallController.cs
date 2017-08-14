using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public float rotationSpeed = 100;
    public Rigidbody rb;

    public float jumpHeight = 8;
    public float distToGround;

    public AudioClip Hit01;
    public AudioClip Hit02;
    public AudioClip Hit03;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        distToGround = GetComponent<Collider>().bounds.extents.y;
    }

    // Check if is on the ground
    public bool isGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
    }
    void Update () {

        // Handle ball rotation
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        //float rotation2 = Input.GetAxis("Vertical") * rotationSpeed;
        rotation *= Time.deltaTime;
        //rotation2 *= Time.deltaTime;

        rb.AddRelativeTorque(Vector3.back * rotation);
        //rb.AddRelativeTorque(Vector3.right * rotation2);


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded() == true)
        {

            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        }
	}

    public void OnCollisionEnter()
    {
        int theHit = Random.Range(0, 3);
        if (theHit == 0)
        {
            GetComponent<AudioSource>().clip = Hit01;
        }
        else if (theHit == 1)
        {
            GetComponent<AudioSource>().clip = Hit02;
        }
        else
        {
            GetComponent<AudioSource>().clip = Hit03;
        }
        GetComponent<AudioSource>().pitch = Random.Range(.9f, 1.1f);
        GetComponent<AudioSource>().Play();
    }

}
