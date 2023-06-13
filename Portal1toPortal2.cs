using System.Collections;
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
            // Jeśli gracz wyjdzie z portalu, zatrzymaj teleportację
            StopCoroutine(StartTeleportation(other.gameObject));
            isTeleporting = false;
        }
    }

    IEnumerator StartTeleportation(GameObject player)
    {
        // Sprawdź, czy teleporacja już się odbywa
        if (isTeleporting) yield break;

        isTeleporting = true;

        // Dodaj wiersz debugowania, aby wyświetlić rozpoczęcie teleporacji
        Debug.Log("Rozpoczęcie teleportacji");

        yield return new WaitForSeconds(3f);

        player.transform.position = portal2.transform.position;

        // Dodaj wiersz debugowania, aby wyświetlić zakończenie teleporacji
        Debug.Log("Zakończenie teleportacji");

        isTeleporting = false;
    }
}
