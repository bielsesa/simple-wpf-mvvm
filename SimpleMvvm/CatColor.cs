using System.Windows.Media;

namespace SimpleMvvm
{
    public struct CatColor
    {
        public Brush ColorValue { get; }

        public string ColorName { get; }

        public CatColor(Brush colorValue, string colorName)
        {
            this.ColorValue = colorValue;
            this.ColorName = colorName;
        }

        public static readonly CatColor Black = new CatColor(Brushes.Black, "Black");
        public static readonly CatColor White = new CatColor(Brushes.White, "White");
        public static readonly CatColor Gray = new CatColor(Brushes.Gray, "Gray");
        public static readonly CatColor Orange = new CatColor(Brushes.Orange, "Orange");

        public static readonly CatColor[] AllColors = { Black, White, Gray, Orange };
    }
}