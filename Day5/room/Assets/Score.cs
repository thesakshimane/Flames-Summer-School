using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    //// Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{

    //}

    public Transform player;
    public TextMeshProUGUI scoreText;
    public bool isGameStarted = false;
    private bool isGameOver = false;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position.z);
        //scoreText.text = player.position.z.ToString("0");

        if (isGameStarted)
        {
            scoreText.text = player.position.z.ToString("F1");
        }
        if (!isGameOver)
        {
            // Update the score text with the player's Z position
            scoreText.text = player.position.z.ToString("0");
        }
    }
    public void StartScore()
    {
        isGameStarted = true;
    }
    public void DisplayGameOver()
    {
        isGameOver = true; // Stop updating the score
        scoreText.text = "Game Over"; // Change the text to "Game Over"
    }
}
