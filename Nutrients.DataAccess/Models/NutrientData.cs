using System;
using System.Collections.Generic;

namespace Nutrients.DataAccess.Models
{
    public partial class NutrientData
    {
        public string NDBNo { get; set; }
        public Nullable<double> Value { get; set; }
        public Nullable<int> DataPoints { get; set; }
        public Nullable<double> StdError { get; set; }
        public string RefNDBNo { get; set; }
        public string AddedNutrient { get; set; }
        public Nullable<short> NumStudies { get; set; }
        public Nullable<double> Min { get; set; }
        public Nullable<double> Max { get; set; }
        public Nullable<double> FreedomDegree { get; set; }
        public Nullable<double> LowErrorBound { get; set; }
        public Nullable<double> UpErrorBound { get; set; }
        public string StatComment { get; set; }
        public string ModDate { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
        public int Id { get; set; }
        public Nullable<int> DataSourceTypeId { get; set; }
        public Nullable<int> DerivationCodeId { get; set; }
        public Nullable<int> NutrientId { get; set; }
        public Nullable<int> FoodId { get; set; }
        public virtual DataSourceType DataSourceType { get; set; }
        public virtual DerivationCode DerivationCode { get; set; }
        public virtual Food Food { get; set; }
        public virtual Nutrient Nutrient { get; set; }
    }
}
