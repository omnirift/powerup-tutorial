using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupBehaviour : MonoBehaviour
{
    #region Attributes

    #region Component References
    
    public PowerupController controller;

    [SerializeField]
    private Powerup powerup;

    private Renderer renderer_;

    private Transform transform_;

    public Material PowerupMaterial
    {
        get { return renderer_.material; }
        set { renderer_.material = value; }
    }

    #endregion

    private int rotationPerSecond = 180;

    #endregion

    #region Monobehaviour API

    private void Awake()
    {
        transform_ = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ActivatePowerup();
        }
    }

    #endregion

    private void ActivatePowerup()
    {
        controller.ActivatePowerup(powerup);
    }

    public void SetPowerup(Powerup powerup)
    {
        this.powerup = powerup;
        gameObject.name = powerup.name;
    }
}
