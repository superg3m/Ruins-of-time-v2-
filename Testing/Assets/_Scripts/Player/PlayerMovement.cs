using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _playerInput;
    private Rigidbody2D _rigidbody2D;
    private RollCoolDown _rollCooldown;
    public float _moveSpeed;

    private void Awake()
    {
        _rollCooldown = GetComponent<RollCoolDown>();
        _playerInput = GetComponent<PlayerInput>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(_playerInput.movementInput.x * _moveSpeed, _playerInput.movementInput.y * _moveSpeed);
        // Checks what the player's last directional key was and sets dash respectively
        
    }
    private void Update()
    {
        if (_playerInput.isRolling)
        {
            Debug.Log("working");
            if (_playerInput.key == KeyCode.W) transform.position += new Vector3(_playerInput.movementX, 5, 0);

            else if (_playerInput.key == KeyCode.A) transform.position += new Vector3(-5, _playerInput.movementY, 0);

            else if (_playerInput.key == KeyCode.S) transform.position += new Vector3(_playerInput.movementX, -5, 0);

            else if (_playerInput.key == KeyCode.D) transform.position += new Vector3(5, _playerInput.movementY, 0);
        }
    }
}
