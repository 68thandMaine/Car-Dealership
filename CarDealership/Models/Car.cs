using System;
using System.Collections.Generic;

namespace CarDealership.Models {

  class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;
    private string Note;
    private static List<cars> _inventory = new List<cars> {};

    public Car(string makeModel, int price, int miles, string note)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Note = note;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public string GetNote()
    {
      return Note;
    }

    public void SetNote(string newNote)
    {
      Note = newNote;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public void Save()
    {
      _inventory.Add(this);
    }
    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return (Price < maxPrice && Miles < maxMiles);
    }
  }
}
