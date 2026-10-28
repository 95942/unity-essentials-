using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Moves forward/backward and rotates with WASD/Arrow keys.
/// </summary>
public class playermover2d_scr : MonoBehaviour
{
[Tooltip("Forward/back speed (units/sec).")]
public float speed = 5.0f;

[Tooltip("Turn speed (degrees/sec).")]
public float rotationSpeed = 120.0f;

private Rigidbody2D rb;

private void Start()
{
rb = GetComponent<Rigidbody2D>();
if (rb == null) Debug.LogWarning("PlayerController needs a Rigidbody.");
}

private void FixedUpdate()
{
Vector2 moveInput = Vector2.zero;
// Forward/backward
if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) moveInput.y = 1f;
if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) moveInput.y = -1f;

// Left/right (rotation)
if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) moveInput.x = -1f;
if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)moveInput.x = 1f;


}
}
