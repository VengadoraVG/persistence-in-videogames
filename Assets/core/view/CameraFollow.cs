using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraFollow : MonoBehaviour {
    public GameObject target;
    public float sensitivity = 0.5f;

    void Update () {
        transform.position = target.transform.position;
        transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * sensitivity, 0);
    }
}
