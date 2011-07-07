﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WowDotNetAPI.Explorers.Models
{
	public class TalentSpecialization
	{
		public bool selected { get; set; }
		public string name { get; set; }
		public string icon { get; set; }
		public string build { get; set; }
		public IEnumerable<TalentTree> trees { get; set; }
		public GlyphList glyphs { get; set; }
	}
}
