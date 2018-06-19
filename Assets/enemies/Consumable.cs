using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Consumable : MonoBehaviour {
    void OnTriggerEnter (Collider c) {
        GetComponent<Animator>().SetTrigger("get eaten");
        GetComponent<Collider>().enabled = false; // se asegura de que solo lo puedan comer 1 vez
        StartCoroutine(_EventuallyDie());
    }

    private IEnumerator _EventuallyDie () {
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);
    }
}
