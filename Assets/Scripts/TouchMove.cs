using UnityEngine;
using System.Collections;

public class TouchMove : MonoBehaviour {
    public GameObject player;
    // Use this for initialization
    public static int movespeed = 1;
    public Vector3 userDirection;
    public void  Start()
    {
    }
    public void Update()
    {
        if (Input.touchCount > 0)
        {
        userDirection = player.transform.forward;
        player.transform.Translate(userDirection * movespeed * Time.deltaTime);
        }
    }
}
