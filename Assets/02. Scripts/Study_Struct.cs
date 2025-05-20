using JetBrains.Annotations;
using UnityEngine;

public class Study_Struct : MonoBehaviour
{
    public class Study_Class 
    {
        public int number;

        public Study_Class(int number)
        {
            this.number = number;
        }
    }

    public struct Study_Structs
    {
        public int number;

        public Study_Structs(int number)
        {
            this.number = number;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("클랴스-------------------------");
        Study_Class c1 = new Study_Class(10);
        Study_Class c2 = c1;
        c1.number = 20;
        Debug.Log($"c1 : {c1.number} / c2 : {c2.number}");

        Debug.Log("구조체-------------------------");
        Study_Structs s1 = new Study_Structs(10);
        Study_Structs s2 = s1;
        s1.number = 20;
        Debug.Log($"s1 : {s1.number} / s2 : {s2.number}");
    }

}
