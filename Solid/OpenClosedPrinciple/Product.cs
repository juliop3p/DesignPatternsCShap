public class Product
{
    public string Name;
    public Color color;
    public Size Size;

    public Product(string name, Color color, Size size)
    {
        if (name == null)
        {
            throw new ArgumentNullException(paramName: nameof(name));
        }

        Name = name;
        this.color = color;
        Size = size;
    }
}