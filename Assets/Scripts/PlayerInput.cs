using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public InputAction dPadMvt;
    public CharacterController controller;
    public float templateSpeed = 3.14f;

    void OnEnable()
    {
        dPadMvt.Enable();
    }

    void OnDisable()
    {
        dPadMvt.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = dPadMvt.ReadValue<Vector2>();
        Debug.Log(dPadMvt.ReadValue<Vector2>().ToString());
        controller.Move(inputVector * Time.deltaTime * templateSpeed);
    }
}
