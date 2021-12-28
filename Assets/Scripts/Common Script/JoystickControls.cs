using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;

public class JoystickControls : MonoBehaviour
{

    [SerializeField] Machine machine;
    PlayerActions _playerActions = null;
    public Vector2 movement;
    [SerializeField] float moveSpeed = 1;
    [SerializeField] LayerMask layerMask;
    [SerializeField] float smoothing = .2f;
    public RaycastHit hit;
    [SerializeField] float machineHieght = 1;
    bool isRunning;
    void Awake()
    {
        _playerActions = new PlayerActions();

        _playerActions.TattooControls.Movement.performed += ctx => movement = ctx.ReadValue<Vector2>();
        _playerActions.TattooControls.Movement.canceled += ctx => movement = Vector2.zero;

        _playerActions.TattooControls.RunMachine.performed += cntxt => MachineFlip(cntxt);
        _playerActions.TattooControls.RunMachine.canceled += cntxt => MachineFlip(cntxt);
    }


    private void Update()
    {
        Vector2 move = new Vector2(movement.x, movement.y) * Time.deltaTime;
        transform.Translate(move * moveSpeed);
        if (isRunning) { RunMachine(); }
    }

    private void MachineFlip(InputAction.CallbackContext cntxt) { isRunning = cntxt.ReadValueAsButton(); }

    private void RunMachine()
    {
        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 100, layerMask))
        {
            if (transform != null) { transform.DOMove(hit.point, .2f); }
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
        }
        else
        {
            transform.DOMove(hit.point + (Vector3.up * machineHieght) + (-Vector3.forward * 2), smoothing);
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }


    private void OnEnable()
    {
        _playerActions.TattooControls.Enable();
    }

    private void OnDisable()
    {
        _playerActions.TattooControls.Disable();
    }
}
