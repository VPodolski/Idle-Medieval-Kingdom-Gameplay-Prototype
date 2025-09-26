using UnityEngine;

public class ResourscesManager : MonoBehaviour
{
    public static ResourscesManager Instance;

    public decimal Wood { get; set; }
    public decimal Food { get; set; }
    public decimal Rock { get; set; }
    public decimal Peasants { get; set; }

    public decimal WoodProduction { get; set; }
    public decimal FoodProduction { get; set; }
    public decimal RockProduction { get; set; }
    public decimal PeasantsProduction { get; set; }


    void Start()
    {
        InvokeRepeating("Tick", 1f, 1f);
        UIManager.Instance.UpdateResources(Wood, Food, Rock, Peasants);
    }

    void Tick()
    {
        Wood += WoodProduction;
        Food += FoodProduction;
        Rock += RockProduction;
        Peasants += PeasantsProduction;

        UIManager.Instance.UpdateResources(Wood, Food, Rock, Peasants);
    }

    private void Awake()
    {
        Instance = this;

        Wood = 10;
        Food = 10;
        Rock = 10;
        Peasants = 10;

        WoodProduction = 0.1m;
        FoodProduction = 0.1m;
        RockProduction = 0.1m;
        PeasantsProduction = 0.1m;
    }

    public bool SpendResources(decimal wood, decimal food, decimal rock, decimal peasants)
    {
        var result = true;

        var isEnoughResources = Wood >= wood && Food >= food && Rock >= rock && Peasants >= peasants;

        if (isEnoughResources)
        {
            Wood -= wood;
            Food -= food;
            Rock -= rock;
            Peasants -= peasants;
        }
        else
        {
            result = false;
        }

        return result;
    }

    public void IncreaseProduction(decimal wood, decimal food, decimal rock, decimal peasants)
    {
        WoodProduction += wood;
        FoodProduction += food;
        RockProduction += rock;
        PeasantsProduction += peasants;
    }
}
