using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter(Collision collisionInfo)
    {

        Debug.Log("We hit");
        //Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit the Obstacle");
            movement.enabled = false;
            gameManager.EndGame();
        }
    }
}
