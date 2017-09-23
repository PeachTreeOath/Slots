using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceLoader : Singleton<ResourceLoader>
{
    [HideInInspector]
    public GameObject defaultBlockFab;
    [HideInInspector]
    public Sprite slotCharm;
    [HideInInspector]
    public Sprite slotDance;
    [HideInInspector]
    public Sprite slotMusic;
    [HideInInspector]
    public GameObject scrollBGFab;
    
    private Dictionary<SlotType, Sprite> spriteDict = new Dictionary<SlotType, Sprite>();

    protected override void Awake()
    {
        base.Awake();
        LoadResources();

        spriteDict.Add(SlotType.PRACTICE_CHARM, slotCharm);
        spriteDict.Add(SlotType.PRACTICE_DANCE, slotDance);
        spriteDict.Add(SlotType.PRACTICE_MUSIC, slotMusic);
    }

    private void LoadResources()
    {
        slotCharm = Resources.Load<Sprite>("Textures/slotCharm");
        slotDance = Resources.Load<Sprite>("Textures/slotDance");
        slotMusic = Resources.Load<Sprite>("Textures/slotMusic");

        scrollBGFab = Resources.Load<GameObject>("Prefabs/ScrollingBg");
    }

    public Sprite GetSpriteForType(SlotType type)
    {
        return spriteDict[type];
    }
}
