using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RememberCharacter : MonoBehaviour {
    public static bool created = false;

    public GameObject ingameCharacterPrototype;

    void Start () {
        if (!created) {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
    }
}
