namespace ERP.Areas.HRM.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeeInfo
    {
        public Guid ID { get; set; }

        [StringLength(50)]
        public string EmpId { get; set; }

        [StringLength(100)]
        public string EmpName { get; set; }

        [StringLength(100)]
        public string FatherName { get; set; }

        [StringLength(100)]
        public string MotherName { get; set; }

        public Guid? OrganizationId { get; set; }

        public Guid? DepartmentId { get; set; }

        public Guid? DesignationId { get; set; }

        public Guid? JobTitleId { get; set; }

        public Guid? ReligionId { get; set; }

        public Guid? GradeId { get; set; }

        public Guid? ShiftId { get; set; }

        public Guid? CountryId { get; set; }

        public Guid? DistrictId { get; set; }

        [StringLength(50)]
        public string JoiningDate { get; set; }

        [StringLength(50)]
        public string NationalId { get; set; }

        [StringLength(1000)]
        public string PresentAddress { get; set; }

        [StringLength(1000)]
        public string PermanentAddress { get; set; }

        [StringLength(50)]
        public string DOB { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string BloodGroup { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BasicSalary { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GrossSalary { get; set; }

        [StringLength(50)]
        public string WorkingStatus { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [StringLength(50)]
        public string CreatedDate { get; set; }

        [StringLength(100)]
        public string UpdateBy { get; set; }

        [StringLength(50)]
        public string UpdateDate { get; set; }
    }
}
