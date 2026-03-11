public class CostResources
{
    public CostResources()
    {

    }

    public CostResources(decimal Wood, decimal Food, decimal Rock, decimal Peasants)
    {
        this.Wood = Wood;
        this.Food = Food;
        this.Rock = Rock;
        this.Peasants = Peasants;
    }

    public decimal Wood { get; set; }
    public decimal Food { get; set; }
    public decimal Rock { get; set; }
    public decimal Peasants { get; set; }
}
