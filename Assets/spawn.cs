using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {
    public GameObject ship;

    // The Interval
    public float interval = 1;

    void Start() {
        InvokeRepeating("SpawnNext", interval, interval);
    }

    void SpawnNext () {
        Instantiate(ship, transform.position, Quaternion.identity);
    }
}
