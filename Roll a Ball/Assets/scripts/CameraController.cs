using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    public GameObject Came;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - Came.transform.position;
        transform.
    }

    void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        // Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //transform.AddForce(movement * speed);
        //transform.position = movement;
    }
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}