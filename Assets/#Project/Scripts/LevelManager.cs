using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int row = 3; //nbr de lignes
    public int col = 4; //nbr de colonnes

    public float gapRow = 1.5f;
    public float gapCol = 1.5f;

    public GameObject itemPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for(int x = 0; x < col; x++)
            for(int z=0; z < row; z++) {
                Vector3 position = new Vector3(x*gapCol, 0, z*gapRow);
                GameObject item = Instantiate(itemPrefab, position, Quaternion.identity);
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
