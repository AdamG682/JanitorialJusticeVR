using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionManager : MonoBehaviour
{

    public GameObject leftRayTeleport;

    private TeleportationProvider _teleportationProvider;
    private ContinuousMoveProviderBase _continuousMoveProvider;
    
    void Start()
    {
        _teleportationProvider = GetComponent<TeleportationProvider>();
        _continuousMoveProvider = GetComponent<ContinuousMoveProviderBase>();
    }


    public void SwitchLocomotion(int locomotionValue)
    {
        if(locomotionValue == 0)
        {
            DisableContinuous();
            EnableTeleport();
        }
        else if (locomotionValue == 1)
        {
            EnableContinuous();
            DisableTeleport();
        }
    }

    private void DisableTeleport()
    {
        leftRayTeleport.SetActive(false);
        _teleportationProvider.enabled = false;
    }

    private void EnableTeleport()
    {
        leftRayTeleport.SetActive(true);
        _teleportationProvider.enabled = true;
    }

    private void DisableContinuous()
    {
        _continuousMoveProvider.enabled = false;
    }

    private void EnableContinuous()
    {
        _continuousMoveProvider.enabled = true;
    }

}
