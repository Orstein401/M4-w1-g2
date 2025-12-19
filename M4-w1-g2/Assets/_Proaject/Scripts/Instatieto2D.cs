using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instatieto2D : MonoBehaviour
{
    [SerializeField] GameObject panelloPrefab;
    //righe colonne
    [SerializeField] private float rowLine;
    [SerializeField] private float colLine;
    //spazio tra le righe
    [SerializeField] private float spaceRow;
    [SerializeField] private float spaceCol;

    private void Start()
    {
        for (int i = 0; i < rowLine; i++)
        {
            for (int j = 0; j < colLine; j++)
            {
                GameObject panello = Instantiate(panelloPrefab, transform);
                panello.transform.position = new Vector3(gameObject.transform.position.x + spaceRow * i, gameObject.transform.position.y, gameObject.transform.position.z + spaceCol * j);
            }
        }

    }
}
