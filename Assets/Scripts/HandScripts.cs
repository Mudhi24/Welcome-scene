using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandScripts : MonoBehaviour
{
    public InputActionProperty pinchAnim;

    public Animator handAnim;

    public InputActionProperty gripAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnim.action.ReadValue<float>();
        handAnim.SetFloat("Trigger", triggerValue);

        float gripValue = gripAnim.action.ReadValue<float>();
        handAnim.SetFloat("Grip", gripValue);

    }
}
