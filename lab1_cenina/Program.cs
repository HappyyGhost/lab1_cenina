
//Создание класса
//Класс "Сладости" содержит объекты трех типов
class Sweets
{
    public string Name { get; set; }
    public int Price { get; set; }
    public double Weight { get; set; }

    // Создание конструктора для дальнейшего определения объектов

    public Sweets(string name, int price, double weight)
    {
        Name = name;
        Price = price;
        Weight = weight;
    }


    //Преобразование экземпляров класса в строки для записи в файл

    public string ToString()
    {
        return $"{Name}, {Price}, {Weight}";
    }

}

class Program
{
    static void Main()
    {
        //Создание массива объектов класса с помощью List<T>

        List<Sweets> list = new List<Sweets>
        {
            new Sweets("Candy", 100, 3.4),
            new Sweets("Chocolate", 50, 3.8),
            new Sweets("Bagel", 200, 1.2),
            new Sweets("Biscuit", 679, 8.3),
            new Sweets("Cupcake", 300, 2.6),
            new Sweets("Yogurt", 550, 2.5),
            new Sweets("Tiramisu", 250, 9.6),
            new Sweets("Ice cream", 89, 3.6),
            new Sweets("Gelatine", 14, 1.4),
            new Sweets("Donut", 619, 7.9),
            new Sweets("Jam", 48, 2.8),
            new Sweets("Eclair", 10, 1.0),
        };

        //Метод записи в файл

        static void MakeFile(string file, List<Sweets> list)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                foreach (var Sweets in list)
                {
                    sw.WriteLine(Sweets.ToString());
                }
            }

        }


        //Методы сортировки по каждому из объектов массива
        //Сортировка по имени с помощью Compare и запись отсортированного массива в файл
        //с помощью метода MakeFile, описанного выше

        list.Sort((first, second) => string.Compare(first.Name, second.Name));
        MakeFile("name.txt", list);

        // Сортировка по цене с помощью CompareTo и запись отсортированного массива в файл
        //с помощью метода MakeFile, описанного выше

        list.Sort((first, second) => first.Price.CompareTo(second.Price));
        MakeFile("price.txt", list);

        // Сортировка по весу с помощью CompareTo и запись отсортированного массива в файл
        //с помощью метода MakeFile, описанного выше

        list.Sort((first, second) => first.Weight.CompareTo(second.Weight));
        MakeFile("weight.txt", list);

    }
}