using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLVLap04._2.Models
{
    interface PLVICustomerRepository
    {
        //khai báo phương thức lấy danh sách khách hàng
        IList<PLVCustomer> GetCustomers();
        //khai báo phương thức lấy khách hàng
        PLVCustomer GetCustomer(string customerId);
        //khai báo phương thức thêm khách hàng
        void AddCustomer(PLVCustomer cus);
        //khai báo phương thức cập nhật khách hàng
        void UpdateCustomer(PLVCustomer cus);
        //khai báo phương thức tìm kiếm khách hàng
        IList<PLVCustomer> SearchCustomer(string name);
        //khai báo phương thức xóa khách hàng
        void DeleteCustomer(PLVCustomer cus);
    }
}
