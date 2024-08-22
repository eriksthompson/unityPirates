using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

//Erik Thompson
public class FireHandler
{
    private CannonFire cannon;
    public FireHandler(InputAction fireAction, CannonFire cannon)
    {
        this.cannon = cannon;
        fireAction.performed += FireAction_performed;
        fireAction.Enable();
    }

    private void FireAction_performed(InputAction.CallbackContext obj)
    {
        cannon.Fire();
    }
}