﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsExamples.Common.Models;

namespace DesignPatternsExamples.HeroesWebService.Factories
{
	public interface IHeroFactory
	{
		List<Hero> GetAllHeroes();
		Hero CreateRandomHero();
		int HeroCount { get; }
	}
}
