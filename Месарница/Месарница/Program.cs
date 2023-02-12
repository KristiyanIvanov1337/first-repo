using System;

namespace Месарница
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
Console.Title = "Месарница"; double a, b, c, steakpr = 0.0, pigpr = 0.0, total = 0.0, budget = 0.0; Console.WriteLine("Списъk:"); Console.WriteLine("1-Кайма"); Console.WriteLine("2-Суджук"); var type = Console.ReadLine(); switch (type) { case "Кайма": do { Console.Write("Колко килограма кайма искате? "); a = double.Parse(Console.ReadLine()); if (a < 0) Console.WriteLine("Числото трябва да е положително"); } while (a < 0); b = (a * 0.6); c = (a * 0.4); Console.WriteLine($"За {a}KG кайма са ви необходими 60%({b}кг) свинско месо и 40% ({c}кг) телешко."); Console.Write("Цена за свинско месо– "); pigpr = double.Parse(Console.ReadLine()); Console.Write("Цена за телешко месо– "); steakpr = double.Parse(Console.ReadLine()); pigpr = pigpr * b; steakpr = steakpr * c; total = pigpr + steakpr; Console.WriteLine($"Общата инвестиция за месо е {pigpr}+{steakpr}={total}лв"); Console.Write("Бюджет с който разполагам- "); budget = double.Parse(Console.ReadLine()); if (budget < total) { Console.WriteLine($"Нямате достатъчно пари!!! Не ви достигат {total - budget} лв"); } else if (budget > total) { Console.WriteLine($"Имате достатъчно пари!!! Остават ви {budget - total} лв"); } break; case "Суджук": do { Console.Write("Колко килограма суджук искате? "); a = double.Parse(Console.ReadLine()); if (a < 0) Console.WriteLine("Числото трябва да е положително"); } while (a < 0); b = (a * 0.6); c = (a * 0.4); Console.WriteLine($"За {a}KG суджук са ви необходими 60%({b}кг) свинско месо и 40% ({c}кг) телешко."); Console.Write("Цена за свинско месо– "); pigpr = double.Parse(Console.ReadLine()); Console.Write("Цена за телешко месо– "); steakpr = double.Parse(Console.ReadLine()); pigpr = pigpr * b; steakpr = steakpr * c; total = pigpr + steakpr; Console.WriteLine($"Общата инвестиция за месо е {pigpr}+{steakpr}={total}лв"); Console.Write("Бюджет с който разполагам- "); budget = double.Parse(Console.ReadLine()); if (budget < total) { Console.WriteLine($"Нямате достатъчно пари!!! Не ви достигат {total - budget}лв"); } else if (budget > total) { Console.WriteLine($"Имате достатъчно пари!!! Остават ви {budget - total}лв"); } break; }


        }
    }
}
