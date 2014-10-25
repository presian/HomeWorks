namespace _2_String_Disperser
{
    using System;
    using System.Collections;

    class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable
    {
        private string firstString;
        private string secondString;
        private string lastString;

        public StringDisperser(string firstString, string secondString, string lastString)
        {
            this.FirstString = firstString;
            this.SecondString = secondString;
            this.LastString = lastString;
        }

        public string FirstString
        {
            get
            {
                return this.firstString;
            }
            set
            {
                this.firstString = value;
            }
        }

        public string SecondString
        {
            get
            {
                return this.secondString;
            }
            set
            {
                this.secondString = value;
            }
        }

        public string LastString
        {
            get
            {
                return this.lastString;
            }
            set
            {
                this.lastString = value;
            }
        }

        public override int GetHashCode()
        {
            return this.FirstString.GetHashCode() ^
                this.SecondString.GetHashCode() ^
                this.LastString.GetHashCode();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            StringDisperser overridable = (StringDisperser)obj;
            if (overridable == null)
            {
                return false;
            }

            if (!(this.FirstString.Equals(overridable.FirstString)))
            {
                return false;
            }

            if (!(this.SecondString.Equals(overridable.SecondString)))
            {
                return false;
            }

            if (!(this.LastString.Equals(overridable.LastString)))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return this.FirstString + this.SecondString + this.LastString;
        }

        public static bool operator ==(StringDisperser firstStringDisperser, StringDisperser secondStringDisperser)
        {
            return StringDisperser.Equals(firstStringDisperser, secondStringDisperser);
        }

        public static bool operator !=(StringDisperser firstStringDisperser, StringDisperser secondStringDisperser)
        {
            return !(StringDisperser.Equals(firstStringDisperser, secondStringDisperser));
        }

        public object Clone()
        {
            return new StringDisperser(this.FirstString, this.SecondString, this.LastString);
        }

        public int CompareTo(StringDisperser other)
        {
            var compareValue = this.FirstString.CompareTo(other.FirstString);
            if (compareValue == 0)
            {
                compareValue = this.SecondString.CompareTo(other.SecondString);
                if (compareValue == 0)
                {
                    return this.LastString.CompareTo(other.LastString);
                }
                else
                {
                    return compareValue;
                }
            }
            else
            {
                return compareValue;
            }
        }

        public IEnumerator GetEnumerator()
        {
            string str = this.ToString();

            for (int character = 0; character < str.Length; character++)
            {
                yield return str[character];
            }
        }
    }
}
