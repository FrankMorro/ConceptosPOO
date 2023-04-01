namespace ConceptosOOP.Logic
{
    public class Date
    {
        #region Atributos

        private int _day;
        private int _month;
        private int _year;

        #endregion


        #region Constructores
        public Date()
        {
            _year = 1900;
            _month = 1;
            _day = 1;
        }

        public Date(int day, int month, int year)
        {
            //El orden de evaluacion y asignacion debe ser year, month y day
            _year = ValidateYear(year);
            _month = ValidateMonth(month);
            _day = ValidateDay(day);
        }

        #endregion

        #region Propiedades

        public int Day
        {
            get => _day;
            set => _day = ValidateDay(value);
        }

        public int Month
        {
            get => _month;
            set => _month = ValidateMonth(value);
        }

        public int Year
        {
            get => _year;
            set => _year = ValidateYear(value);
        }

        #endregion


        #region Métodos
        public override string ToString()
        {
            return $"{_day:00}/{_month:00}/{_year}";
        }

        private int ValidateYear(int year)
        {
            if (year < 0)
            {
                throw new ArgumentException("El año no es válido");
            }

            return year;
        }

        private int ValidateDay(int day)
        {
            if (day == 29 && _month == 2 && IsLeapYear(_year))
            {
                return day;
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day >= 1 && day <= daysPerMonth[_month])
            {
                return day;
            }

            throw new ArgumentException($"El día no es válido: {day}");
        }

        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 || year % 4 == 0 && year % 100 != 0);

            // Solo para logica
            //if (year % 4 == 0)
            //{
            //    if (year % 100 == 0)
            //    {
            //        if (year % 400 == 0)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    else
            //    {
            //        return true;
            //    }
            //}
            //else
            //{
            //    return false;
            //}
        }

        private int ValidateMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }

            throw new ArgumentException($"El mes no es válido: {month}");
        }

        #endregion
    }
}
