using UnityEngine;

public class DecorateLuck : HotDogDecorator
{
    public int LuckPrice;
    public int Luck;
    public int VesLuck; 
    public void GetLuck()
    {
        HotDogs._hotDog.Cost += LuckPrice;
        Luck++;
        HotDogs._hotDog.Gram += VesLuck;
        UpdateText();
    }
}
