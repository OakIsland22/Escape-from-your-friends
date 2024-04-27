using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Método para iniciar el programa y mostrar el menú principal
    public void StartProgram()
    {
        // Carga la escena del menú principal
        SceneManager.LoadScene("MainMenu");
    }

    // Método para seleccionar ventana (puede ser para cambiar opciones o seleccionar niveles)
    public void SelectWindow()
    {
        // Implementa la lógica para mostrar diferentes ventanas, como opciones o selección de nivel
    }

    // Método para iniciar la partida
    public void StartGame()
    {
        // Carga la pantalla del juego
        SceneManager.LoadScene("DemoScene");
    }

    // Método para cargar la pantalla del juego
    public void LoadGameScreen()
    {
        // Aquí puedes añadir una pantalla de carga si es necesario
    }

    // Método para mostrar UI post-carga con opciones
    public void ShowPostLoadUI()
    {
        // Muestra la UI con opciones como créditos, ajustes, etc.
    }

    // Método para preguntar si el jugador quiere volver
    public bool WantsToReturn()
    {
        // Implementa una lógica que permita al jugador decidir si quiere volver
        // Por ejemplo, mostrar un diálogo de confirmación y devolver la respuesta
        return false; // Esto es solo un placeholder
    }

    // Método para salir del juego
    public void Exit()
    {
        Application.Quit();
    }
}
