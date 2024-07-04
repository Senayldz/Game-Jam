using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class ControllerInput : MonoBehaviour
{
    public Vector2 MovementValue;
    public bool Jump;
    public Vector2 Look;

    public bool Esc;
    private InputAction lookAction;
    private PlayerInput playerInput;
    private InputAction moveAction;
    private InputAction jumpAction;

    private InputAction escAction;

    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();

        moveAction = playerInput.actions["Movement"];
        jumpAction = playerInput.actions["Jump"];
        lookAction = playerInput.actions["Look"];
        escAction = playerInput.actions["Esc"];
        
    }
    private void Update()
    {
        MovementValue = moveAction.ReadValue<Vector2>();
        Jump = jumpAction.IsPressed();
        Esc = escAction.IsPressed();
        Look = lookAction.ReadValue<Vector2>();
    }
}
