using System;
using System.Collections;

using UnityEngine;
using UnityEngine.InputSystem;

public class ClickToMoveBehaviour : MonoBehaviour
{
    [SerializeField] private InputAction touchClickAction;

    private Camera mainCamera;
    private Coroutine coroutine;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    private void OnEnable()
    {
        touchClickAction.Enable();
        touchClickAction.performed += Move;
    }
    private void OnDisable()
    {
        touchClickAction.performed -= Move;
        touchClickAction.Disable();
    }

    private void Move(InputAction.CallbackContext context)
    {
        Ray ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
        if (Physics.Raycast(ray: ray, hitInfo: out RaycastHit hit) && hit.collider)
        {
            if (coroutine != null) StopCoroutine(coroutine);
            coroutine = StartCoroutine(PlayerMoveTowards(hit.point));
        }
    }

    private IEnumerator PlayerMoveTowards(Vector3 target)
    {
        while (Vector3)
        {
            
        }
    }
}
