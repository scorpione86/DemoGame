﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnHit : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        var enemy = transform.parent.GetComponentInParent<Enemy>();
        enemy.Die();
    }
}
