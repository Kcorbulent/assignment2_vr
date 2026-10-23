using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;
using Oculus.Interaction;
using Oculus.Interaction.Collections;

public class SandwichComponent : MonoBehaviour
{
    public Transform targetPuzzle;
    public bool isSolved;
    private Rigidbody rigidbody;
    private BoxCollider boxCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, targetPuzzle.position);
        if (distance < 0.05f && !isSolved)
        {
            IEnumerable<GrabInteractor> setInteractors = transform.GetChild(0).GetComponent<GrabInteractable>().Interactors;
            foreach (GrabInteractor interactor in setInteractors) { interactor.Unselect(); }
            transform.SetPositionAndRotation(targetPuzzle.position, targetPuzzle.rotation);
            targetPuzzle.gameObject.SetActive(false);
            rigidbody.constraints = RigidbodyConstraints.FreezeAll;
            boxCollider.enabled = false;
            isSolved = true;
            print("solved!");
        }
    }
}
