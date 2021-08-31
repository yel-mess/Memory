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

    public Material[] materials;
    public ItemBehavior[] items; //liste d'itemBehavior
    private Dictionary <int, Material> itemMaterial = new Dictionary<int, Material>();

    // Start is called before the first frame update
    void Start()
    {
        items = new ItemBehavior[row * col];
        int index = 0;

        for(int x = 0; x < col; x++) {
            for(int z=0; z < row; z++) {
                Vector3 position = new Vector3(x*gapCol, 0, z*gapRow);
                GameObject item = Instantiate(itemPrefab, position, Quaternion.identity);
                items[index] = item.GetComponent<ItemBehavior>();
                items[index].id = index;
                items[index].manager = this;
                index++;
            }
        }
        
        GiveMaterials();
    }

    private void GiveMaterials() {
        List<int> possibilities = new List<int>();
        for(int i=0; i < row * col; i++) {
            possibilities.Add(i);
        }

        for (int i=0; i < materials.Length; i++) {
            if(possibilities.Count < 2) break;
            int idPos = Random.Range(0, possibilities.Count);
            int id1 = possibilities[idPos];
            possibilities.RemoveAt(idPos);

            idPos = Random.Range(0, possibilities.Count);
            int id2 = possibilities[idPos];
            possibilities.RemoveAt(idPos);

            itemMaterial.Add(id1, materials[i]);
            itemMaterial.Add(id2, materials[i]);
            items[id1].GetComponent<Renderer>().material = materials[i];
            items[id2].GetComponent<Renderer>().material = materials[i];
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
