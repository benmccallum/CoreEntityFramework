using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreEntityFramework.Entities
{
    /// <summary>
    /// DbEntity.
    /// </summary>
    public abstract class DbEntity
    {
        [Column(TypeName = "datetime2")]
        [DataType(DataType.DateTime)]
        public DateTime DateCreatedUtc { get; set; }

        [Column(TypeName = "datetime2")]
        [DataType(DataType.DateTime)]
        public DateTime DateLastModifiedUtc { get; set; }
    }
}