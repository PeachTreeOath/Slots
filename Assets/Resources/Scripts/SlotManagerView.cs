using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManagerView : MonoBehaviour {

    private List<GameObject> slots = new List<GameObject>();

    public void CreateNewGlobalReel()
    {
        CleanUpReel();

        List<GameObject> newSlots = new List<GameObject>();

    }

    private void CleanUpReel()
    {
        foreach(GameObject slot in slots)
        {
            Destroy(slot);
        }
    }
}
