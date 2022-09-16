using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
/*
[RequireComponent(typeof(CharacterController))]
public class PlayerInputController : MonoBehaviour
{
    [SerializeField] [Range (0, 0)] private float movementSpeed;

    private CharacterController _characterController;
    private Vector2 _moveValue;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    public void Move(InputAction.CallbackContext context)
    {
        //Debug.Log("Move");
        _moveValue = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        var moveVector = new Vector3(_moveValue.x, 0, _moveValue.y);
        _characterController.Move(moveVector * movementSpeed);
    }
}*/