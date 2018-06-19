using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class PlayerControl : MonoBehaviour {
    public float targetDistance = 2;
    public Transform pointOfView;
    public GameObject characterPrototype;

    private NavMeshAgent _agent;
    private GameObject _character;
    private Animator _charAnimator;

    void Start () {
        characterPrototype = GameObject.FindWithTag("GameController").
            GetComponent<RememberCharacter>().ingameCharacterPrototype;

        _character = Instantiate(characterPrototype);
        _character.transform.parent = this.transform;
        _character.transform.localPosition = new Vector3(0,0,0);
        _character.transform.rotation = pointOfView.rotation;
        _charAnimator = _character.GetComponent<Animator>();
        _agent = GetComponent<NavMeshAgent>();
    }

    void Update () {
        Vector3 deltaTarget =
            (Input.GetAxis("Horizontal") * pointOfView.right +
             Input.GetAxis("Vertical") * pointOfView.forward).normalized
            * targetDistance;
        _agent.SetDestination(transform.position + deltaTarget);

        // hace que el bichito reproduzca la animación de caminar
        // cuando el jugador le ordena que camine :3
        _charAnimator.SetBool("running", deltaTarget.magnitude > 0);
    }
}
