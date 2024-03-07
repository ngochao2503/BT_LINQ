using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LINQ
{
    public class Truck : Vehicle
    {
        // tải trọng , kiểu thùng , chiều dài

        public double PayloadCapacity { get; set; } // Tải trọng
        public string BedType { get; set; } // Kiểu thùng
        public double Length { get; set; } // Chiều dài

        public Truck(string make, int year, double price, double payloadCapacity, string bedType, double length) : base(make, year, price)
        {
            PayloadCapacity = payloadCapacity;
            BedType = bedType;
            Length = length;
        }
        
        // Phương thức hiển thị thông tin
        public override string ToString()
        {
            return base.ToString() + $", Tai trong: {PayloadCapacity}, Kieu thung: {BedType}, Chieu dai: {Length}";
        }

    }
}
