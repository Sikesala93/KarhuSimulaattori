using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject brownMushroomPrefab;

    [SerializeField] private GameObject poisonMushroomPrefab;

    private List<GameObject> brownMushRooms = new List<GameObject>();

    private List<GameObject> poisonMushRooms = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        int countOfBrownMushrooms = 400;

        for(int i = 0; i < countOfBrownMushrooms; i++)
        {
            GameObject newMushroom = Instantiate(brownMushroomPrefab);

            Vector3 uusiposition = new Vector3(Random.Range(-500f, 500), 100, Random.Range(-500f, 500));

            RaycastHit rh = new RaycastHit();
            if (Physics.Raycast(uusiposition, Vector3.down, out rh, 300))
                {
                uusiposition = rh.point;
                }

            newMushroom.transform.position = uusiposition;
            brownMushRooms.Add(newMushroom);
        }
        int countOfPoisonMushrooms = 300;

        for (int a = 0; a < countOfPoisonMushrooms; a++)
        {
            GameObject newMushroom = Instantiate(poisonMushroomPrefab);

            Vector3 uusiposition = new Vector3(Random.Range(-500f, 500), 100, Random.Range(-500f, 500));

            RaycastHit rh = new RaycastHit();
            if (Physics.Raycast(uusiposition, Vector3.down, out rh, 300))
            {
                uusiposition = rh.point;
            }

            newMushroom.transform.position = uusiposition;
            poisonMushRooms.Add(newMushroom);
        }

    }


    
}
