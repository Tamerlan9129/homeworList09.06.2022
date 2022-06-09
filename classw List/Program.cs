using System;
using System.Collections;

namespace classw_List
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] tamerlan = { 1, 2, 3 };
            ArrList list = new ArrList(9);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            //list.AddRange(tamerlan);
            //list.RemoveAt(2);
            list.GetAll();
           // list.Capacity();
           
        }

    }
    class ArrList 
    {
        public int Count { get; set; }
        public int Capacity { get; set; }
        private object[] _arr;
        
        public ArrList(int capacity) 
        {
            Capacity = capacity;
            _arr = new object[capacity];
        }

        public  void Add(int a) 
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = a;
        }
        public  void Remove(object obje)
        {
            for (int i = Array.IndexOf(_arr,obje); i < _arr.Length - 1; i++)
            {
                _arr[i] = _arr[i + 1];
                
            }
            Array.Resize(ref _arr, _arr.Length - 1);
        }
        public  void RemoveAt(int index)
        {
            for (int i = index; i < _arr.Length-1; i++)
            {
                _arr[i] = _arr[i + 1];
            }
            Array.Resize(ref _arr, _arr.Length - 1);

        }
        public  void TrimToSize()
        {
            Capacity = _arr.Length;
        }
        public void AddRange(object[] array) 
        {
            foreach (var item in array)
            {
                Array.Resize(ref _arr, _arr.Length + 1);
                _arr[_arr.Length - 1] = item;
            }
        }
        public void GetAll() 
        {
            for (int i = 0; i <_arr.Length; i++)
            {
                if (_arr[i] != null)
                {
                    Console.WriteLine(_arr[i]);
                }
            }
        }
        
    }
}
