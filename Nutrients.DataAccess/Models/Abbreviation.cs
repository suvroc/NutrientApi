using System;
using System.Collections.Generic;

namespace Nutrients.DataAccess.Models
{
    public partial class Abbreviation
    {
        public string NDB_No { get; set; }
        public string Shrt_Desc { get; set; }
        public Nullable<double> Water__g_ { get; set; }
        public Nullable<int> Energ_Kcal { get; set; }
        public Nullable<double> Protein__g_ { get; set; }
        public Nullable<double> Lipid_Tot__g_ { get; set; }
        public Nullable<double> Ash__g_ { get; set; }
        public Nullable<double> Carbohydrt__g_ { get; set; }
        public Nullable<double> Fiber_TD__g_ { get; set; }
        public Nullable<double> Sugar_Tot__g_ { get; set; }
        public Nullable<int> Calcium__mg_ { get; set; }
        public Nullable<double> Iron__mg_ { get; set; }
        public Nullable<double> Magnesium__mg_ { get; set; }
        public Nullable<int> Phosphorus__mg_ { get; set; }
        public Nullable<int> Potassium__mg_ { get; set; }
        public Nullable<int> Sodium__mg_ { get; set; }
        public Nullable<double> Zinc__mg_ { get; set; }
        public Nullable<double> Copper_mg_ { get; set; }
        public Nullable<double> Manganese__mg_ { get; set; }
        public Nullable<double> Selenium__µg_ { get; set; }
        public Nullable<double> Vit_C__mg_ { get; set; }
        public Nullable<double> Thiamin__mg_ { get; set; }
        public Nullable<double> Riboflavin__mg_ { get; set; }
        public Nullable<double> Niacin__mg_ { get; set; }
        public Nullable<double> Panto_Acid_mg_ { get; set; }
        public Nullable<double> Vit_B6__mg_ { get; set; }
        public Nullable<double> Folate_Tot__µg_ { get; set; }
        public Nullable<double> Folic_Acid__µg_ { get; set; }
        public Nullable<double> Food_Folate__µg_ { get; set; }
        public Nullable<double> Folate_DFE__µg_ { get; set; }
        public Nullable<double> Choline_Tot___mg_ { get; set; }
        public Nullable<double> Vit_B12__µg_ { get; set; }
        public Nullable<int> Vit_A_IU { get; set; }
        public Nullable<double> Vit_A_RAE { get; set; }
        public Nullable<double> Retinol__µg_ { get; set; }
        public Nullable<double> Alpha_Carot__µg_ { get; set; }
        public Nullable<double> Beta_Carot__µg_ { get; set; }
        public Nullable<double> Beta_Crypt__µg_ { get; set; }
        public Nullable<double> Lycopene__µg_ { get; set; }
        public Nullable<double> Lut_Zea___µg_ { get; set; }
        public Nullable<double> Vit_E__mg_ { get; set; }
        public Nullable<double> Vit_D_µg { get; set; }
        public Nullable<double> Vit_D_IU { get; set; }
        public Nullable<double> Vit_K__µg_ { get; set; }
        public Nullable<double> FA_Sat__g_ { get; set; }
        public Nullable<double> FA_Mono__g_ { get; set; }
        public Nullable<double> FA_Poly__g_ { get; set; }
        public Nullable<int> Cholestrl__mg_ { get; set; }
        public Nullable<double> GmWt_1 { get; set; }
        public string GmWt_Desc1 { get; set; }
        public Nullable<double> GmWt_2 { get; set; }
        public string GmWt_Desc2 { get; set; }
        public Nullable<int> Refuse_Pct { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
        public int Id { get; set; }
        public Nullable<int> FoodId { get; set; }
        public virtual Food Food { get; set; }
    }
}
