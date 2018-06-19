using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RememberConsumableState : MonoBehaviour {
    public bool wasConsumed = false;

    void Start () {
        if (wasConsumed) {
            Destroy(gameObject);
        }
    }
}
