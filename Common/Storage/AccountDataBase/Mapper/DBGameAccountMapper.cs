﻿/*
 * Copyright (C) 2018-2019 NullD project
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using NullD.Common.Storage.AccountDataBase.Entities;

namespace NullD.Common.Storage.AccountDataBase.Mapper
{
    public class DBGameAccountMapper : ClassMap<DBGameAccount>
    {
        public DBGameAccountMapper()
        {
            Id(e => e.Id).GeneratedBy.Native();
            References(e => e.DBAccount);
            Map(e => e.Banner).CustomSqlType("Blob");
            Map(e => e.LastOnline);
            HasMany(e => e.DBToons).Cascade.All();
            HasMany(e => e.DBInventories).Cascade.All();
            References(e => e.LastPlayedHero).Nullable();
            Map(e => e.Gold);
            Map(e => e.GoldHC);
            Map(e => e.StashSize);
            Map(e => e.StashSizeHC);
            Map(e => e.BarbarianPlayedTime);
            Map(e => e.BarbarianHighestLevel);
            Map(e => e.BarbarianHighestDifficulty);
            Map(e => e.DemonHunterPlayedTime);
            Map(e => e.DemonHunterHighestLevel);
            Map(e => e.DemonHunterHighestDifficulty);
            Map(e => e.MonkPlayedTime);
            Map(e => e.MonkHighestLevel);
            Map(e => e.MonkHighestDifficulty);
            Map(e => e.WitchDoctorPlayedTime);
            Map(e => e.WitchDoctorHighestLevel);
            Map(e => e.WitchDoctorHighestDifficulty);
            Map(e => e.WizardPlayedTime);
            Map(e => e.WizardHighestLevel);
            Map(e => e.WizardHighestDifficulty);
            Map(e => e.HighestDifficulty);
            Map(e => e.GoldCollected);
            Map(e => e.ElitesKilled);
            Map(e => e.MonstersKilled);
            Map(e => e.HardcoreMonstersKilled);
            Map(e => e.HighestHardcoreLevel);
        }
    }
}
