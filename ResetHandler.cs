using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class ResetHandler
{
    private PlayerRespawner respawner;
    public ResetHandler(InputAction resetAction, PlayerRespawner respawner)
    {
        this.respawner = respawner;
        resetAction.performed += ResetAction_performed;
        resetAction.Enable();
    }

    private void ResetAction_performed(InputAction.CallbackContext obj)
    {
        respawner.Respawn();
    }
}
