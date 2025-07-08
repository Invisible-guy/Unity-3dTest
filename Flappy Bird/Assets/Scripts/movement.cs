using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public float speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody2D.velocity = Vector2.up * speed;
        }
    }
}
