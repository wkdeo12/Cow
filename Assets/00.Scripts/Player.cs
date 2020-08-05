using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PlayerState { Idle, Walk, Run, Attack, Eat, Die }
public class Player : MonoBehaviour
{
    
    // Start is called before the first frame update
    public Animator animator;
    public PlayerState state = PlayerState.Idle;
    public VariableJoystick joystick;

    public string currentStateString = "Idle";
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

    }
}
