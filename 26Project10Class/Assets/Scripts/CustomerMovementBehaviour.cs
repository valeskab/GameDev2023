using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerMovementBehaviour : MonoBehaviour
{
    public Transform targetTable;
    public float speed = 2f;

    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetTable.position, step);

        if (Vector3.Distance(transform.position, targetTable.position) < 0.1f)
        {
            
        }
    }
}
