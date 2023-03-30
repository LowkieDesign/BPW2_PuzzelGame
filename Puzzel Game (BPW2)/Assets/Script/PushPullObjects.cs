using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPullObjects : MonoBehaviour
{

    [SerializeField] private float pushForce;
    private Rigidbody rb;

   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rb = hit.collider.attachedRigidbody;

        if (rb != null && Input.GetKey(KeyCode.E))
        {
            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();

            rb.AddForceAtPosition(forceDirection * pushForce, transform.position, ForceMode.Impulse);
        }
    }
}
