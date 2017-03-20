using UnityEngine;
using UnitySampleAssets.CrossPlatformInput;
using System.Collections;

public class Player : MonoBehaviour {
    public GameObject player;
    public float moveSpeed = 2;
    private Vector3 MoveVector;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseInput = new Vector2(CrossPlatformInputManager.GetAxisRaw("Horizontal"), CrossPlatformInputManager.GetAxisRaw("Vertical"));
        //transform.localEulerAngles += new Vector3(mouseInput.y * 2, mouseInput.x * 2, 0);
        MoveVector = PoolInput();
        player.transform.Translate((MoveVector * moveSpeed * Time.deltaTime));
    }

    private Vector3 PoolInput()
    {
        Vector3 dir = Vector3.zero;
        dir.x = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        dir.z = CrossPlatformInputManager.GetAxisRaw("Vertical");

        //dir.x = joystick.Horizontal();
        //dir.z = joystick.Vertical();
        if (dir.magnitude > 1)
        {
            dir.Normalize();
        }
        return dir;
    }
}
