//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BareuFilterEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lawyer
    {
        public int ID_Lawyer { get; set; }
        public string LawyerSurname { get; set; }
        public string LawyerName { get; set; }
        public string LawyerMiddleName { get; set; }
        public int Seniority { get; set; }
        public Nullable<int> DiplomaUniversity_ID { get; set; }
        public Nullable<int> Client_ID { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual DiplomaUniversityTable DiplomaUniversityTable { get; set; }
    }
}
