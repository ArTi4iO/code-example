using System.Collections;
using UnityEngine;

public class Mortar : MonoBehaviour
{
    public const float LaunchDelay = 1.5f; // Opóźnienie przed strzałem
    public float LaunchForce = 30f; // Siła strzału

    private bool coroutineRunning = false; // Flaga wskazująca, czy korutyna jest już uruchomiona
    private bool waitForE = false; // Flaga oczekiwania na wciśnięcie klawisza E

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !coroutineRunning)
        {
            waitForE = true;
            StartCoroutine(WaitForEInput(other.gameObject));
        }
    }

    private IEnumerator WaitForEInput(GameObject player)
    {
        while (waitForE)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                waitForE = false;
                StartCoroutine(ShootAfterDelay(player));
            }
            yield return null;
        }
    }

    private Vector3 CalculateForceDirection(Transform transform)
    {
        // Pobranie wartości obrotu wokół osi Y obiektu
        float rotationY = transform.rotation.eulerAngles.y;

        // Przeliczenie kąta na radiany
        float radians = Mathf.Deg2Rad * rotationY;

        // Obliczenie wektora przy użyciu funkcji trygonometrycznych
        float x = Mathf.Sin(radians);
        float z = Mathf.Cos(radians);
        return new Vector3(x, 0f, z);
    }

    private IEnumerator ShootAfterDelay(GameObject player)
    {
        Debug.Log("Start korutyny dla wyrzutni");

        // Znalezienie obiektu "MortarBarrel"
        Transform barrel = transform.Find("MortarBarrel");
        if (barrel == null)
        {
            Debug.LogError("Nie znaleziono wyrzutni!");
            yield break;
        }

        Vector3 forceDirection = CalculateForceDirection(barrel);

        Vector3 targetDirection = forceDirection;
        targetDirection.y = 0f;

        Rigidbody playerRigidbody = player.GetComponent<Rigidbody>();
        if (playerRigidbody == null)
        {
            Debug.LogError("Nie znaleziono komponentu Rigidbody dla gracza!");
            yield break;
        }

        Transform playerTransform = player.transform;

        // Ustawienie rotacji gracza
        playerTransform.rotation = Quaternion.LookRotation(targetDirection, Vector3.up) * Quaternion.Inverse(barrel.rotation);

        // Ustawienie pozycji gracza
        playerTransform.position = barrel.position;

        yield return new WaitForSeconds(LaunchDelay);

        // Dodanie siły do gracza
        playerRigidbody.AddForce(LaunchForce * forceDirection, ForceMode.Impulse);

        // Zresetowanie rotacji gracza
        playerTransform.rotation = Quaternion.identity;

        yield return new WaitForSeconds(0.5f);

        coroutineRunning = false;

        Debug.Log("Koniec korutyny dla wyrzutni");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            waitForE = false;
            coroutineRunning = false;
        }
    }
}
