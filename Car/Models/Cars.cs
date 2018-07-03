using System;
using System.Collections.Generic;

namespace Car.Models
{
  public class CarObject
  {
    private string _makeModel;
    private string _price;
    private string _miles;
    private string _color;
    private string _description;
    private static List<CarObject> _instances = new List<CarObject> {};

    public CarObject(string makeModel = "", string price = "", string miles = "", string color = "", string description = "")
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _color = color;
      _description = description;
    }

    public static List<CarObject> GetAll()
      {
         return _instances;
      }
      public void Save()
      {
        _instances.Add(this);
      }


    public void SetPrice(string newPrice)
    {
      _price = newPrice;
    }
    public string GetPrice()
    {
      return _price;
    }

    public void SetMakeModel (string newMakeModel)
    {
      _makeModel = newMakeModel;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }

    public void SetMiles (string newMiles)
    {
      _miles = newMiles;
    }
    public string GetMiles()
    {
      return _miles;
    }

    public void SetColor (string newColor)
    {
      _color = newColor;
    }
    public string GetColor()
    {
      return _color;
    }

    public void SetDescription (string newDescription)
    {
      _description = newDescription;
    }
    public string GetDescription()
    {
      return _description;
    }
  }
}
