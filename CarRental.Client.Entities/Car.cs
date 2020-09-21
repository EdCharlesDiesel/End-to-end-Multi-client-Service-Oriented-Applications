using Core.Common.Core;

namespace CarRental.Client.Entities
{

    public class Car
    {
        private int _CarId;
        public int CarId
        {
            get { return _CarId; }
            set { _CarId = value; }
        }

        private string _Description;
        public string Desciption
        {
            get { return _Description; }
            set { _Description = value; }
        }
        
        private string _Color;
        public string Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        private int _Year;
        public int Year
        {
            get { return _Year; }
            set { _Year = value; }
        }

        private decimal _RentalPrice;
        public decimal RentalPrice
        {
            get { return _RentalPrice; }
            set { _RentalPrice = value; }
        }

        private bool _CurrentlyRented;
        public bool CurrentlyRented
        {
            get { return _CurrentlyRented; }
            set { _CurrentlyRented = value; }
        }


    }
}
