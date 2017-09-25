using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DanceActivity : IActivity
{

    public string GetActivityName()
    {
        return "Dance Battle";
    }

    public bool CalculateRequirements(List<SlotModel> slotItems)
    {
        if (!slotItems.Any(r => r.type == SlotType.PRACTICE_DANCE))
        {
            return false;
        }

        return true;
    }

    public bool CalculateActivity(List<Reel> reels)
    {
        int streak = 0;
        foreach (Reel reel in reels)
        {
            if (reel.currentSlotModel.type == SlotType.PRACTICE_DANCE)
            {
                streak++;
                if (streak >= 3)
                {
                    return true;
                }
            }
            else
            {
                streak = 0;
            }
        }
        return false;
    }
}
