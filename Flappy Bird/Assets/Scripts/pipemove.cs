using System.Diagnostics;
using UnityEngine;

public class pipemove : MonoBehaviour
{
    public float moveSpeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x < -10)
        {
            UnityEngine.Debug.Log("Pipe destroyed");
            Destroy(gameObject);
        }
    }
}
