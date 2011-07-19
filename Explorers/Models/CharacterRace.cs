﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WowDotNetAPI.Models
{
    [DataContract]
    public class CharacterRace
    {
        [DataMember(Name="id")]
        public string Id { get; set; }

        [DataMember(Name = "mask")]
        public int Mask { get; set; }

        [DataMember(Name = "side")]
        public string Side { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
