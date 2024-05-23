using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadingScreen1 : MonoBehaviour
{
    public GameObject loadingScreen;
    public TextMeshProUGUI victoryText;
    public AudioSource audioSource;
    public AudioClip victorySound;

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            yield return null;
        }
    }

    private void Update()
    {
        if (loadingScreen.activeSelf)
        {
            StartCoroutine(Desactivar());
        }
    }

    IEnumerator Desactivar()
    {
        yield return new WaitForSeconds(3);
        loadingScreen.SetActive(false);
        victoryText.gameObject.SetActive(true);
        victoryText.text = "¡Felicidades!Han Escapado del Cazador";
        audioSource.PlayOneShot(victorySound);
    }
}
