using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ConsumableCounter : MonoBehaviour {
    public Text text;
    public Consumer sourceOfInformation;

    void Update () {
        text.text = sourceOfInformation.consumed + "";
    }
}
