using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GETO_.Models
{
    public class UserDetail
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
    public class OxyDonator
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Phone { get; set; }
        
        [Required]
        [Range(1,1000)]
        public int Capacity { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public bool IsVerified { get; set; }
        public string AddedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        
    }
    public class PlasmaDonor
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Phone { get; set; }
   
        [Required]
        public string BGroup { get; set; }
        public bool IsVerified { get; set; }
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        public string AddedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

    }
    public class ApiKeyModel
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string User { get; set; }
        public bool GetO2Data { get; set; }
        public bool O2Add { get; set; }
        public bool GetPlasmaData { get; set; }
        public bool AddPlasmaData { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
    public class RolesUser
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string role { get; set; }
    }
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public int parentId { get; set; }
    }
}
