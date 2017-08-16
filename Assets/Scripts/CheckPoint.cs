using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {
    public static Vector3 reachedPoint = new Vector3(2,0,0);

    public void OnTriggerEnter(Collider col)

    {
        if (col.tag == "Player")
        {
            if (transform.position.x > reachedPoint.x)
            {
                reachedPoint = transform.position;
            }
        }
    }
}
