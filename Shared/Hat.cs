using Azure;
using Azure.Data.Tables;
using FaunaDB.Types;
using System;
using System.Text.Json.Serialization;

namespace Fritz.HatCollection.Shared
{

    public class Hat : ITableEntity
    {

        [FaunaConstructor]
        public Hat(string tag, string name, string description)
        {
            this.Tag = tag;
            this.RawName = name;
            this.Description = description;
        }

        public Hat() { }

        [FaunaField("tag")]
        public string Tag
        {
            get { return RowKey; }
            set { 
                RowKey = value; 
                PartitionKey = value.Substring(0,1);
            }
        }

        /// <summary>
        /// The human-readable name of the Hat in the collection
        /// </summary>
        /// <value></value>
        [FaunaField("name")]
        public string RawName { get; set; }

        public string Name
        {
            get { return string.IsNullOrEmpty(RawName) ? Tag : RawName; }
        }

        /// <summary>
        /// Brief description about the hat
        /// </summary>
        /// <value></value>
        [FaunaField("description")]
        public string Description { get; set; }

        [FaunaField("acquired")]
        public string Acquired { get; set; }

        [FaunaIgnore]
        public string ImageUrl { get; set; }
        [FaunaIgnore]
        public string PartitionKey { get; set; }
        [FaunaIgnore]
        public string RowKey { get; set; }
        [FaunaIgnore]
        public DateTimeOffset? Timestamp { get; set; }


        [FaunaIgnore]
        [JsonIgnore]
        public ETag ETag { get; set; }

        public override string ToString()
        {
            return $"Tag: {Tag}, Name: {Name}, Desc: {Description}";
        }

    }


}
