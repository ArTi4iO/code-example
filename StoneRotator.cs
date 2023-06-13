using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneRotator : MonoBehaviour
{
    public float[] positions = { 0f, 120f, 240f };
    public float rotationSpeed = 30f;  // Prędkość obrotu kamienia
    public int indexStone = 0; // Indeks kamienia, musi być oryginalny do identyfikacji w Teleport Manager
    [SerializeField] private int positionIndex; // Indeks pozycji służy do identyfikacji pozycji w inspektorze Unity

    private bool inCollider = false;

    private void Update()
    {
        // Sprawdź, czy gracz jest w obszarze kolizji i czy naciśnięto klawisz E
        if (inCollider && Input.GetKeyDown(KeyCode.E))
        {
            Rotate();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Sprawdź, czy kolizja dotyczy gracza
        if (other.CompareTag("Player"))
        {
            inCollider = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Sprawdź, czy gracz opuścił obszar kolizji
        if (other.CompareTag("Player"))
        {
            inCollider = false;
        }
    }

    private void Rotate()
    {
        // Określ aktualny indeks pozycji na podstawie obrotu kamienia
        positionIndex = Mathf.RoundToInt(transform.eulerAngles.y / 120f);
        // Przejdź do kolejnego indeksu w tablicy pozycji
        positionIndex = (positionIndex + 1) % positions.Length;
        // Określ docelowy kąt obrotu
        float targetAngle = positions[positionIndex];

        StartCoroutine(RotateTo(targetAngle));

        // Pobierz komponent TeleportManager, który znajduje się w nadrzędnym obiekcie
        TeleportManager teleportManager = GetComponentInParent<TeleportManager>();
        // Przekazanie argumentów do metody AddToInputPassword
        teleportManager.AddToInputPassword(indexStone, positionIndex);
    }

    private IEnumerator RotateTo(float targetAngle)
    {
        float currentAngle = transform.eulerAngles.y;

        // Wykonuj obrót dopóki różnica między docelowym a aktualnym kątem jest większa niż 0.1f
        while (Mathf.Abs(targetAngle - currentAngle) > 0.1f)
        {
            currentAngle = Mathf.MoveTowardsAngle(currentAngle, targetAngle, rotationSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, currentAngle, transform.eulerAngles.z);
            yield return null;
        }

        transform.eulerAngles = new Vector3(transform.eulerAngles.x, targetAngle, transform.eulerAngles.z);
    }
}

