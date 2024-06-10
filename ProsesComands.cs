using System.Diagnostics;

namespace less6
{
    class ProcessComands
    {
        public void OutProses()
        {
            Console.WriteLine("[sys_mes]:Вывод процессов: ");
            Process[] proc = Process.GetProcesses();
            foreach (Process p in proc)
            {
                Console.WriteLine("Name: " + p.ProcessName + "\t \t \tId: " + p.Id);
            }

        }

        public void ExitProsesName(string name)
        {
            try
            {
                Process[] proc = Process.GetProcessesByName(name);
                foreach (Process p in proc)
                    p.Kill();
            }
            catch (Exception ex)
            {
                Console.WriteLine("[sys_mes]: Ошибка закрытия процесса по name: \n[sys_mes]: " + ex.Message);
                throw;
            }
            finally { Console.WriteLine("[sys_mes]: Процесс успешно остановлен."); }

        }

        public void ExitProsesId(int id)
        {
            try
            {
                Process proc = Process.GetProcessById(id);
                if (proc.Id == id) proc.Kill();

            }
            catch (Exception ex)
            {
                Console.WriteLine("[sys_mes]: Ошибка закрытия процесса по id: \n[sys_mes]: " + ex.Message);
                throw;
            }
            finally { Console.WriteLine("[sys_mes]: Процесс успешно остановлен."); }
        }

    }
}
