using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LINQ
{
    public class Vehicle
    {
        public string Make {  get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Vehicle(string make, int year, double price)
        {
            Make = make;
            Year = year;
            Price = price;
        }
        // Phương thức lấy tên cty chủ quản (giả lập)
        
        public virtual string ToString()
        {
            return $"Hang: {Make}, Nam: {Year}, Gia: {Price}";
        }
    }
}
