using System.Collections.Generic;

public interface IActivity {

    string GetActivityName();

    bool CalculateRequirements(List<SlotModel> slotItems);

    bool CalculateActivity(List<Reel> reels);

}
