using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TempReservation : MonoBehaviour
{
    bool reserved = false;
    [SerializeField] GameObject[] walls = new GameObject[5];
    [SerializeField] TMP_Text resButtonTxt;
    [SerializeField] int roomNum;

    Color openColor = Color.green;
    Color resColor = Color.red;

    // Start is called before the first frame update
    void Start()
    {
        resButtonTxt.text = roomNum + " is not reserved";

        for (int i = 0; i < walls.Length; i ++)
        {
            walls[i].GetComponent<Renderer>().materials[0].color = openColor;
        }
    }

    public void ReserveRoom()
    {
        if(!reserved)
        {
            reserved = true;

            for (int i = 0; i < walls.Length; i++)
            {
                walls[i].GetComponent<Renderer>().materials[0].color = resColor;
            }

            resButtonTxt.text = roomNum + " is reserved";
        }
        else
        {
            reserved = false;

            for (int i = 0; i < walls.Length; i++)
            {
                walls[i].GetComponent<Renderer>().materials[0].color = openColor;
            }

            resButtonTxt.text = roomNum + " is not reserved";
        }
    }
}
