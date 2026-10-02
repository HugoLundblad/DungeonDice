using UnityEngine;

public class S_Dice : MonoBehaviour
{
    [System.Serializable] 
    public struct MyStruct
    { 
        public Component Side;
        public string AblityTag;
    }

    public MyStruct[] AllSides;
    public Component[] Sides;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
