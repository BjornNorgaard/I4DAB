//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HandinDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sensor
    {
        public int Id { get; set; }
        public int sensorId { get; set; }
        public int appartmentId { get; set; }
        public double value { get; set; }
        public string timestamp { get; set; }
    }
}
