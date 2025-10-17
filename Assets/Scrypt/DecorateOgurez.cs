using UnityEngine;

public class DecorateOgurez : HotDogDecorator
{
    public int OgurecPrice;
    public int Ogurez;
    public int VesOgurez;
    public void GetOgurez()
    {
        HotDogs._hotDog.Cost += OgurecPrice;
        Ogurez++;
        HotDogs._hotDog.Gram += VesOgurez;
        UpdateText();
    }
}
