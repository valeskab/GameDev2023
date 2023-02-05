using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerMovementBehaviour : MonoBehaviour
{
    public Transform targetTable;
    public float speed = 2f;
    public float patience = 10.0f;
    private float timer;
    
    
    private void Start()
    {
        timer = patience;
    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetTable.position, step);

        if (Vector3.Distance(transform.position, targetTable.position) < 0.1f)
        {
            
        }

        else
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                Leave();
            }
        }
    }
    
    private void Leave()
    {
        Debug.Log("Customer left because they ran out of patience.");
    }
}
