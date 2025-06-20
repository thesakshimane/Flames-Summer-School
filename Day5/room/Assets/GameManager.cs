using UnityEngine;
using UnityEngine.SceneManagement; // For scene management (restarting the game)

public class GameManager : MonoBehaviour
{
    public Score scoreScript; //reference to score script
    public GameObject startButton; // Reference to Start Button
    public PlayerMovement playerMovement; // Reference to PlayerMovement script
    private bool gameStarted = false; // Flag to check if the game has started

    void Start()
    {
        // Disable player movement at the start of the game
        playerMovement.enabled = false;
    }

    void Update()
    {
        // Check for 'S' key press or left mouse button click
        if (!gameStarted && (Input.GetKeyDown(KeyCode.S) || Input.GetMouseButtonDown(0)))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        // Enable player movement and hide the Start Button
        gameStarted = true; // Set game as started
        playerMovement.enabled = true;
        if (startButton != null)
        {
            startButton.SetActive(false); // Hide the Start Button if it exists
        }
        Debug.Log("Game Started");
    }

    public void EndGame()
    {
        Debug.Log("Game Over");
        scoreScript.DisplayGameOver();
        Invoke("Restart", 2f); // Wait for 2 seconds before restarting
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene
    }
}
