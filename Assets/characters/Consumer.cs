using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Consumer : MonoBehaviour {
    public int consumed = 0;

    void OnTriggerEnter (Collider c) {
        consumed++;
    }
}
