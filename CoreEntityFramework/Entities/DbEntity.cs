using System;
using System.ComponentModel.DataAnnotations;

namespace CoreEntityFramework.Entities
{
    /// <summary>
    /// DbEntity.
    /// </summary>
    public abstract class DbEntity
    {
        [DataType(DataType.DateTime)]
        public DateTime DateCreatedUtc { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateLastModifiedUtc { get; set; }
    }
}