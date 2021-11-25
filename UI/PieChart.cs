using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class PieChart : MonoBehaviour
{
    public Image[] Piechartimages;
    public float[] Values;
    // private float[] total;
    // Start is called before the first frame update
    void Start()
    {
        SetValues(Values);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetValues(float[] valuesTofloat)
    {
        float totalValues = 0;
        for (int i = 0; i <= Piechartimages.Length; i++)
        {
            //  Debug.Log(i + "svvv");
            totalValues += FindPercentage(valuesTofloat, i);
            Piechartimages[i].fillAmount = totalValues;
        }
    }

    private float FindPercentage(float[] valuesToSet, int index)
    {
        float totalAmount = 0;
        //Debug.Log(valuesToSet.Length + "scvghzsvcxh");
        for (int i = 0; i < valuesToSet.Length; i++)
        {

            totalAmount += valuesToSet[i];
            //Debug.Log(i + "ifpp");
        }
        // Debug.Log(valuesToSet[index] / totalAmount + "index" +  index);
        return valuesToSet[index] / totalAmount;
    }
}