using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;

namespace PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo
{
	[Table("PozOrderDemo")]
    public class PozOrderDemo : Entity<long>
    {
		[Required]
		public virtual string PozOrderName { get; set; }
		
		[Required]
		public virtual string PozOrderDescription { get; set; }
		
		[Required]
		public virtual decimal PozImageTotal { get; set; }
		

    }
}