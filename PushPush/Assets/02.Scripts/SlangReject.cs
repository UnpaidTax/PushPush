using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text.RegularExpressions;

public class SlangReject : MonoBehaviour
{
    static string patternSlang = "(개새|씨발|니애|느그애|허버)";
    public List<string> slangs;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < slangs.Count; i++)
        {
            string result = Regex.Replace(slangs[i], patternSlang, "**");
            Debug.Log(result);
        }
        Test(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 바보같이 만든 함수
    /// </summary>
    /// <param name="a"> a를 인수로 받음</param>
    public void Test(int a)
    {
        Debug.Log(a);
    }
}
