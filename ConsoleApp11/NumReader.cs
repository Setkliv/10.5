using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_10._5
{
    internal class NumReader
    {
        public delegate void NumEnteredDelegate(int num);
        public event NumEnteredDelegate NumEnteredEvent;
        public int KeyRead()
        {
            Console.WriteLine("\n Пожалуйста, введите целое значение");
            int num = Convert.ToInt32(Console.ReadLine());
            NumEntered(num);
            return num;
        }
        protected virtual void NumEntered(int num)
        {
            NumEnteredEvent?.Invoke(num);
        }




    }
}
