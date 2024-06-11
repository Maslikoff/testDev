using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeasantController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private float _distanceFromPlayer;

    public void MoveTowardsPlayer(Transform playerTransform, int peasantIndex)
    {
        _distanceFromPlayer = peasantIndex + 1;
        Vector3 targetPosition = playerTransform.position - playerTransform.forward * _distanceFromPlayer;
        transform.position = new Vector3(transform.position.x, 0.6f, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, _moveSpeed * Time.deltaTime);
        transform.LookAt(playerTransform);
    }
}
