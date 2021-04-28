using System;
namespace studing.Models{
    public class FundoCapital{
        //Guid is a uniq non-sequential identifier
        public FundoCapital()
        {
            id = Guid.NewGuid();
        }

        public Guid id { get; }
        public string name { get; set; }
        public decimal necessaryValue { get; set; }
        public int actualValue { get; set; }
        public DateTime? rescueDate { get; set; }
    }
}