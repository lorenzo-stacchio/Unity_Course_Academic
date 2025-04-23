using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject Palo;

    [SerializeField]
    int PaloNumberToSpawn;

    float min_range = -10.0f;
    float max_range = 10.0f;
    [SerializeField]
    float offset_y = 5.0f;

    private void Start() { 
        SpawnPalos();
    }

    void SpawnPalos()
    {
        for (int i = 0; i < PaloNumberToSpawn; i++)
        {
            float new_x = Random.RandomRange(min_range, max_range);
            float new_z= Random.RandomRange(min_range, max_range);
            GameObject palo = Instantiate(Palo);
            palo.transform.position = new Vector3(new_x,this.transform.position.y + offset_y, new_z);      
        }

    }


}
