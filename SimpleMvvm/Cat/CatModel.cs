using System;

namespace SimpleMvvm.Cat
{
    internal class CatModel
    {
        public string Name { get; private set; }

        public CatColor Color { get; private set; }

        public DateTime BirthDate { get; private set; } = DateTime.MinValue;

        public CatModel(string name, CatColor color, DateTime birthDate)
        {
            this.Name = name;
            this.Color = color;
            this.BirthDate = birthDate;
        }
    }
}
