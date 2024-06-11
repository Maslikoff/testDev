using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPeasants : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            GivingPeasants enemyPeasants = other.GetComponent<GivingPeasants>();
            GivingPeasants playerPeasants = GetComponent<GivingPeasants>();
            if (enemyPeasants.peasantsList.Count > playerPeasants.peasantsList.Count)
            {
                Debug.LogError("YOU LOST!!!");
                gameObject.SetActive(false);
            }
            else if (enemyPeasants.peasantsList.Count < playerPeasants.peasantsList.Count)
            {
                Debug.Log("YOU WIN!!!");
                other.gameObject.SetActive(false);
            }
        }
    }
}
