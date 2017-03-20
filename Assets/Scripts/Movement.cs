using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public GameObject monster;
    public float moveSpeed = 2;
    private Vector3 MoveVector=new Vector3(0,1,0);
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        monster.transform.position += Vector3.right * Time.deltaTime * moveSpeed;

        if (Input.GetKey(KeyCode.Q))
        {
            monster.transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        }
    }
}
