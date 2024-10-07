using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyControlSum
{
    internal class CheckSum
    {
        // CRC (Cyclic Redundancy Check) — это метод проверки целостности данных,
        // который широко используется в цифровых сетях и хранилищах данных для обнаружения ошибок.
        // CRC представляет собой хэш-функцию, которая вычисляет контрольную сумму или "проверочное значение"
        // для блока данных и используется для обнаружения случайных изменений в переданных данных.
        uint CRCSeed = 0xFFFFFFFF;
        private static uint count, range;
        private static List<uint> elements = new List<uint>();

        public bool initElements(uint elementCount, uint range)
        {
            count = elementCount;
            CheckSum.range = range;

            Random randomGenerator = new Random();

            for (int i = 0; i < elementCount; i++)
            {
                elements.Add((uint)randomGenerator.Next((int)CheckSum.range));
            }

            return true;
        }

        public List<uint> getElements()
        {
            return elements;
        }

        public bool UpdateElements(DataGridView elementsGrid)
        {
            bool tmp;
            tmp = true;
            for (int i = 0; i < elements.Count; i++)
            {
                uint element;

                tmp = tmp & UInt32.TryParse(
                    elementsGrid.Rows[i].Cells[0].Value.ToString(),
                    NumberStyles.HexNumber,
                    null,
                    out element
                );

                elements[i] = element;
            }

            return tmp;
        }

        public string CalcCheckSum(List<uint> elements)
        {
            uint result = 0;

            for (int i = 0; i < elements.Count; i++)
            {
                result += elements[i];
            }

            return (result ^ CRCSeed).ToString("X");
        }

        public bool CheckCRC(string prevCheckSum)
        {
            string newCheckSum = CalcCheckSum(elements);

            return newCheckSum == prevCheckSum;
        }
    }
}
