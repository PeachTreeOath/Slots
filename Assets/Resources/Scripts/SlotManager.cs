using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SlotManager : Singleton<SlotManager> {

    private List<SlotModel> items = new List<SlotModel>();
    private List<Reel> reels = new List<Reel>();
    private System.Random rand;

    void Start()
    {
        rand = new System.Random();

        reels.Add(GameObject.Find("Reel1").GetComponent<Reel>());
        reels.Add(GameObject.Find("Reel2").GetComponent<Reel>());
        reels.Add(GameObject.Find("Reel3").GetComponent<Reel>());
        reels.Add(GameObject.Find("Reel4").GetComponent<Reel>());
        reels.Add(GameObject.Find("Reel5").GetComponent<Reel>());
    }

    public void AddModel(SlotModel slotModel)
    {
        items.Add(slotModel);
    }

    public void ShuffleModels()
    {
        items = items.OrderBy(x => rand.Next()).ToList();
    }

    public void SpinReels()
    {
        foreach(Reel reel in reels)
        {
            int idx = rand.Next(0, items.Count);
            reel.SetCurrentSlotModel(items[idx]);
        }
    }
}
