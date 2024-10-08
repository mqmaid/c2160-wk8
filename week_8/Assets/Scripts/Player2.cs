using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PLayerControls2 : MonoBehaviour
{
    [SerializeField] private float speed = 4;
    private Vector3 direction;
    private PlayerControls2 controls;
    private InputAction action;
    // Start is called before the first frame update

    void Awake()
    {
        controls = new PlayerControls2();
        action = controls.movement2.playerMovement2;
    }
    void Start()
    {
        action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        float x = action.ReadValue<Vector2>().x;
        float z = action.ReadValue<Vector2>().y;

        switch (x)
        {
            case < 0:
                direction.x = -1;
                break;
            case > 0:
                direction.x = 1;
                break;
            default:
                direction.x = 0;
                break;

        }

        switch (z)
        {
            case < 0:
                direction.z = -1;
                break;
            case > 0:
                direction.z = +1;
                break;
            default:
                direction.z = 0;
                break;
        }


        transform.Translate(speed * direction * Time.deltaTime);
    }

    void OnDisable()
    {
        action.Disable();
    }
}
