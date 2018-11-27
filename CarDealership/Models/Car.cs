
using System.Collections.Generic;

namespace CarDealership.Models {

  public class Car
  {
    private string _Make;
    private string _Model;
    private int _Price;
    private int _Miles;
    private string _Note;
    private static List<Car> _inventory = new List<Car> {};

    public Car(string make, string model, int price, int miles, string note)
    {
      _Make = make;
      _Model = model;
      _Price = price;
      _Miles = miles;
      _Note = note;
    }

    public string GetMake()
    {
      return _Make;
    }
    public void SetMake(string newMake)
    {
      _Make = newMake;
    }
    public string GetModel()
    {
      return _Model;
    }
    public void SetModel(string newModel)
    {
      _Model = newModel;
    }
    public int GetPrice()
    {
      return _Price;
    }
    public void SetPrice(int newPrice)
    {
      _Price = newPrice;
    }
    public int GetMiles()
    {
      return _Miles;
    }
    public void SetMiles(int newMiles)
    {
      _Miles = newMiles;
    }
    public string GetNote()
    {
      return _Note;
    }
    public void SetNote(string newNote)
    {
      _Note = newNote;
    }


    public static List<Car> GetAll()
    {
      return _inventory;
    }
    public void Save()
    {
      _inventory.Add(this);
    }
    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return (_Price < maxPrice && _Miles < maxMiles);
    }
    public static void ClearAll()
    {
      _inventory.Clear();
    }
  }
}
