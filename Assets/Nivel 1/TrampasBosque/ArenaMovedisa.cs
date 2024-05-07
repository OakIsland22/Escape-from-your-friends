using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArenaMovedisa : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player_2")) // Asegúrate de que tu personaje tenga la etiqueta "Player"
        {
            StartCoroutine(Sink(other.transform));
        }
    }

    private IEnumerator Sink(Transform player)
    {
        float sinkTime = 0.1f; // Tiempo que tarda en hundirse completamente
        float sinkRate = player.position.y / sinkTime; // Tasa de hundimiento por segundo

        while (sinkTime > 0)
        {
            player.position -= new Vector3(0, sinkRate * Time.deltaTime, 0); // Mueve al jugador hacia abajo
            sinkTime -= Time.deltaTime;
            yield return null;
        }

        // Aquí puedes agregar lo que sucede una vez que el jugador está completamente hundido
    }
}