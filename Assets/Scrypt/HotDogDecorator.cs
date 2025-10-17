using UnityEngine;
using TMPro;
public class HotDogDecorator : MonoBehaviour ,HotDogin
{
    public SoHotDog HotDogs;
    

    [SerializeField] private TextMeshProUGUI _textPrice;
    [SerializeField] private TextMeshProUGUI _textVes;

    private void Start()
    {
        UpdateText();
    }

    public void UpdateText()
    {
        _textPrice.text = HotDogs._hotDog.Cost.ToString();
        _textVes.text = HotDogs._hotDog.Gram.ToString();
    }
   

   

    public void PlusPrice(HotDog hot, int price)
    {
        hot.Cost += price;
    }
        
}

public interface HotDogin
{
    public void PlusPrice(HotDog hot, int price);

}
