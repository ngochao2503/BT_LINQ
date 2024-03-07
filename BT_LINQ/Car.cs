using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LINQ
{
    public class Car : Vehicle
    {
        // số chổ ngồi, màu sắc , hôp số , loại động cơ , dung tích động cơ
        public int NumberOfSeats { get; set; } // Số chỗ ngồi
        public string Color { get; set; } // Màu sắc
        public string Transmission { get; set; } // Hộp số
        public string EngineType { get; set; } // Loại động cơ
        public double EngineDisplacement { get; set; } // Dung tích động cơ

        public Car(string make, int year, double price, int numberOfSeats, string color, string transmission, string engineType, double engineDisplacement) : base(make, year, price)
        {
            NumberOfSeats = numberOfSeats;
            Color = color;
            Transmission = transmission;
            EngineType = engineType;
            EngineDisplacement = engineDisplacement;
        }

        public override string ToString()
        {
            return base.ToString() + $", Cho ngoi: {NumberOfSeats}, Màu: {Color}, Hop so: {Transmission}, Loai dong co: {EngineType}, Dung tich đong co: {EngineDisplacement}";
        }
    }
}
