var apple = new Product("Apple", Color.Green, Size.Small);
var tree = new Product("Tree", Color.Green, Size.Large);
var house = new Product("House", Color.Blue, Size.Large);

Product[] products = { apple, tree, house };

var bf = new BetterFilter();

Console.WriteLine("Green products (new):");

foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
{
    Console.WriteLine($" - {p.Name} is green");
}

Console.WriteLine("Large blue items");

foreach (var p in bf.Filter(products,
    new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
{
    Console.WriteLine($" - {p.Name} is big and blue");
}