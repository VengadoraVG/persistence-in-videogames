using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RememberConsumableState : MonoBehaviour {
    public static int consumablesAmount = 0;

    public string id;
    public bool wasConsumed = false;

    void Start () {
        id = "fruit" + consumablesAmount;
        consumablesAmount++;

        if (PlayerPrefs.HasKey(id)) {
            wasConsumed = PlayerPrefs.GetInt(id) == 1;
        }

        if (wasConsumed) {
            Destroy(gameObject);
        }
    }

    public void Remember () {
        PlayerPrefs.SetInt(id, 1);
    }
}
