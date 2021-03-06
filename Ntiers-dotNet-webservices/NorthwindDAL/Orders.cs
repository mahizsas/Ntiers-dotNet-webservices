//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace NorthwindDAL
{
    using System;
    using System.Collections.Generic;


    [Serializable]
    [DataContract(IsReference = true)]
    public partial class Orders
    {
        public Orders()
        {
            this.Order_Details = new HashSet<Order_Details>();
        }

        [DataMember]
        public int OrderID { get; set; }
        [DataMember]
        public string CustomerID { get; set; }
        [DataMember]
        public Nullable<int> EmployeeID { get; set; }
        [DataMember]
        public Nullable<System.DateTime> OrderDate { get; set; }
        [DataMember]
        public Nullable<System.DateTime> RequiredDate { get; set; }
        [DataMember]
        public Nullable<System.DateTime> ShippedDate { get; set; }
        [DataMember]
        public Nullable<int> ShipVia { get; set; }
        [DataMember]
        public Nullable<decimal> Freight { get; set; }
        [DataMember]
        public string ShipName { get; set; }
        [DataMember]
        public string ShipAddress { get; set; }
        [DataMember]
        public string ShipCity { get; set; }
        [DataMember]
        public string ShipRegion { get; set; }
        [DataMember]
        public string ShipPostalCode { get; set; }
        [DataMember]
        public string ShipCountry { get; set; }

        
        public virtual Customers Customers { get; set; }
        
        public virtual Employees Employees { get; set; }
        
        public virtual ICollection<Order_Details> Order_Details { get; set; }
        
        public virtual Shippers Shippers { get; set; }
    }
}
