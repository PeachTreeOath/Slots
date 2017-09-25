using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotItemPreview : SlotItem {

    public SpriteRenderer border;
    public SpriteRenderer mon;
    public SpriteRenderer tues;
    public SpriteRenderer wed;
    public SpriteRenderer thurs;
    public SpriteRenderer fri;

    public void ToggleSelected(int reel, bool toggle)
    {
        switch(reel)
        {
            case 1:
                mon.enabled = toggle;
                break;
            case 2:
                tues.enabled = toggle;
                break;
            case 3:
                wed.enabled = toggle;
                break;
            case 4:
                thurs.enabled = toggle;
                break;
            case 5:
                fri.enabled = toggle;
                break;
        }

        if(mon.enabled || tues.enabled || wed.enabled || thurs.enabled || fri.enabled)
        {
            border.enabled = true;
        }
        else
        {
            border.enabled = false;
        }
    }
}
