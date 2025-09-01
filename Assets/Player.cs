using UnityEngine;
using UnityEngine.InputSystem; // 必要

public class Player : MonoBehaviour
{
    private Vector2 moveInput;
    public float speed = 5f;

    // Inspector から UnityEvent に登録される
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
        }
    }


    void Update()
    {
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        transform.Translate(move * speed * Time.deltaTime);
    }
}
