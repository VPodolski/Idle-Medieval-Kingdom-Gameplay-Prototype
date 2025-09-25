using UnityEngine;

public class ResourscesManager : MonoBehaviour
{
    public static ResourscesManager Instance;

    public decimal Wood { get; set; }
    public decimal Food { get; set; }
    public decimal Metal { get; set; }
    public decimal Peasants { get; set; }

    public decimal WoodProduction { get; set; }
    public decimal FoodProduction { get; set; }
    public decimal MetalProduction { get; set; }
    public decimal PeasantsProduction { get; set; }


    void Start()
    {
        InvokeRepeating("Tick", 1f, 1f);
    }

    void Tick()
    {
        Wood += WoodProduction;
        Food += FoodProduction;
        Metal += MetalProduction;
        Peasants += PeasantsProduction;

        Debug.Log("Wood: " + Wood);
        Debug.Log("Food: " + Food);
        Debug.Log("Metal: " + Metal);
        Debug.Log("Peasants: " + Peasants);
    }

    private void Awake()
    {
        Instance = this;

        Wood = 10;
        Food = 10;
        Metal = 10;
        Peasants = 10;

        WoodProduction = 0;
        FoodProduction = 0;
        MetalProduction = 0;
        PeasantsProduction = 0;
    }

    public bool SpendResources(decimal wood, decimal food, decimal metal, decimal peasants)
    {
        var result = true;

        var isEnoughResources = Wood >= wood && Food >= food && Metal >= metal && Peasants >= peasants;

        if (isEnoughResources)
        {
            Wood -= wood;
            Food -= food;
            Metal -= metal;
            Peasants -= peasants;
        }
        else
        {
            result = false;
        }

        return result;
    }

    public void IncreaseProduction(decimal wood, decimal food, decimal metal, decimal peasants)
    {
        WoodProduction += wood;
        FoodProduction += food;
        MetalProduction += metal;
        PeasantsProduction += peasants;
    }
}
