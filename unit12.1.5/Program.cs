using System;


namespace unit12._1._5
{
    /// <summary>
    /// Для списка пользователей добавьте приветствие по имени. Если пользователь не имеет премиум-подписки, то ему нужно показать рекламу.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.ShowAds();
        }
    }
}
