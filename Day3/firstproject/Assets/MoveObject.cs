using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Vertical");
        float v = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(h, 0, v);

        transform.Translate(movement * speed * Time.deltaTime);

    }
}
