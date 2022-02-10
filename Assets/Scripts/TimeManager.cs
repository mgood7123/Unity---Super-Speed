using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class TimeManager : MonoBehaviour
{
    [Header("Time")]
    public float player_speed = 1.0f;
    public float world_speed = 1.0f;
    public float SUPER_SPEED_VALUE = 0.01f;

    public StarterAssetsInputs _input;

    // Start is called before the first frame update
    void Start()
    {
        _input = GetComponent<StarterAssetsInputs>();
        Time.fixedDeltaTime = 0.08f;
    }

    // Update is called once per frame
    void Update()
    {
        if (_input.focus)
        {
            world_speed = SUPER_SPEED_VALUE;
        }
        else
        {
            world_speed = 1.0f;
        }

        Time.timeScale = world_speed;

        if (_input.super_speed)
        {
            player_speed = 1.0f / SUPER_SPEED_VALUE;
        }
        else
        {
            player_speed = 1.0f;
        }
    }
}
