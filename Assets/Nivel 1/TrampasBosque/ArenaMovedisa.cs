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

        // realentiza al jugador al entrar en contacto con la arena movediza y cambia su posición en el eje y a -5

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Player_2_Movement player = other.GetComponent<Player_2_Movement>();
                player.speedPlayer = 1;
                player.transform.position = new Vector3(player.transform.position.x, -5, player.transform.position.z);
            }
        }



    }
}
