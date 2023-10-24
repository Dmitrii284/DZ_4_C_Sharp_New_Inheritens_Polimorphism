namespace DZ_4_C_Sharp_New_Inheritens_Polimorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Money money = new Currency(10, 99, "USD");
            money.DisplayAmount();

            Product product = new Product(50, 75, "USD", "Product Name");
            product.DisplayAmount();

            Console.WriteLine("Decreasing price...");
            product.DecreasePrice(10);
            product.DisplayAmount();


            Console.WriteLine("Tasr_2\n");

            Teapot teapot = new Teapot("Электрический чайник");
            Nuke nuke = new Nuke("СВЧ печь");
            Car car = new Car("Легковой автомобиль");
            Steamboat steamboat = new Steamboat("Грузовой пароход");

            teapot.Show();
            teapot.Desc();
            teapot.Saund();

            nuke.Show();
            nuke.Desc();
            nuke.Saund();

            car.Show();
            car.Desc();
            car.Saund();

            steamboat.Show();
            steamboat.Desc();
            steamboat.Saund();

            Console.ReadLine();
        }
    }
    
}