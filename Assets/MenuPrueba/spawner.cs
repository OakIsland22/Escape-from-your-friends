using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public List<GameObject> objectsToSpawn; // Lista de GameObjects que quieres spawnear
    private int currentIndex = 0; // Índice del último GameObject spawnado

    public float spawnIntervalDes = 5f; // Intervalo entre spawns
    public float spawnInterval = 2f; // Intervalo entre spawns
    private float spawnTimer = 0f; // Temporizador para el próximo spawn

    public GameObject spawnere;

    public int spawne = 0;

    private void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnInterval && spawne <= 2)
        {
            SpawnObject();
            spawnTimer = 0f;
            spawne += 1;
        }

        if(spawnTimer >= spawnIntervalDes && spawne >= 2)
        {
            gameObject.SetActive(false);
            spawnere.SetActive(true);
            spawne= 0;
            spawnTimer = 0f;
        }
    }

    private void SpawnObject()
    {
        // Instancia el objeto actual en la posición del spawner
        GameObject spawnedObject = Instantiate(objectsToSpawn[currentIndex], transform.position, Quaternion.identity);

        // Obtiene la rotación actual del spawner
        Quaternion spawnerRotation = transform.rotation;

        // Aplica la rotación del spawner al objeto spawnado
        spawnedObject.transform.rotation = spawnerRotation;

        // Avanza al siguiente índice en la lista
        currentIndex = (currentIndex + 1) % objectsToSpawn.Count;
    }

}