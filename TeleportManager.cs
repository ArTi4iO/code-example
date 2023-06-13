using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportManager : MonoBehaviour
{
    public int[] password = new int[] { 1, 1, 1 }; // Hasło do aktywacji teleportu, można zmienić
    [SerializeField] private int[] inputPassword = new int[3]; // Służy do identyfikacji w inspektorze Unity
    public GameObject teleport_1; // Dodać obiekt gry w inspektorze
    public GameObject teleport_2; // Dodać obiekt gry w inspektorze

    public void AddToInputPassword(int index, int value)
    {
        inputPassword[index - 1] = value;

        // Sprawdź, czy tablice password i inputPassword są zgodne
        bool isMatch = true;
        for (int i = 0; i < password.Length; i++)
        {
            if (password[i] != inputPassword[i])
            {
                isMatch = false;
                break;
            }
        }

        // Jeśli tablice są zgodne, wywołaj zdarzenie
        if (isMatch)
        {
            teleport_1.SetActive(true);
        }
    }
}
