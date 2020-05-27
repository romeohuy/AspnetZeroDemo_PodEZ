using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;

namespace PodEZ.PodEZTemplate.PodEz
{
	[Table("Categories")]
    public class Category : FullAuditedEntity 
    {

		[Required]
		public virtual string CategoryName { get; set; }
		

    }
}