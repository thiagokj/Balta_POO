using Plataform.ContentContext;
using Plataform.SubscriptionContext;

namespace Plataform
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // var course = new Course();
            // course.Level = EContentLevel.Beginner;
            // foreach (var item in course.Modules) { }

            // var carrer = new Carrer();
            // carrer.Items.Add(new CarrerItem());
            // Console.WriteLine($"Total Courses: {carrer.TotalCourses}");

            // var articles = new List<Article>();
            // articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            // articles.Add(new Article("Artigo sobre Dapper", "dapper-banco-de-dados"));
            // articles.Add(new Article("Artigo sobre Flutter", "flutter-dart"));

            // Console.WriteLine("Artigos");
            // Console.WriteLine("------------------------");
            // foreach (var article in articles)
            // {
            //     Console.WriteLine($"Id: {article.Id}");
            //     Console.WriteLine($"Título: {article.Title}");
            //     Console.WriteLine($"Url: {article.Url}");
            //     Console.WriteLine("");
            // }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos do OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos do C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos do ASP.NET", "fundamentos-aspnet");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            if (courseAspNet.IsInvalid)
            {

            }

            var carrers = new List<Carrer>();
            var carrerDotnet = new Carrer("Especialista .NET", "especialista-dotnet");
            var carrerItem1 = new CarrerItem(1, "Comece por aqui", "", null);
            var carrerItem2 = new CarrerItem(2, "Orientação a objetos", "", courseCsharp);
            var carrerItem3 = new CarrerItem(3, "Aprenda .NET", "", courseAspNet);

            carrerDotnet.Items.Add(carrerItem2);
            carrerDotnet.Items.Add(carrerItem3);
            carrerDotnet.Items.Add(carrerItem1);

            carrers.Add(carrerDotnet);

            foreach (var carrer in carrers)
            {
                Console.WriteLine($"Carreira: {carrer.Title}");

                foreach (var item in carrer.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine($"{item.Course?.Title}");
                    Console.WriteLine($"{item.Course?.Level}");

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"Notificação gerada: {notification.Property} - {notification.Message}.");
                    }
                }

                var payPalSubscription = new PayPalSubscription();
                var student = new Student();

                student.CreateSubscription(payPalSubscription);
            }
        }
    }
}