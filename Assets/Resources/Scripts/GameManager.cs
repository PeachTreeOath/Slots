using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InitSlotData();
	}

    private void InitSlotData()
    {
        SlotManager.instance.Init();
        SlotManager.instance.AddModel(new SlotModel(SlotType.PRACTICE_CHARM));
        SlotManager.instance.AddModel(new SlotModel(SlotType.PRACTICE_CHARM));
        SlotManager.instance.AddModel(new SlotModel(SlotType.PRACTICE_CHARM));
        SlotManager.instance.AddModel(new SlotModel(SlotType.PRACTICE_DANCE));
        SlotManager.instance.AddModel(new SlotModel(SlotType.PRACTICE_DANCE));
        SlotManager.instance.AddModel(new SlotModel(SlotType.PRACTICE_DANCE));
        SlotManager.instance.AddModel(new SlotModel(SlotType.PRACTICE_MUSIC));
        SlotManager.instance.AddModel(new SlotModel(SlotType.PRACTICE_MUSIC));
        SlotManager.instance.AddModel(new SlotModel(SlotType.PRACTICE_MUSIC));
        SlotManager.instance.ShuffleModels();
        SlotManager.instance.SpinReels();
        SlotManager.instance.CreateNewGlobalReel();
    }
}
