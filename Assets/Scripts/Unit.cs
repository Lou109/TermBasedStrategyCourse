using UnityEngine;

public class Unit : MonoBehaviour
{
    Vector3 targetPosition;

    void Update()
    {
        float stoppingDistance = .1f;
        if (Vector3.Distance(transform.position, targetPosition) > stoppingDistance)
        {
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            float moveSpeed = 4f;
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Move(new Vector3(4, 0, 4));
        }
    }

        void Move(Vector3 targetPosition)
        {
            this.targetPosition = targetPosition;
        }

    }
