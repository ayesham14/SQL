//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RailwayReservationSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cancellation
    {
        public int cancellationId { get; set; }
        public Nullable<int> bookingId { get; set; }
        public Nullable<int> seats_cancelled { get; set; }
        public Nullable<System.DateTime> cancellation_date { get; set; }
    
        public virtual Booking Booking { get; set; }
    }
}
