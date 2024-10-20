using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerScript : MonoBehaviour
{

    public float time;

    public GameObject[] miniaturas;

    bool hasTurnedOnMinis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 90 && !hasTurnedOnMinis)
        {
            encenderMiniaturas();
        }
    }

    public void encenderMiniaturas()
    {
        hasTurnedOnMinis = true;
        for (int i = 0; i<miniaturas.Length; i++)
        {
            miniaturas[i].SetActive(true);
        }
    }
}
