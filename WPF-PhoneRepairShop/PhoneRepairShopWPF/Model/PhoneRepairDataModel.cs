namespace WPFPhoneRepairShop.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PhoneRepairDataModel : DbContext
    {
        public PhoneRepairDataModel() : base("name=PhoneRepairDataModel")
        {
        }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
    }
}