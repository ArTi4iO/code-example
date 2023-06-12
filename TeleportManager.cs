using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportManager : MonoBehaviour
{
    public int[] password = new int[] { 1, 1, 1};
    [SerializeField] private int[] inputPassword = new int[3];
    public GameObject teleport_1;
    public GameObject teleport_2;


    public void AddToInputPassword(int index, int value)
    {
        inputPassword[index -1 ] = value;

        // ����������, �� ���������� ������ password �� inputPassword
        bool isMatch = true;
        for (int i = 0; i < password.Length; i++)
        {
            if (password[i] != inputPassword[i])
            {
                isMatch = false;
                break;
            }
        }

        // ���� ������ ����������, �� ��������� �����
        if (isMatch)
        {
            teleport_1.SetActive(true);
        }
    }
}
