using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputBroadcaster : MonoBehaviour
{
    private Camera _mainCamera;
    public bool IsTapPressed {get; private set;} = false;
    private void Awake()
    {
        _mainCamera = Camera.main;   
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            IsTapPressed = true;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            IsTapPressed = false;
        }
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if(!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(pos:(Vector3)Mouse.current.position.ReadValue()));
        if((!rayHit.collider)) return;

        Debug.Log(rayHit.collider.gameObject.name);
    }
}
