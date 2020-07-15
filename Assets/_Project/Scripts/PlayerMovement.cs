using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController2D _characterController;
    [SerializeField] private float _moveSpeed = 40f;
    private float _horizontalMove;
    private bool _jump;

    private void Update()
    {
        _horizontalMove = Input.GetAxisRaw("Horizontal") * _moveSpeed; //right or d = 1 // left or a = -1
        if (Input.GetButtonDown("Jump"))
        {
            _jump = true;
        }
    }

    private void FixedUpdate()
    {
        _characterController.Move(_horizontalMove * Time.fixedDeltaTime, false, _jump);
        _jump = false;
    }
}

