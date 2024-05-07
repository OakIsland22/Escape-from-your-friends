using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshCollider))]
[RequireComponent(typeof(Rigidbody))]
public class ArenaMovedisa : MonoBehaviour
{
    void Start()
    {
        MeshCollider collider = gameObject.GetComponent<MeshCollider>();
        collider.convex = true;
        collider.isTrigger = true;

        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.isKinematic = true;
    }
}
