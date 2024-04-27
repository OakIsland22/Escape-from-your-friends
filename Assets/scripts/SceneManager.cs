using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // M�todo para iniciar el programa y mostrar el men� principal
    public void StartProgram()
    {
        // Carga la escena del men� principal
        SceneManager.LoadScene("MainMenu");
    }

    // M�todo para seleccionar ventana (puede ser para cambiar opciones o seleccionar niveles)
    public void SelectWindow()
    {
        // Implementa la l�gica para mostrar diferentes ventanas, como opciones o selecci�n de nivel
    }

    // M�todo para iniciar la partida
    public void StartGame()
    {
        // Carga la pantalla del juego
        SceneManager.LoadScene("DemoScene");
    }

    // M�todo para cargar la pantalla del juego
    public void LoadGameScreen()
    {
        // Aqu� puedes a�adir una pantalla de carga si es necesario
    }

    // M�todo para mostrar UI post-carga con opciones
    public void ShowPostLoadUI()
    {
        // Muestra la UI con opciones como cr�ditos, ajustes, etc.
    }

    // M�todo para preguntar si el jugador quiere volver
    public bool WantsToReturn()
    {
        // Implementa una l�gica que permita al jugador decidir si quiere volver
        // Por ejemplo, mostrar un di�logo de confirmaci�n y devolver la respuesta
        return false; // Esto es solo un placeholder
    }

    // M�todo para salir del juego
    public void Exit()
    {
        Application.Quit();
    }
}
