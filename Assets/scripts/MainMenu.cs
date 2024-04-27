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
        // Aquí puedes añadir la lógica para abrir el menú de opciones
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
