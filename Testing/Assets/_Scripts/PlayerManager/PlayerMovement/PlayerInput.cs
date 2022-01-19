using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private RollCoolDown rollCooldown;
    private KeyCode lastKey;
    public Vector2 movementInput { get; private set; }
    public KeyCode key { get; private set; }
    public bool inventoryIsOpen { get; private set; }
    public bool isRolling { get; private set; }
    public float movementX;
    public float movementY;

    private void Update()
    {
        InputProcessing();
    }
    private void Awake()
    {
        rollCooldown = GetComponent<RollCoolDown>();
    }

    private void InputProcessing()
    {
        #region Movement
        movementX = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        movementY = Input.GetAxisRaw("Vertical") * Time.deltaTime;
        movementInput = new Vector2(movementX, movementY).normalized;
        #endregion

        #region KeyInput
        // Checks what the player's last directional key was and sets dash respectively
        if (Input.GetKey(KeyCode.W)) lastKey = KeyCode.W;

        else if (Input.GetKey(KeyCode.S)) lastKey = KeyCode.S;

        else if (Input.GetKey(KeyCode.A)) lastKey = KeyCode.A;

        else if (Input.GetKey(KeyCode.D)) lastKey = KeyCode.D;

        key = lastKey;
        #endregion

        #region Roll
        if (Input.GetKeyDown(KeyCode.LeftShift) && !rollCooldown.onCooldown)
        {
            isRolling = true;
            rollCooldown.SetCooldown();
        }
        else
        {
            isRolling = false;
        }
        #endregion

        #region Inventory
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryIsOpen = true;
        }
        #endregion
    }
}
