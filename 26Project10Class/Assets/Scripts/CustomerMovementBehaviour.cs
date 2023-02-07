using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerMovementBehaviour : MonoBehaviour
{
    private bool isBeingDragged = false;
    private Vector3 offset;

    void Update()
    {
        if (isBeingDragged)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = mousePosition - offset;
        }
    }

    private void OnMouseDown()
    {
        isBeingDragged = true;
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseUp()
    {
        isBeingDragged = false;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("DropTarget"))
        {
            // Trigger event for dropping object onto target
        }
    }
}
