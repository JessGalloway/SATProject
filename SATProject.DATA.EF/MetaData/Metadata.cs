using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SATProject.DATA.EF.Models //MetaData
{
    
    public class CourseMetaData 
    {
        //PK
        [Display(Name="Course")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "*Course Name is required")]
        [StringLength(50)]
        [Display(Name="Course Name")]
        public string CourseName { get; set; } = null!;

        [StringLength(1000)]
        [Display(Name = "Course Description")]
        public string CourseDescription { get; set; } = null!;

        [Required(ErrorMessage ="* credit hours required")]
        [Range(0, byte.MaxValue)]
        [Display(Name = "Credit Hours")]
        public byte CreditHours { get; set; }

        
        [StringLength(1000)]
        [Display(Name = "Curriculum")]
        public string? Curriculum { get; set; }

        [Display(Name = "Notes")]
        public string? Notes { get; set; }

        [Display(Name = "Currently offered?")]
        public bool? IsActive { get; set; }

    }

    public class EnrollmentMetaData 
    {
        //pk
        public int EnrollmentId { get; set; }

        [Display(Name = "Student")]
        public int StudentId { get; set; }

        [Required(ErrorMessage ="* Enrollement date must be set")]
        [Display(Name ="Enrollement Date")]
        public DateTime EnrollmentDate { get; set; }
        

    }

    public class ScheduledClassMetaData 
    {
        //PK
        public int ScheduledClassId { get; set; }

        //FK
        public int CourseId { get; set; }

        [ Required(ErrorMessage ="* Start Date is required") ]
        [Display(Name ="Start Date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "* Start Date is required")]
        [Display(Name = "Start Date")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "* A class must have an instructor")]
        [Display(Name = "Class Instructor")]
        public string InstructorName { get; set; } = null!;

        [Required(ErrorMessage = "* Abstract Classes are not offered")]
        [Display(Name = "Class Location")]
        public string Location { get; set; } = null!;


        public int Scsid { get; set; }

    }

    public class ScheduledClassStatusMetaData 
    {
        [Required(ErrorMessage ="* A class must have a status")]
        [Display(Name ="Class Status")]
        public string Scsname { get; set; } = null!;

    }

    public class StudentMetaData
    {
        [Required(ErrorMessage = "First Name Required")]
        [StringLength(20)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Last Name Required")]
        [StringLength(20)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [Display(Name = "Major")]
        [StringLength(15)]
        public string? Major { get; set; }

        [Display(Name ="Adress")]
        [StringLength(50)]
        public string? Address { get; set; }

        [Display(Name = "City")]
        [StringLength(25)]
        public string? City { get; set; }

        [Display(Name = "State")]
        [StringLength(2)]
        public string? State { get; set; }


        [Display(Name = "Zip Code")]
        [StringLength(10)]
        public string? ZipCode { get; set; }

        [Display(Name = "Phone")]
        [StringLength(13)]
        public string? Phone { get; set; }

        [Required(ErrorMessage ="Email is Required")]
        [Display(Name = "Email")]
        [StringLength(60)]
        public string Email { get; set; } = null!;

        [Display(Name = "Student Photo")]
        [StringLength(100)]
        public string? PhotoUrl { get; set; }

    }

    public class StudentStatusMetaData 
    {
        [Required(ErrorMessage ="Status Required")]
        [Display(Name = "Name")]
        [StringLength(30)]
        public string Ssname { get; set; } = null!;

        [Display(Name ="Status Description")]
        [StringLength(100)]
        public string? Ssdescription { get; set; }

    }
}
