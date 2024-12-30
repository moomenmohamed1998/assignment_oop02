using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop02.Encapsulition
{
    internal class phonebook
    {

        #region Attributes
        string[] _Name;
        int[] _Number;
        public int _Size { get; set; }
        #endregion

        public phonebook(int Size)
        {
            _Name = new string[Size];
            _Number = new int[Size];
            _Size = Size;
        }

        public void Addpersone(int position, string Name, int Number)
        {
            if (_Name is not null && _Number is not null)
            {
                if (position < _Size)
                {
                    _Name[position] = Name;
                    _Number[position] = Number;
                }
            }

        }

        public int GetNumber(string Name)
        {
            for (int i = 0; i < _Name.Length; i++)
            {
                if (_Name[i] == Name)
                {
                    return _Number[i];
                }
            }
            return -1;
        }

        public void SetNumber(string Name, int NewNumber)
        {
            for (int i = 0; i < _Name.Length; i++)
            {
                if (_Name[i] == Name)
                {
                    _Number[i] = NewNumber;
                    break;
                }
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is phonebook phonebook &&
                   _Size == phonebook._Size;
        }

        public int this[string Name]
        {
            get
            {
                for (int i = 0; i < _Name.Length; i++)

                    if (_Name[i] == Name)

                        return _Number[i];


                return -1;
            }
            set
            {
                for (int i = 0; i < _Name.Length; i++)
                    if (_Name[i] == Name)
                    {
                        _Number[i] = value;
                        break;
                    }
            }
        }


        public string this[int Index]
        {
            get
            {
                return $"{Index}:: {_Name[Index]}::{_Number[Index]}";
            }
        }
    }
}
