using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MapGenerator : MonoBehaviour
{
    public GameObject[] mapObjectPrefab;
    //public string dataPath;
    private List<string[]> data = new List<string[]>();
    private string[][] mapData = new string[12][];
    public TextAsset textAsset;
    //public List<Dictionary<string, object>> data;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                GameObject ground = Instantiate(mapObjectPrefab[0]) as GameObject;
                ground.transform.position = new Vector3(i,0,j);
                ground.name = ground.tag + "(" + j + "," + i + ")";
                ground.transform.parent = GameObject.Find("Ground12x12").transform;
            }
        }

        LoadMapData(1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMapData(int stageNum)
    {
        //TextAsset textAsset = Resources.Load<TextAsset>("Lv1.csv");
        string[] lines = textAsset.text.Split('\n');
    

        for (int i = 0; i < 12; i++)
        {
            mapData[i] = lines[i].Split(",");
            for (int j = 0; j < 12; j++)
            {
                Debug.Log(mapData[i][j]);
               
            }
        }



    }
}
