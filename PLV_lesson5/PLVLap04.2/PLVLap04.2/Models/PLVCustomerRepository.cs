using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PLVLap04._2.Models
{
    public class PLVCustomerRepository : PLVICustomerRepository
    {
        static readonly List<PLVCustomer> data = new List<PLVCustomer>() 
        { 
        new PLVCustomer(){ CustomerId = "KH001",
        FullName = "Phan Lạc Việt",Address = "Hà Nội",
        Email = "lacvietphan578@gmail.com",
        Phone = "0978.611.889",Balance = 15200000},
        new PLVCustomer(){ CustomerId = "KH002",
        FullName = "Đỗ Thị Cúc",Address = "Hà Nội",
        Email = "cucdt@gmail.com",Phone = "0986.767.444",
        Balance = 2200000},
        new PLVCustomer(){ CustomerId = "KH003",
        FullName = "Nguyễn Tuấn Thắng",Address = "Nam Định",
        Email = "thangnt@gmail.com",Phone = "0924.656.542",
        Balance = 1200000},
        new PLVCustomer(){ CustomerId = "KH004",
        FullName = "Lê Ngọc Hải",Address = "Hà Nội",
        Email = "hailn@gmail.com",Phone = "0996.555.267",
        Balance = 6200000}
        };
        public IList<PLVCustomer> GetCustomers()
        {
            return data;
        }
        //thực thi phương thức tìm khách hàng theo tên
        public IList<PLVCustomer> SearchCustomer(string name)
        {
            return data.Where(c => c.FullName.EndsWith(name)).ToList();
        }
        //thực thi phương thức lấy khách hàng theo Id
        public PLVCustomer GetCustomer(string customerId)
        {
            return data.FirstOrDefault(c => c.CustomerId.Equals(customerId));
        }
        public void AddCustomer(PLVCustomer cus)
        {
            data.Add(cus);
        }
        //thực thi phương thức cập nhật khách hàng
        public void UpdateCustomer(PLVCustomer cus)
        {
            //lấy khách hàng theo id
            var customer = data.FirstOrDefault(c =>
            c.CustomerId.Equals(cus.CustomerId));
            //nếu có thì sửa thông tin
            if (customer != null)
            {
                customer.FullName = cus.FullName;
                customer.Address = cus.Address;
                customer.Email = cus.Email;
                customer.Phone = cus.Phone;
                customer.Balance = cus.Balance;
            }
        }

        //thực thi phương thức xóa khách hàng
        public void DeleteCustomer(PLVCustomer cus)
        {
            data.Remove(cus);
        }
    }
}