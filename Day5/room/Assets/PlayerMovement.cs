using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!");
        rb.useGravity = false;
        //rb.AddForce(0, 200, 500);
    }

    // Update is called once per frame
    //FixedUpdate instead of Update whenever you are usig physics

    void FixedUpdate()
    {
        // Debug.Log("no updates");
        //rb.AddForce(0, 0, 200);
        rb.AddForce(0, 0, 200 * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            //rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            //rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
