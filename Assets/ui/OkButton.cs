using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class OkButton : MonoBehaviour {
    public void StartGame () {
        SceneManager.LoadScene("game");
    }
}
