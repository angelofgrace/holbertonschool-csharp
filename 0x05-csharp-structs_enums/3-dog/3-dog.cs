using System;

public enum Rating
{
    Good,
    Great,
    Excellent
}

public struct Dog 
{
    public Dog(string Name = "", float Age = 0, string Owner = "", Rating Rating = Rating.Good)
    {
        name = Name;
        age = Age;
        owner = Owner;
        rating = Rating;
    }

    public override string ToString()
    {
        return ("Dog Name: " + name + "\n" +
                "Age: " + age + "\n" +
                "Owner: " + owner + "\n" +
                "Rating: " + rating);
    }
    public string name;
    public float age;
    public string owner;
    public Rating rating;
}