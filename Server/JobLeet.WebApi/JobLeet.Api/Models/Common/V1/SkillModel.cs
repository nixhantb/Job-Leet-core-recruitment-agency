﻿using System.Text.Json.Serialization;

namespace JobLeet.WebApi.JobLeet.Api.Models.Common.V1
{
    public class SkillModel : BaseModel
    {
        public List<string>? Title { get; set; }
        public List<string>? Description { get; set; }

        [JsonIgnore]
        public override MetaDataModel MetaData
        {
            get => base.MetaData;
            set => base.MetaData = value;
        }
    }
}
