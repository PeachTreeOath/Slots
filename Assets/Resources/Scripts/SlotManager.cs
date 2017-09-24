using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SlotManager : Singleton<SlotManager> {

    private List<SlotModel> slotItems = new List<SlotModel>();
    private List<Reel> reels = new List<Reel>();
    private System.Random rand;
    private SlotManagerView view;

    public void Init()
    {
        rand = new System.Random();
        GameObject viewObj = ResourceLoader.instance.GetPrefab("SlotManagerView");
        view = Instantiate(viewObj).GetComponent<SlotManagerView>();
        view.transform.SetParent(transform);
        view.Init();

        reels.Add(GameObject.Find("Reel1").GetComponent<Reel>());
        reels.Add(GameObject.Find("Reel2").GetComponent<Reel>());
        reels.Add(GameObject.Find("Reel3").GetComponent<Reel>());
        reels.Add(GameObject.Find("Reel4").GetComponent<Reel>());
        reels.Add(GameObject.Find("Reel5").GetComponent<Reel>());
    }

    public void AddModel(SlotModel slotModel)
    {
        slotItems.Add(slotModel);
    }

    public void ShuffleModels()
    {
        slotItems = slotItems.OrderBy(x => rand.Next()).ToList();
    }

    public void SpinReels()
    {
        foreach(Reel reel in reels)
        {
            int idx = rand.Next(0, slotItems.Count);
            reel.SetCurrentSlotModel(slotItems[idx]);
        }
    }

    public void CreateNewGlobalReel()
    {
        ShuffleModels();
        view.CreateNewGlobalReel(slotItems);
    }
}
