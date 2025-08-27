using UnityEngine;
using TMPro;
public class HotDogDecorator : MonoBehaviour ,HotDogin
{
    public SoHotDog HotDogs;
    public int OgurecPrice;
    public int LuckPrice;
    public int Ogurez;
    public int Luck;
    public int VesLuck;
    public int VesOgurez;

    [SerializeField] private TextMeshProUGUI _textPrice;
    [SerializeField] private TextMeshProUGUI _textVes;

    private void Start()
    {
        UpdateText();
    }

    private void UpdateText()
    {
        _textPrice.text = HotDogs._hotDog.Cost.ToString();
        _textVes.text = HotDogs._hotDog.Gram.ToString();
    }
    public void GetOgurez()
    {
        HotDogs._hotDog.Cost += OgurecPrice;
        Ogurez++;
        HotDogs._hotDog.Gram += VesOgurez;
        UpdateText();
    }

    public void GetLuck()
    {
        HotDogs._hotDog.Cost += LuckPrice;
        Luck++;
        HotDogs._hotDog.Gram += VesLuck;
        UpdateText();
    }
}

public interface HotDogin
{
    public void PlusPrice(HotDog hot,int price)
    {
        hot.Cost += price;
    }
}
