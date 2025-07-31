using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Durations
{
    internal class Duration
    {

        #region Fields

        int h;
        int m;
        int s;

        #endregion

        #region Setters & Getters

        public void SetH(int _h) => h = _h;
        public void SetM(int _m) => m = _m;
        public void SetS(int _s) => s = _s;

        public int GetH() => h;
        public int GetM() => m;
        public int GetS() => s;

        #endregion

        #region Constructors

        public Duration(int _h, int _m, int _s)
        {
            simplify(_h, _m, _s);
        }
        public Duration(int _s)
        {
            simplify(0, 0, _s);
        }

        #endregion

        #region Another Methods

        public override string ToString()
        {
            return $"{h:D2}:{m:D2}:{s:D2}";
        }

        private void simplify(int _h, int _m, int _s)
        {
            h = _h;
            m = _m;
            s = _s;

            if (s >= 60)
            {
                m += s / 60;
                s = s % 60;
            }

            if (m >= 60)
            {
                h += m / 60;
                m = m % 60;
            }

            // prevent negative numbers
            if (s < 0 || m < 0 || h < 0)
            {
                h = 0;
                m = 0;
                s = 0;
            }
        }

        #endregion

        #region Operators Overloading

        public static Duration operator+(Duration d1,Duration d2)
        {
            int _h = d1.h + d2.h;
            int _m = d1.m + d2.m;
            int _s = d1.s + d2.s;
            return new Duration(_h, _m, _s);
        }
        public static Duration operator+(Duration d1,int seconds)
        {
            int _h = d1.h;
            int _m = d1.m;
            int _s = d1.s + seconds;
            return new Duration(_h, _m, _s);
        }
        public static Duration operator-(Duration d1, Duration d2)
        {
            int _h = d1.h - d2.h;
            int _m = d1.m - d2.m;
            int _s = d1.s - d2.s;

            if (_s < 0)
            {
                _s += 60;
                _m--;
            }

            if (_m < 0)
            {
                _m += 60;
                _h--;
            }

            if (_h < 0)
            {
                return new Duration(0, 0, 0);
            }

            return new Duration(_h, _m, _s);
        }
        public static Duration operator ++(Duration d)
        {
            return new Duration(d.h, d.m, d.s + 1);
        }
        public static Duration operator --(Duration d)
        {
            return new Duration(d.h, d.m, d.s - 1);
        }

        #endregion

    }
}
