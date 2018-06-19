using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RememberCharacter : MonoBehaviour {
    public GameObject ingameCharacterPrototype;

    void Start () {
        DontDestroyOnLoad(this.gameObject);
    }
}
