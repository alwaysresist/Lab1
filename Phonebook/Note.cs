using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Note
    {
        public string LastName;
        public string Name;
        public string Patronymic;
        public string Street;
        public ushort House=1;
        public ushort Flat=1;
        public string Phone;
        public override bool Equals(object obj)
        {
            Note other = (Note)obj;
            return this.LastName == other.LastName &&
                this.Name == other.Name &&
                this.Patronymic == other.Patronymic &&
                this.Street == other.Street &&
                this.House == other.House &&
                this.Flat == other.Flat &&
                this.Phone == other.Phone;
        }

        public override int GetHashCode()
        {
            return Flat * House % 1000;
        }

    }
    class CompareByLastName : IComparer<Note>
    {
        #region IComparer<Note> Members
        public int Compare(Note x, Note y)
        {
            return string.Compare(x.LastName, y.LastName);
        }
        #endregion
    }
    class CompareByFlat : IComparer<Note>
    {
        #region IComparer<Note> Members
        public int Compare(Note x, Note y)
        {
            return x.Flat.CompareTo(y.Flat);
        }
        #endregion
    }
    class CompareByName : IComparer<Note>
    {
        #region IComparer<Note> Members
        public int Compare(Note x, Note y)
        {
            return string.Compare(x.Name, y.Name);
        }
        #endregion
    }
    class CompareByPatronymic : IComparer<Note>
    {
        #region IComparer<Note> Members
        public int Compare(Note x, Note y)
        {
            return string.Compare(x.Patronymic, y.Patronymic);
        }
        #endregion
    }
    class CompareByStreet : IComparer<Note>
    {
        #region IComparer<Note> Members
        public int Compare(Note x, Note y)
        {
            return string.Compare(x.Street, y.Street);
        }
        #endregion
    }
    class CompareByHouse : IComparer<Note>
    {
        #region IComparer<Note> Members
        public int Compare(Note x, Note y)
        {
            return x.House.CompareTo(y.House);
        }
        #endregion
    }
    class CompareByPhone : IComparer<Note>
    {
        #region IComparer<Note> Members
        public int Compare(Note x, Note y)
        {
            return string.Compare(x.Phone, y.Phone);
        }
        #endregion
    }
}
