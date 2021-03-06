using System;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string AnimalType { get; set; }
    public string Breed { get; set; }
    public string Sex { get; set; }
    public DateTime DateAdmitted { get; set; }

  }

  public enum AType
  {
    Dog,
    Cat,
    Fish
  }
}