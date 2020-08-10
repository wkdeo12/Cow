using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState { Idle, Walk, Run, Attack, Eat, Die }

public class Player : LvUpCreature
{
    // Start is called before the first frame update
    public Animator animator;

    public PlayerState state = PlayerState.Idle;
    public VariableJoystick joystick;
    public Vector2 direction;
    public string currentStateString = "Idle";
    public Rigidbody rigidbody;
    public float speed = 0.3f;
    public Vector3 moveVector;
    public Vector3 quterVector;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetBool(currentStateString, false);
            currentStateString = "Run";
            animator.SetBool(currentStateString, true);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool(currentStateString, false);
            currentStateString = "Walk";
            animator.SetBool(currentStateString, true);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool(currentStateString, false);
            currentStateString = "Attack";
            animator.SetBool(currentStateString, true);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetBool(currentStateString, false);
            currentStateString = "Eat";
            animator.SetBool(currentStateString, true);
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            animator.SetBool(currentStateString, false);
            currentStateString = "Die";
            animator.SetBool(currentStateString, true);
        }
        if (joystick.push)
        {
            if (quterVector != Vector3.zero)
            {
                moveVector.x = direction.x * speed;
                moveVector.z = direction.y * speed;
                animator.SetBool("Run", true);
                rigidbody.MovePosition(transform.position + moveVector);

                rigidbody.MoveRotation(Quaternion.LookRotation(quterVector));
            }
        }
        else
        {
            animator.SetBool("Run", false);
        }
    }
}