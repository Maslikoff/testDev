using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GivingPeasants : MonoBehaviour
{
    public List<PeasantController> peasantsList;

    void Update()
    {
        for (int i = 0; i < peasantsList.Count; i++)
        {
            peasantsList[i].MoveTowardsPlayer(transform, i);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        PeasantController peasant = other.GetComponent<PeasantController>();
        if (peasant != null)
        {
            peasant.MoveTowardsPlayer(transform, 0);
            peasantsList.Add(peasant);
        }
    }
}
