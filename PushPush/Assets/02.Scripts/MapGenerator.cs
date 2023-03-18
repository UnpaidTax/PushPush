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

    public enum MapObject
    {
        ground = 0,
        wall = 1,
        bucket = 2,
        ball = 3,
        player = 4,
    }

    public MapObject mapObject;
    // Start is called before the first frame update
    void Start()
    {
        GenerateGround();
        LoadMapData(2);
        GenerateMap();


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
            //for (int j = 0; j < 12; j++)
            //{
            //    Debug.Log(mapData[i][j]);
               
            //}
        }
    }

    public void GenerateGround()
    {
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                GameObject ground = Instantiate(mapObjectPrefab[0]) as GameObject;
                ground.transform.position = new Vector3(i, 0, j);
                ground.name = ground.tag + "(" + j + "," + i + ")";
                ground.transform.parent = GameObject.Find("Ground12x12").transform;
            }
        }
    }

    public void GenerateMap()
    {
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                switch (mapData[i][j])
                {
                    case "0":
                        //그라운드는 이미 생성
                        break;
                    case "1":
                        GameObject wall = Instantiate(mapObjectPrefab[1]) as GameObject;
                        wall.transform.position = new Vector3(i, 1, j);
                        //ground.name = ground.tag + "(" + j + "," + i + ")";
                        wall.transform.parent = GameObject.Find("Ground12x12").transform;
                        break;
                    case "2":
                        GameObject bucket = Instantiate(mapObjectPrefab[2]) as GameObject;
                        bucket.transform.position = new Vector3(i, 1, j);
                        //ground.name = ground.tag + "(" + j + "," + i + ")";
                        bucket.transform.parent = GameObject.Find("Ground12x12").transform;
                        break;
                    case "3":
                        GameObject ball = Instantiate(mapObjectPrefab[3]) as GameObject;
                        ball.transform.position = new Vector3(i, 1, j);
                        //ground.name = ground.tag + "(" + j + "," + i + ")";
                        ball.transform.parent = GameObject.Find("Ground12x12").transform;
                        break;
                    case "4":
                        GameObject player = Instantiate(mapObjectPrefab[4]) as GameObject;
                        player.transform.position = new Vector3(i, 1, j);
                        //ground.name = ground.tag + "(" + j + "," + i + ")";
                        player.transform.parent = GameObject.Find("Ground12x12").transform;
                        break;
                }



            }
        }
    }
}
