namespace Task_12_1_5
{
    internal class Program
    {
        static void Main()
        {
            var users = new List<User>()
            {
                new User{Login = "Evgen", Name = "Евгений", IsPremium = false },
                new User{Login = "Nata", Name = "Наталья", IsPremium = false },
                new User{Login = "Dimon", Name = "Дмитрий", IsPremium = true },
            };

            Console.Write("Введите логин - ");            
            
            var login = Console.ReadLine();   

            User user = users.Find(item => item.Login == login);

            if (user == null)
                Console.WriteLine("Извините, но такого пользователя нет!");
            else
                ShowAds(user);            

            Console.ReadKey();
        }
        static void ShowAds(User user)
        {
            Console.WriteLine($"Здравствуйте {user.Name}, мы рады вас видеть!");

            if (!user.IsPremium)
            {
                Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
                // Остановка на 1 с
                Thread.Sleep(1000);

                Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
                // Остановка на 2 с
                Thread.Sleep(2000);

                Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
                // Остановка на 3 с
                Thread.Sleep(3000);
            }
        }
    }
}