using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceLoader : Singleton<ResourceLoader>
{

    private Dictionary<string, GameObject> prefabMap = new Dictionary<string, GameObject>();
    private Dictionary<string, Sprite> spriteMap = new Dictionary<string, Sprite>();

    public GameObject defaultBlockFab;
    public Sprite slotCharm;
    public Sprite slotDance;
    public Sprite slotMusic;

    public Sprite prevMon;
    public Sprite prevTues;
    public Sprite prevWed;
    public Sprite prevThurs;
    public Sprite prevFri;

    public float tileSize;

    private Dictionary<SlotType, Sprite> spriteDict = new Dictionary<SlotType, Sprite>();

    protected override void Awake()
    {
        base.Awake();
        LoadResourceFolders();
        LoadResources();

        spriteDict.Add(SlotType.PRACTICE_CHARM, slotCharm);
        spriteDict.Add(SlotType.PRACTICE_DANCE, slotDance);
        spriteDict.Add(SlotType.PRACTICE_MUSIC, slotMusic);

        tileSize = slotCharm.bounds.size.x;
    }

    private void LoadResourceFolders()
    {
        GameObject[] prefabs = Resources.LoadAll<GameObject>("Prefabs/ResourceLoader");
        Sprite[] sprites = Resources.LoadAll<Sprite>("Textures/ResourceLoader");

        foreach (GameObject prefab in prefabs)
            prefabMap.Add(prefab.name, prefab);
        foreach (Sprite sprite in sprites)
            spriteMap.Add(sprite.name, sprite);
    }

    private void LoadResources()
    {
        slotCharm = Resources.Load<Sprite>("Textures/slotCharm");
        slotDance = Resources.Load<Sprite>("Textures/slotDance");
        slotMusic = Resources.Load<Sprite>("Textures/slotMusic");
    }

    public GameObject GetPrefab(string prefabName)
    {
        return prefabMap[prefabName];
    }

    public Sprite GetSprite(string spriteName)
    {
        return spriteMap[spriteName];
    }

    public Sprite GetSpriteForType(SlotType type)
    {
        return spriteDict[type];
    }
}
