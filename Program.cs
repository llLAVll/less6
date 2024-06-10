using less6;

Console.WriteLine("[sys_mes]: Добро пожаловать в Task Manager: ");
int numTask = -1;
do
{
    Console.WriteLine(
    "\n Выберете действие:" +
    "\n 1 - Вывод процессов" +
    "\n 2 - Завершить процесс по ID " +
    "\n 3 - Завершить процесс по Имени " +
    "\n 0 - Выход");

    numTask = Convert.ToInt32(Console.ReadLine());
    switch (numTask)
    {
        case 0:
            Console.WriteLine("[sys_mes]: До скорой встречи.");
            break;
        case 1:
            new ProcessComands().OutProses();
            break;
        case 2:
            Console.Write("[sys_mes]: Введите id процесса: ");
            int id = Convert.ToInt32(Console.ReadLine());
            new ProcessComands().ExitProsesId(id);
            break;
        case 3:
            Console.Write("[sys_mes]: Введите название процесса:");
            string name = Console.ReadLine();
            new ProcessComands().ExitProsesName(name);
            break;
        default:
            Console.WriteLine("[sys_mes]: Такой команды нет.");
            break;
    }
} while (numTask != 0);

