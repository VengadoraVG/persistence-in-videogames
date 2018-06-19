using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SelectionController : MonoBehaviour {
    public List<GameObject> availableCharacters;

    private int _current = 0;

    void Start () {
        _Select(_current);
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.A)) {
            Previous();
        } else if (Input.GetKeyDown(KeyCode.D)) {
            Next();
        }
    }

    private void _SetActive (GameObject thing, bool value) {
        thing.GetComponent<Animator>().SetBool("running", value);
        thing.transform.Find("arrow").gameObject.SetActive(value);
    }

    private void _Select (int index) {
        _SetActive(availableCharacters[_current], false);
        _current = index;
        _SetActive(availableCharacters[_current], true);

        GameObject.FindWithTag("GameController").
            GetComponent<RememberCharacter>().
            ingameCharacterPrototype = availableCharacters[_current].
            GetComponent<AvailableCharacter>().ingamePrototype;
    }

    public void Next () {
        _Select((_current + 1) % availableCharacters.Count);
    }

    public void Previous () {
        _Select(_current - 1 < 0? availableCharacters.Count-1: _current - 1);
    }
}
