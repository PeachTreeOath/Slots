using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivityView : MonoBehaviour
{

    public IActivity activity;

    // Use this for initialization
    void Start()
    {
        GetComponentInChildren<Text>().text = activity.GetActivityName();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
