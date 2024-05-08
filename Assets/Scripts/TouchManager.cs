using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
//using UnityEngine.Device;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    private Camera _mainCamera;
    private PlayerInput playerInput;

    private InputAction touchPositionAction;
    private InputAction touchPressAction;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        touchPressAction = playerInput.actions["TouchPress"];
        touchPositionAction = playerInput.actions["TouchPosition"];
        _mainCamera = Camera.main;
    }

    private void OnEnable()
    {
        touchPressAction.performed += TouchPressed;
    }

    private void OnDisable()
    {
        touchPressAction.performed -= TouchPressed;
    }

    private void TouchPressed(InputAction.CallbackContext context)
    {
        float value = context.ReadValue<float>();
        Debug.Log(value);

    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if(!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(pos:(Vector3)Mouse.current.position.ReadValue()));
        if((!rayHit.collider)) return;

        Debug.Log(rayHit.collider.gameObject.name);
    }
}
