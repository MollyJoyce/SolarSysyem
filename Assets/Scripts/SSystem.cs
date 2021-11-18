using UnityEngine;
using System;

public class SSystem : MonoBehaviour {

    const float EarthTime = 100f;
[SerializeField]
        Transform MercPivot, VenPivot, EarPivot, MarsPivot, JupPivot, SatPivot, UranPivot, NepPivot;


    void Update () {
        TimeSpan time = DateTime.Now.TimeOfDay;

        MercPivot.localRotation = 
        Quaternion.Euler(0f, EarthTime/.24f * (float)time.TotalSeconds, 0f);

        VenPivot.localRotation = 
        Quaternion.Euler(0f, EarthTime/.61f * (float)time.TotalSeconds, 0f);

        EarPivot.localRotation = 
        Quaternion.Euler(0f, EarthTime * (float)time.TotalSeconds, 0f);

        MarsPivot.localRotation = 
        Quaternion.Euler(0f, EarthTime/1.88f * (float)time.TotalSeconds, 0f);

        JupPivot.localRotation = 
        Quaternion.Euler(0f, EarthTime/11.9f * (float)time.TotalSeconds, 0f);

        SatPivot.localRotation = 
        Quaternion.Euler(0f, EarthTime/29.4f * (float)time.TotalSeconds, 0f);

        UranPivot.localRotation = 
        Quaternion.Euler(0f, EarthTime/83.7f * (float)time.TotalSeconds, 0f);

        NepPivot.localRotation = 
        Quaternion.Euler(0f, EarthTime/163.7f * (float)time.TotalSeconds, 0f);
    }
}