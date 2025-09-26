using TMPro;
using UnityEngine;

public class ResourcesPanel : MonoBehaviour
{
    public TMP_Text WoodCounter;
    public TMP_Text FoodCounter;
    public TMP_Text RockCounter;
    public TMP_Text PeasantsCounter;

    public void UpdateResources(string wood, string food, string rock, string peasants)
    {
        WoodCounter.text = wood;
        FoodCounter.text = food;
        RockCounter.text = rock;
        PeasantsCounter.text = peasants;
    }

}
