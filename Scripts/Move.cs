using UnityEngine;

public class Move : MonoBehaviour
{
    BoxCollider  GroundCheckCollider;
    FixedJoystick FixedJoystickOnCanvas;
    Rigidbody RigidBodyOfPlayer;
    float MovementSpeed = 10;
    float vertical, horizontal;
    float JumpHeight = 300;
    public bool OnGround = false;
    Camera PlayerCamera;
    
    void OnTriggerStay(Collider Col )
    {
        if (Col.tag == "ground") OnGround = true;
    }
    void OnTriggerExit(Collider Col)
    {
        if (Col.tag == "ground") OnGround = false;
    }
    void Start()
    {
        FixedJoystickOnCanvas = FindObjectOfType<FixedJoystick>();
        RigidBodyOfPlayer = GetComponent<Rigidbody>();
        GroundCheckCollider = GetComponent<BoxCollider>();
    }
    void Update()
    {
    }
    void FixedUpdate()
    {
        horizontal = FixedJoystickOnCanvas.Horizontal * MovementSpeed * Time.deltaTime;
        transform.Translate(horizontal, 0, 0);
        transform.Rotate(0, horizontal * 10, 0);

        vertical = FixedJoystickOnCanvas.Vertical * MovementSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }

    public void PressButtonJump()
    {
        if (OnGround) RigidBodyOfPlayer.AddForce(Vector3.up * JumpHeight);
    }


}
