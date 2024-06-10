Console.WriteLine("[sys_mes]: Добро пожаловать в Task Manager: ");
int numTask = -1;
do
{
    Console.WriteLine(
    "\n Выберете действие:" +
    "\n 1 - Вывод процессов" +
    "\n 2 - Завершить процесс + " +
    "\n 0 - Выход");

    numTask = Convert.ToInt32(Console.ReadLine());
    switch (numTask)
    {
        case 0:

            break;
        case 1:

            break;
        case 2:

            break;
        default:
            Console.WriteLine("[sys_mes]: Такой команды нет.");
            break;
    }
} while (numTask != 0);

