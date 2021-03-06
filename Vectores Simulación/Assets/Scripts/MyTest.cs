using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTest : MonoBehaviour
{
        [SerializeField] [Range(0,1)] float range;
        [SerializeField] MyVector first;
        [SerializeField] MyVector second;
        MyVector result;
        MyVector result2, result3;
    void Start()
    {
        //result = first.Add(second);
        //result3 = second.Add(result2);

        result = first + second;
        Debug.Log(first / 5);
    }

    private void Update()
    {
        /*float t = Time.deltaTime + range;
        range = Mathf.Clamp01(t);*/
        result3 = second.Lerp(first, range);
        result3.Draw(Color.magenta);
        first.Draw(Color.green);
        second.Draw(Color.red);
        result2 = second.Diff(first).Escalar(range);
        result2.Draw(Color.cyan);
        second.Draw(Color.yellow, result2);
    }
}
