using Api.OvoTestProject.Repository.Enums;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.OvoTestProject.Repository
{
    public class Audit : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AuditId { get; set; }
        [BindRequired]
        public UserAction UserAction { get; set; }
        public string Message { get; set; }
        [StringLength(150)]
        public string Key { get; set; }
        [StringLength(150)]
        public string Value { get; set; }
    }
}
