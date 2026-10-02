using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class S_SceneFloatAnim : MonoBehaviour
{
    [Tooltip("Height limits")]
    public Vector2 Range = new Vector2(0f, 1f);
    
    [Tooltip("Sets FloatSpeed")]
    public float FloatSpeed = 0.2f;

    public float LerpAnim = 0;
    
    [Tooltip("Changes Movent by Curve")]
    public AnimationCurve HeightCurve;
    
    //Called every frame the app is running
    // Note that "*" represents multiplication
    float startHeigth;

    public void Start()
    {
        startHeigth = transform.position.y;
    }

    void Update()
    {
        LerpAnim = (LerpAnim + (FloatSpeed * Time.deltaTime)) % 1;
        transform.position = new Vector3(transform.position.x, (startHeigth + (Mathf.Lerp(Range.x, Range.y,HeightCurve.Evaluate(LerpAnim)))), transform.position.z);
        //Change the rotation (by the defined orientation * the time that has passed * defined speed)
        //transform.Rotate(objectRotation * Time.deltaTime * rotateSpeed);
    }
}
