using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField]
    private GameObject palo;

    [Range(1, 5), SerializeField]
    private int number_of_palos;

    [SerializeField]
    private GameObject leftWall;

    [SerializeField]
    private GameObject rightWall;

    private Vector2 top_left = new Vector2(-5.0f, 5.0f);
    private Vector2 bottom_right = new Vector2(5.0f, -5.0f);


    // Start is called before the first frame update
    void Start()
    {
        SpawnObjects(number_of_palos);
    }

    // Update is called once per frame
    void SpawnObjects(int number_of_elements)
    {
        for (int i =0; i <= number_of_elements; i++)
        {
            Vector3 randomPos = new Vector3(Random.RandomRange(top_left.x, bottom_right.x),1.0f, Random.RandomRange(top_left.y, bottom_right.y));
            GameObject paloTemp = Instantiate(palo, randomPos, Quaternion.identity);
            paloTemp.GetComponent<TargetMovement>().SetReference(leftWall, rightWall);
        }
    }


}
