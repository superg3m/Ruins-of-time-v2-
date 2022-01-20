using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private UI_Inventory uiInventory;
    private Inventory inventory;
    private PlayerInput playerInput;
    private new Rigidbody2D rigidbody2D;
    private RollCoolDown rollCooldown;
    public int dashDistance = 5;
    public float _moveSpeed;

    private void Awake()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
        rollCooldown = GetComponent<RollCoolDown>();
        playerInput = GetComponent<PlayerInput>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rigidbody2D.velocity = new Vector2(playerInput.movementInput.x * _moveSpeed, playerInput.movementInput.y * _moveSpeed);
        // Checks what the player's last directional key was and sets dash respectively
        
    }
    private void Update()
    {
        if (playerInput.isRolling)
        {
            Debug.Log("working");
            if (playerInput.key == KeyCode.W) transform.position += new Vector3(playerInput.movementX, dashDistance, 0);

            else if (playerInput.key == KeyCode.A) transform.position += new Vector3(-dashDistance, playerInput.movementY, 0);

            else if (playerInput.key == KeyCode.S) transform.position += new Vector3(playerInput.movementX, -dashDistance, 0);

            else if (playerInput.key == KeyCode.D) transform.position += new Vector3(dashDistance, playerInput.movementY, 0);
        }
    }
}
