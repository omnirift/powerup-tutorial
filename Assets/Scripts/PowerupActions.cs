using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupActions : MonoBehaviour
{
    [SerializeField]
    private PlayerController playerController;

    public void HighSpeedStartAction()
    {
        playerController.speed *= 2;
    }

    public void HighSpeedEndAction()
    {
        playerController.speed = playerController.defaultSpeed;
    }
}
