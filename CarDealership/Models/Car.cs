using System;
using System.Collections.Generic;

namespace CarDealership.Models {

  class Car
  {
    private string Make;
    private string Model;
    private int Price;
    private int Miles;
    private string Note;
    private static List<cars> _inventory = new List<cars> {};

    public Car(string make, string model, int price, int miles, string note)
    {
      Make = make;
      Model = model;
      Price = price;
      Miles = miles;
      Note = note;
    }

    public string GetMake()
    {
      return Make;
    }
    public void SetMake(string newMake)
    {
      Make = newMake;
    }
    public string GetModel()
    {
      return Model;
    }
    public void SetModel(string newModel)
    {
      Model = newModel;
    }
    public int GetPrice()
    {
      return Price;
    }
    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }
    public int GetMiles()
    {
      return Miles;
    }
    public void SetMiles(int newMiles)
    {
      Miles = newMiles;
    }
    public string GetNote()
    {
      return Note;
    }
    public void SetNote(string newNote)
    {
      Note = newNote;
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
