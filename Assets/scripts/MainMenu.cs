using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Cambia "GameScene" por el nombre de tu escena de juego
        SceneManager.LoadScene("DemoScene");
    }

    public void OpenOptions()
    {
        // Aqu� puedes a�adir la l�gica para abrir el men� de opciones
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
