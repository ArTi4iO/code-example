using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal1toPortal2 : MonoBehaviour
{
    public GameObject portal2;

    private bool isTeleporting = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(StartTeleportation(other.gameObject));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StopCoroutine(StartTeleportation(other.gameObject));
            isTeleporting = false;
        }
    }

    IEnumerator StartTeleportation(GameObject player)
    {
        if (isTeleporting) yield break;

        isTeleporting = true;
        yield return new WaitForSeconds(3f);
        player.transform.position = portal2.transform.position;
        isTeleporting = false;
    }
}
