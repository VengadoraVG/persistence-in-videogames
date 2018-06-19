using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Consumer : MonoBehaviour {
    public int consumed = 0;

    void Start () {
        if (PlayerPrefs.HasKey("fruits")) {
            consumed = PlayerPrefs.GetInt("fruits");
        } else {
            consumed = 0;
        }
    }

    public void Remember () {
        PlayerPrefs.SetInt("fruits", consumed);
    }

    void OnTriggerEnter (Collider c) {
        consumed++;
        Remember();
    }
}
