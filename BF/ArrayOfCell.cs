using System;

namespace BF
{
    class ArrayOfCell
    {
        private Cell[] arr;

        private int pointerOfData;

        public ArrayOfCell(int n)
        {
            arr = new Cell[n];
            pointerOfData = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = new Cell();
            }
        }

        public void MoveRight()
        {
            pointerOfData++;
        }

        public void MoveLeft()
        {
            pointerOfData--;
        }

        public void IncreaseValue()
        {
            arr[pointerOfData].Value++;
        }

        public void DecreaseValue()
        {
            arr[pointerOfData].Value--;
        }

        public void Print()
        {
            Console.Write((char)arr[pointerOfData].Value);
        }

        public byte GetValue()
        {
            return arr[pointerOfData].Value;
        }


        //public void Write(byte value)
        //{
        //    arr[pointerOfData].Value = value;
        //}
    }
}
