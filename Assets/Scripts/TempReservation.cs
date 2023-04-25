using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempReservation : MonoBehaviour
{
    bool reserved = true;
    [SerializeField] GameObject[] walls = new GameObject[5];

    Color openColor = Color.green;
    Color resColor = Color.red;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < walls.Length; i ++)
        {
            walls[i].GetComponent<Material>().color = openColor;
        }
    }

    public void ReserveRoom()
    {

    }
}
