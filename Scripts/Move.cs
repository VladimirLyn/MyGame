using UnityEngine;

public class Move : MonoBehaviour
{
    public FixedJoystick FixedJoystickOnCanvas;
    public Rigidbody RigidBodyOfPlayer;
    readonly float  MovementSpeed = 10;
    float vertical, horizontal;
    readonly float JumpHeight = 300;
    public bool OnGround = false;

    private void Start()
    {
        RigidBodyOfPlayer = GetComponent<Rigidbody>();
    }

    void OnTriggerStay(Collider Col )
    {
        if (Col.tag == "ground") OnGround = true;
    }
    void OnTriggerExit(Collider Col)
    {
        if (Col.tag == "ground") OnGround = false;
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
