using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RememberPlayerPosition : MonoBehaviour {
    public float timeToAutoSave = 5;

    void Start () {
        transform.position =
            JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("playerPosition"));
        StartCoroutine(_AutoSave());
    }

    void OnDestroy () {
        Remember();
    }

    public void Remember () {
        PlayerPrefs.SetString("playerPosition", JsonUtility.ToJson(transform.position));
    }
    
    // por si el juego crashea y no se ejecuta OnDestroy!
    private IEnumerator _AutoSave () { 
        yield return new WaitForSeconds(timeToAutoSave);
        Remember();
        StartCoroutine(_AutoSave());
    }
}
